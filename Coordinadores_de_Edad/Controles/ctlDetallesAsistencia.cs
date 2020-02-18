using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.IO;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlDetallesAsistencia : UserControl
    {
        #region INICIALIZADOR

        public ctlDetallesAsistencia()
        {
            InitializeComponent();
            ctlCubrirAusencias1.OnCubrirAusenciaIngresada += ctlCubrirAusencias1_OnCubrirAusenciaIngresada;
            ctlCubrirAusencias1.OnIrAtras += ctlCubrirAusencias1_OnIrAtras;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public UserCredential Pro_Credenciales { get; set; }

        public bool Pro_Carnet {
            get
            {
                return v_carnet;
            }
            set
            {
                v_carnet = value;
                if (v_carnet)
                {
                    toggleCarnet.Image = Resources.switch_2_;
                }
                else
                {
                    toggleCarnet.Image = Resources.switch_3_;
                }
            }
        }

        public bool Pro_Uniforme {
            get
            {
                return v_uniforme;
            }
            set
            {
                v_uniforme = value;

                if (v_uniforme)
                {
                    toggleUniforme.Image = Resources.switch_2_;
                }
                else
                {
                    toggleUniforme.Image = Resources.switch_3_;
                }             
            }
        }

        public bool Pro_Presente {
            get
            {
                return v_presente;
            }
            set
            {
                v_presente = value;
                if (v_presente)
                {
                    picCaratulaAsistencia.Image = Resources.happy_1_;
                    NavegacionObservaciones.SelectedPage = page;
                }
                else
                {
                    picCaratulaAsistencia.Image = Resources.sad;
                    NavegacionObservaciones.SelectedPage = pageInasistencias;
                }
            }
        }

        public Usuario Pro_Usuario { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }


        #endregion

        #region VARIABLES GLOBALES

        private string v_motivo_inasistencia;
        private bool v_carnet;
        private bool v_uniforme;
        private bool v_presente;
        private string v_ruta_fotografia;
        static string[] Scopes = { DriveService.Scope.Drive };

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                    int pID_Colaborador,
                                    int pID_Actividad,
                                    bool pPresente,
                                    Usuario pUsuario,
                                    int pID_AreaAtencion)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_ID_Actividad = pID_Actividad;
            Pro_Presente = pPresente;
            Pro_Usuario = pUsuario;
            Pro_ID_AreaAtencion = pID_AreaAtencion;
            Pro_Carnet = false;
            Pro_Uniforme = false;

            CargarDatosColaborador();
            CargarFotografiaColaborador();
            CargarAulas();
        }

        private void CargarAulas()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_aulas (:p_id_area_atencion)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_AreaAtencion;
            

            try
            {
                dsVistas1.dtAulas.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtAulas);
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "MarcarAsistencia");
                        
            }

        }

        private int MarcarAsistencia(int pID_Colaborador,bool pGenerarEvento = true)
        {
            int v_id_colaborador_asistencia;

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_postear_asistencia (
                                                                                          :p_id_colaborador,
                                                                                          :p_presente,
                                                                                          :p_usando_uniforme,
                                                                                          :p_usando_carnet,
                                                                                          :p_id_actividad,
                                                                                          :p_motivo_inasistencia,
                                                                                          :p_observaciones, 
                                                                                          :p_aula
                                                                                        )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_presente", PgSqlType.Boolean).Value = Pro_Presente;
            pgComando.Parameters.Add("p_usando_uniforme", PgSqlType.Boolean).Value = Pro_Uniforme;
            pgComando.Parameters.Add("p_usando_carnet", PgSqlType.Boolean).Value = Pro_Carnet;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            pgComando.Parameters.Add("p_motivo_inasistencia", PgSqlType.VarChar).Value = v_motivo_inasistencia;
            pgComando.Parameters.Add("p_observaciones", PgSqlType.VarChar).Value = memoObservacionesInasistencia.Text;
            pgComando.Parameters.Add("p_aula", PgSqlType.Int).Value = glAula.EditValue;
         
            try
            {
                v_id_colaborador_asistencia = Convert.ToInt32(pgComando.ExecuteScalar());
               
                if (pGenerarEvento)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Confirmación de Registros", "¡La asistencia se procesó correctamente!", Utilidades.BotonesDialogo.Ok);
                    OnAsistenciaIngresada?.Invoke(new object(), new EventArgs());
                }

                return v_id_colaborador_asistencia;
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "MarcarAsistencia");
               
                return 0;
            }

        }

        private void CargarDatosColaborador()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_ficha_ingreso (:p_id_colaborador)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    txtNombreColaborador.Text = pgDr.GetString("nombre_colaborador");
                    txtIdentidadColaborador.Text = pgDr.GetString("numero_identidad");
                    txtFuerzasEspeciales.Text = pgDr.GetString("area_atencion");
                    v_ruta_fotografia = pgDr.GetString("direccion_fotografia");
                }

                pgDr.Close();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosColaborador");
               
            }
        }

        private void CargarFotografiaColaborador()
        {
            if (!string.IsNullOrEmpty(v_ruta_fotografia))
            {
                if (!splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.ShowWaitForm();
                }

                if (File.Exists(v_ruta_fotografia + ".jpg"))
                {
                    var bmp = new Bitmap(v_ruta_fotografia + ".jpg");
                    picFotoColaborador.Image = (Bitmap)bmp.Clone();
                }
                else
                {
                    PrepararDescarga();
                }

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
        }

        private static void ListFiles(DriveService service, ref string pageToken)
        {

            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 1;

            listRequest.Fields = "nextPageToken, files(name)";
            listRequest.PageToken = pageToken;
            listRequest.Q = "mimeType='image/jpeg'";


            var request = listRequest.Execute();


            if (request.Files != null && request.Files.Count > 0)
            {

                pageToken = request.NextPageToken;

                if (request.NextPageToken != null)
                {

                }
            }
        }

        private static void DescargarImagen(Google.Apis.Drive.v3.DriveService pServicio, string pArchivo)
        {
            var v_request = pServicio.Files.Get(pArchivo);
            var v_stream = new System.IO.MemoryStream();


            v_request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case Google.Apis.Download.DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            {
                                Console.WriteLine("Download complete.");

                                GuardarStreaming(v_stream, pArchivo + ".jpg");
                                break;
                            }
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            break;
                        }
                }
            };

            v_request.Download(v_stream);

        }

        private static void GuardarStreaming(System.IO.MemoryStream pStream, string pGuardarA)
        {
            if (!File.Exists(pGuardarA))
            {
                using (System.IO.FileStream file = new System.IO.FileStream(pGuardarA, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    pStream.WriteTo(file);

                }
            }
        }

        private void PrepararDescarga()
        {
            Pro_Credenciales = GetCredentials();

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = Pro_Credenciales,
                ApplicationName = "Carga_GoogleDrive",
            });

            DescargarImagen(service, v_ruta_fotografia);
            var bmp = new Bitmap(v_ruta_fotografia + ".jpg");
            picFotoColaborador.Image = (Bitmap)bmp.Clone();


            string pageToken = null;

            do
            {
                ListFiles(service, ref pageToken);
                if (!string.IsNullOrEmpty(v_ruta_fotografia))
                {
                    pageToken = null;
                }

            } while (pageToken != null);


            pageToken = null;
            service = null;

        }

        private static UserCredential GetCredentials()
        {
            UserCredential credential;

            using (var stream = new FileStream(@"credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(Application.StartupPath);

                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

            }

            return credential;
        }


        #endregion

        #region EVENTOS

        public event EventHandler OnAsistenciaIngresada;
        public event EventHandler OnIrAtras;

        #endregion

        #region EVENTOS CONTROLES

  
        private void CmdGuardarAsistencia_Click(object sender, EventArgs e)
        {
            MarcarAsistencia(Pro_ID_Colaborador);
        }

        private void ToggleUniforme_Click(object sender, EventArgs e)
        {
            Pro_Uniforme = !Pro_Uniforme;
        }

        private void ToggleCarnet_Click(object sender, EventArgs e)
        {
            Pro_Carnet = !Pro_Carnet;
        }

        private void CmdSeleccionarCubrirAusencia_Click(object sender, EventArgs e)
        {
            
            NavigationPrincipal.SelectedPage = PageCubrirAusencia;
            ctlCubrirAusencias1.ConstruirControl(Pro_Conexion, 
                                                 Pro_ID_Colaborador, 
                                                 Pro_Usuario,
                                                 Pro_ID_Actividad,
                                                 Pro_ID_AreaAtencion,
                                                 MarcarAsistencia(Pro_ID_Colaborador, false));

        }

        private void RadioProblemasFamiliares_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v_radio = (RadioButton)sender;
            v_motivo_inasistencia = v_radio.Text;
            
        }

        private void ctlCubrirAusencias1_OnIrAtras(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageDetalles;
        }

        private void ctlCubrirAusencias1_OnCubrirAusenciaIngresada(object sender, EventArgs e)
        {
            OnAsistenciaIngresada?.Invoke(new object(), new EventArgs());
        }

        #endregion

        private void CmdAtras_Click(object sender, EventArgs e)
        {
            OnIrAtras?.Invoke(sender, e);
        }
    }
}
