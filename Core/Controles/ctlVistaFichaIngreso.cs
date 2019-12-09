
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System;
using System.IO;
using System.Threading;
using Google.Apis.Util.Store;
using Core.Clases;
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlVistaFichaIngreso : UserControl
    {

        #region INICIALIZADOR

        public ctlVistaFichaIngreso()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }
        public UserCredential Pro_Credenciales { get; set; }
        public bool Pro_EsCargaDatos { get; set; }
        public bool Pro_ModoEdicion { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        string v_ruta_fotografia = "";
        static string[] Scopes = { DriveService.Scope.Drive };

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_EsCargaDatos = true;
            Pro_ModoEdicion = false;

            CargarDatos();
            CargarFotografiaColaborador();
        }

        private void CargarFotografiaColaborador()
        {
            if (!string.IsNullOrEmpty(v_ruta_fotografia))
            {
                if (!splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.ShowWaitForm();
                }

                PrepararDescarga();

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }          
        }

        private void CargarDatos()
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }
         
            try
            {
                DateTime v_fecha_nulos = new DateTime(1800, 1, 1);
                string sentencia = @"SELECT * FROM arca_tesoros.ft_view_ficha_ingreso (:p_id_colaborador );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    txtNombreColaborador.Text = pgDr.GetString("nombre_colaborador");
                    txtNumeroIdentidad.Text = pgDr.GetString("numero_identidad");
                    dateFechaNacimiento.EditValue = pgDr.GetDateTime("fecha_nacimiento") != v_fecha_nulos ? pgDr.GetDateTime("fecha_nacimiento") : dateFechaNacimiento.EditValue = "";
                    glEstadoCivil.EditValue = pgDr.GetString("estado_civil");
                    txtGenero.Text = pgDr.GetString("genero");
                    txtCorreoElectronico.Text = pgDr.GetString("correo_electronico");
                    memoDireccion.Text = pgDr.GetString("direccion");
                    txtCelular.Text = pgDr.GetString("celular");
                    glPaisNacimiento.EditValue = pgDr.GetString("pais_nacimiento");
                    glTipoSangre.EditValue = pgDr.GetString("tipo_sangre");
                    toggleNecesitaTransporte.IsOn = pgDr.GetBoolean("necesita_transporte");
                    dateFechaConversion.EditValue = pgDr.GetDateTime("fecha_conversion");
                    dateFechaIngresoIglesia.EditValue = pgDr.GetDateTime("fecha_ingreso_iglesia") != v_fecha_nulos ? pgDr.GetDateTime("fecha_ingreso_iglesia") : dateFechaIngresoIglesia.EditValue = "";
                    datFechaBautismoAgua.EditValue = pgDr.GetDateTime("fecha_bautismo_agua") != v_fecha_nulos ? pgDr.GetDateTime("fecha_bautismo_agua") : datFechaBautismoAgua.EditValue = "";
                    glEquipoArcaTesoros.EditValue = pgDr.GetString("equipo_arca_tesoros");
                    glCargos.EditValue = pgDr.GetString("cargo_colaborador");           
                    dateFechaCobertua.EditValue = pgDr.GetDateTime("fecha_cobertura") !=  v_fecha_nulos ? pgDr.GetDateTime("fecha_cobertura") : dateFechaCobertua.EditValue = "";
                    dateFechaReconciliacion.EditValue = pgDr.GetDateTime("fecha_reconciliacion") != v_fecha_nulos ? pgDr.GetDateTime("fecha_reconciliacion") : dateFechaReconciliacion.EditValue = "";
                    toggleBautismoEspiritu.IsOn = pgDr.GetBoolean("bautismo_espiritu");
                    glEdadArea.EditValue = pgDr.GetString("area_atencion");
                    dateFechaInicioPrivilegio.EditValue = pgDr.GetDateTime("fecha_inicio_privilegio") != v_fecha_nulos ? pgDr.GetDateTime("fecha_inicio_privilegio") : dateFechaInicioPrivilegio.EditValue = "";
                    txtOtrosEquiposPriviliegio.Text = pgDr.GetString("otros_equipos_privilegio");
                    glEmpresa.EditValue = pgDr.GetString("empresa");
                    txtCargo.Text = pgDr.GetString("cargo_en_empresa");
                    txtTelefonoEmpresa.Text = pgDr.GetString("telefono_empresa");
                    txtEstadoProfesional.Text = pgDr.GetString("estado_profesional");
                    txtNivelEducativo.Text = pgDr.GetString("nivel_educativo");
                    v_ruta_fotografia = pgDr.GetString("direccion_fotografia");
                    lblEncabezado.Text = "Ficha de Ingreso N°" + pgDr.GetString("id_ficha_ingreso");
                    toggleHabilitar.IsOn = pgDr.GetBoolean("habilitado");
                }

                pgDr.Close();


                ParidacionDatos();

                sentencia = null;
                pgDr = null;
                pgComando.Dispose();

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
            catch (PgSqlException Exc)
            {

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                MessageBox.Show(Exc.Message, "Arca de los Tesoros");

            }
        }

        private void HabilitarDeshabilitarColaborador()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            bool v_resultado = false;
            string sql = @"SELECT * FROM arca_tesoros.ft_mant_habilitar_deshabilitar_colaborador(:p_id_colaborador,
                                                                                                 :p_habilitar)";
            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;
            pgComando.Parameters.Add("p_habilitar", PgSqlType.Boolean).Value = toggleHabilitar.IsOn;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());

                if (!v_resultado)
                {
                    toggleHabilitar.IsOn = !toggleHabilitar.IsOn;
                    Utilidades.MostrarDialogo(FindForm(), "Mantenimiento de Empleados", "¡Algo salió mal en el momento de deshabilitar el colaborador!. Por favor intente nuevamente", Utilidades.BotonesDialogo.Ok);
                }
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "HabilitarDeshabilitarColaborador");
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
            picColaborador.Image = (Bitmap)bmp.Clone();
           

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
            using (System.IO.FileStream file = new System.IO.FileStream(pGuardarA, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                pStream.WriteTo(file);
                
            }

        }

        private static UserCredential GetCredentials()
        {
            UserCredential credential;

            using (var stream = new FileStream(@"C:\Users\Homero\Downloads\credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = @"C:\Users\Homero\Downloads";

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

        private void CargarDatosTipoSangre()
        {

            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_tipos_sangre();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);

            try
            {
                dsConfiguracion1.dtTiposSangre.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtTiposSangre);

                
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
            }
            catch (Exception Exc)
            {
                
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosTipoSangre");

            }
        }

        private void CargarDatosCargos()
        {

            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_cargos();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);

            try
            {
                dsConfiguracion1.dtCargos.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtCargos);

               
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
            }
            catch (Exception Exc)
            {
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
               
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosCargos");

            }
        }


        private void CargarDatosEstatusDoctrinal()
        {
            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_estatus_doctrinal();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia,v_conexion);

            try
            {
                dsConfiguracion1.dtEstatusDoctrinal.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEstatusDoctrinal);

               
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();

            }
            catch (Exception Exc)
            {
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosEstatusDoctrinal");

            }
        }

        private void CargarEstadosCiviles()
        {
            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_estados_civiles(:p_genero);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);
            pgComando.Parameters.Add("p_genero", PgSqlType.Boolean).Value = 2; //Masculino por defecto, lo siento feminazis
            
            try
            {
                dsConfiguracion1.dtEstadosCiviles.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEstadosCiviles);

                v_conexion.Close();
                v_conexion.Dispose();
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                v_conexion.Close();
                v_conexion.Dispose();
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarEstadosCiviles");

            }
        }

        private void CargarEmpresas()
        {
            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_empresas();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);

            try
            {
                dsConfiguracion1.dtEmpresas.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEmpresas);


                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();

            }
            catch (Exception Exc)
            {
                
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarEmpresas");

            }
        }


        private void CargarDatosEquipoArcaTesoros()
        {
            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_equipo_arca_tesoros();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);

            try
            {
                dsConfiguracion1.dtEquipoArcaTesoros.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEquipoArcaTesoros);

                v_conexion.Close();
                v_conexion.Dispose();
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosEquipoArcaTesoros");

            }
        }


        private void CargarDatosAreasAtencion()
        {

            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);

            try
            {
                dsConfiguracion1.dtAreasAtencion.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtAreasAtencion);

                
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                

            }
            catch (Exception Exc)
            {
              
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosAreasAtencion");

            }
        }


        private void CargarDatosPaises()
        {
            PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion.Password = Pro_Conexion.Password;
            v_conexion.Open();

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_paises();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion);

            try
            {
                dsConfiguracion1.dtPaises.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtPaises);

                sentencia = null;
                v_conexion.Close();
                v_conexion.Dispose();
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                pgComando.Dispose();
                v_conexion.Close();
                v_conexion.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosPaises");

            }
        }

        private void ParidacionDatos()
        {
            foreach (dsConfiguracion.dtEstadosCivilesRow item in dsConfiguracion1.dtEstadosCiviles)
            {
                if (item.descripcion == glEstadoCivil.EditValue.ToString() || glEstadoCivil.EditValue.ToString() == "SOLTERA")
                {
                    glEstadoCivil.EditValue = item.id_estado_civil;
                    break;
                }
            }

            foreach (dsConfiguracion.dtAreasAtencionRow item in dsConfiguracion1.dtAreasAtencion)
            {
                if (item.descripcion == glEdadArea.EditValue.ToString())
                {
                    glEdadArea.EditValue = item.id_area_atencion;
                    break;
                }
            }

            foreach (dsConfiguracion.dtPaisesRow item in dsConfiguracion1.dtPaises)
            {
                if (item.nombre_pais == glPaisNacimiento.EditValue.ToString())
                {
                    glPaisNacimiento.EditValue = item.id_pais;
                    break;
                }
            }

            foreach (dsConfiguracion.dtTiposSangreRow item in dsConfiguracion1.dtTiposSangre)
            {
                if (item.descripcion == glTipoSangre.EditValue.ToString())
                {
                    glTipoSangre.EditValue = item.id_tipo_sangre;
                    break;
                }
            }

            foreach (dsConfiguracion.dtCargosRow item in dsConfiguracion1.dtCargos)
            {
                if (item.descripcion == glCargos.EditValue.ToString())
                {
                    glCargos.EditValue = item.id_cargo;
                    break;
                }
            }

            foreach (dsConfiguracion.dtEstatusDoctrinalRow item in dsConfiguracion1.dtEstatusDoctrinal)
            {
                if (item.descripcion == glEstatusDoctrinal.EditValue.ToString())
                {
                    glEstatusDoctrinal.EditValue = item.id_estatus_doctrinal;
                    break;
                }
            }

            foreach (dsConfiguracion.dtEmpresasRow item in dsConfiguracion1.dtEmpresas)
            {
                if (item.nombre_empresa == glEmpresa.EditValue.ToString())
                {
                    glEmpresa.EditValue = item.id_empresa;
                    break;
                }
            }

            foreach (dsConfiguracion.dtEquipoArcaTesorosRow item in dsConfiguracion1.dtEquipoArcaTesoros)
            {
                if (item.id_equipo_arca_tesoros == glEquipoArcaTesoros.EditValue.ToString())
                {
                    glEquipoArcaTesoros.EditValue = item.id_equipo_arca_tesoros;
                    break;
                }
            }

        }

        #endregion

        #region EVENTOS CONTROLES

        private void TxtNombreColaborador_TextChanged(object sender, EventArgs e)
        {
            if (!Pro_EsCargaDatos)
            {
                Pro_ModoEdicion = true;
            }
        }

        private void BgCargarDatosConfigurcion_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CargarDatosTipoSangre();
            CargarEmpresas();
            CargarDatosEquipoArcaTesoros();
            CargarDatosAreasAtencion();
            CargarDatosPaises();
            CargarDatosCargos();
            CargarDatosEstatusDoctrinal();
            CargarEstadosCiviles();
        }

        private void ToggleHabilitar_Toggled(object sender, EventArgs e)
        {
            HabilitarDeshabilitarColaborador();
            
        }

        #endregion

        public void PicGuardarCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
