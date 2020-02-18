
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
using Core.Reportes;
using System.Diagnostics;
using System.Configuration;

namespace Core.Controles
{
    public partial class ctlVistaFichaIngreso : UserControl
    {

        #region INICIALIZADOR

        public ctlVistaFichaIngreso()
        {
            InitializeComponent();
            ctlCrearUsuario1.OnCerrar += ctlCrearUsuario1_OnCerrar;
            
        }

        private void ctlPonerModoEdicionNumeroIdentidad_OnClicModoEdicion_ClickModoEdicion(object sender, EventArgs e)
        {
            
        }

        private void ctlPonerModoEdicion1_OnClicModoEdicion(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }
        public UserCredential Pro_Credenciales { get; set; }
        public bool Pro_EsCargaDatos { get; set; }
        public bool Pro_ModoEdicion { get; set; }
        public Usuario Pro_Usuario { get; set; }
        public string Pro_UsuarioColaborador { get; set; }
        public string Pro_Genero { get; set; }
        public string Pro_ID_Pais { get; set; }
        public int Pro_ID_EstadoCivil { get; set; }
        public int Pro_ID_TipoSangre { get; set; }
        public int Pro_ID_Cargo { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }
        public  int Pro_ID_EstatusDoctrinal { get; set; }
        public int Pro_ID_Empresa { get; set; }
        public string Pro_ID_EquipoArca { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        string v_ruta_local = "";
        string v_id_generado = "";
        string v_ruta_fotografia = "";
        static string[] Scopes = { DriveService.Scope.Drive };

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador, Usuario pUsuario, string pGenero)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_EsCargaDatos = true;
            Pro_ModoEdicion = false;
            Pro_Usuario = pUsuario;
            Pro_Genero = pGenero;


            CargarEstadosCiviles();
            CargarDatos();
            CargarFotografiaColaborador();

            if (Pro_Usuario.Pro_ID_RolUsuario == 4) //Si es coordinador de edad , poner en modo lectura.
            {
                PonerModoLectura();              
            }
        }

        private void CargarFotografiaColaborador()
        {
            if (!string.IsNullOrEmpty(v_ruta_fotografia))
            {
                Cursor.Current = Cursors.WaitCursor;

                if (File.Exists(v_ruta_fotografia+ ".jpg"))
                {
                    var bmp = new Bitmap(v_ruta_fotografia + ".jpg");
                    picColaborador.Image = (Bitmap)bmp.Clone();
                }
                else
                {
                    PrepararDescarga();
                }

                Cursor.Current = Cursors.Arrow;
            }          
        }

        private void CargarDatos()
        {
          
            splashScreenManager1.ShowWaitForm();
            

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
                    txtEstadoCivil.Text = pgDr.GetString("estado_civil");
                    txtGenero.Text = pgDr.GetString("genero");
                    txtCorreoElectronico.Text = pgDr.GetString("correo_electronico");
                    memoDireccion.Text = pgDr.GetString("direccion");
                    txtCelular.Text = pgDr.GetString("celular");
                    txtPaisNacimiento.Text = pgDr.GetString("pais_nacimiento");
                    txtTipoSangre.Text = pgDr.GetString("tipo_sangre");
                    toggleNecesitaTransporte.IsOn = pgDr.GetBoolean("necesita_transporte");
                    dateFechaConversion.EditValue = pgDr.GetDateTime("fecha_conversion");
                    dateFechaIngresoIglesia.EditValue = pgDr.GetDateTime("fecha_ingreso_iglesia") != v_fecha_nulos ? pgDr.GetDateTime("fecha_ingreso_iglesia") : dateFechaIngresoIglesia.EditValue = "";
                    datFechaBautismoAgua.EditValue = pgDr.GetDateTime("fecha_bautismo_agua") != v_fecha_nulos ? pgDr.GetDateTime("fecha_bautismo_agua") : datFechaBautismoAgua.EditValue = "";
                    txtEquipoArcaTesoros.Text = pgDr.GetString("equipo_arca_tesoros");
                    txtCargoArcaTesoros.Text = pgDr.GetString("cargo_colaborador");           
                    dateFechaCobertua.EditValue = pgDr.GetDateTime("fecha_cobertura") !=  v_fecha_nulos ? pgDr.GetDateTime("fecha_cobertura") : dateFechaCobertua.EditValue = "";
                    dateFechaReconciliacion.EditValue = pgDr.GetDateTime("fecha_reconciliacion") != v_fecha_nulos ? pgDr.GetDateTime("fecha_reconciliacion") : dateFechaReconciliacion.EditValue = "";
                    toggleBautismoEspiritu.IsOn = pgDr.GetBoolean("bautismo_espiritu");
                    txtEdadArea.Text = pgDr.GetInt32("id_area_atencion") != 0 ? pgDr.GetString("area_atencion") : "";
                    dateFechaInicioPrivilegio.EditValue = pgDr.GetDateTime("fecha_inicio_privilegio") != v_fecha_nulos ? pgDr.GetDateTime("fecha_inicio_privilegio") : dateFechaInicioPrivilegio.EditValue = "";
                    txtOtrosEquiposPriviliegio.Text = pgDr.GetString("otros_equipos_privilegio");
                    txtEmpresa.Text = pgDr.GetString("empresa");
                    txtCargo.Text = pgDr.GetString("cargo_en_empresa");
                    txtTelefonoEmpresa.Text = pgDr.GetString("telefono_empresa");
                    txtEstadoProfesional.Text = pgDr.GetString("estado_profesional");
                    txtNivelEducativo.Text = pgDr.GetString("nivel_educativo");
                    v_ruta_fotografia = pgDr.GetString("direccion_fotografia");
                    lblEncabezado.Text = "Ficha de Ingreso N°" + pgDr.GetString("id_ficha_ingreso");
                    toggleHabilitar.IsOn = pgDr.GetBoolean("habilitado");
                    txtEditarPrimerNombre.Text = pgDr.GetString("primer_nombre");
                    txtEditarPrimerApellido.Text = pgDr.GetString("primer_apellido");
                    txtEditarSegundoNombre.Text = pgDr.GetString("segundo_nombre");
                    txtEditarSegundoApellido.Text = pgDr.GetString("segundo_apellido");
                    Pro_UsuarioColaborador = pgDr.GetString("usuario");
                    Pro_ID_Pais = pgDr.GetString("id_pais_nacimiento");
                    Pro_ID_EstadoCivil = pgDr.GetInt32("id_estado_civil");
                    Pro_ID_EstatusDoctrinal = pgDr.GetInt32("id_estatus_doctrinal");
                    Pro_ID_TipoSangre = pgDr.GetInt32("id_tipo_sangre");
                    Pro_ID_Empresa = pgDr.GetInt32("id_empresa");
                    Pro_ID_AreaAtencion = pgDr.GetInt32("id_area_atencion");
                    Pro_ID_Cargo = pgDr.GetInt32("id_cargo");
                    Pro_ID_EquipoArca = pgDr.GetString("id_equipo_arca_tesoros");
                    txtUsuario.Text = pgDr.GetString("usuario");

                }

                pgDr.Close();

           
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

        private void GuardarCambios()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_informacion_colaborador (
                                                                                                          :p_id_colaborador,
                                                                                                          :p_numero_identidad,
                                                                                                          :p_genero,
                                                                                                          :p_id_pais_nacimiento,
                                                                                                          :p_direccion,
                                                                                                          :p_id_estado_civil,
                                                                                                          :p_id_tipo_sangre,
                                                                                                          :p_estado_profesional,
                                                                                                          :p_nivel_educativo,
                                                                                                          :p_fecha_ingreso_iglesia,
                                                                                                          :p_fecha_cobertura,
                                                                                                          :p_fecha_reconciliacion,
                                                                                                          :p_fecha_bautismo_agua,
                                                                                                          :p_fecha_conversion,
                                                                                                          :p_bautismo_espiritu,
                                                                                                          :p_otros_equipos_privilegio,
                                                                                                          :p_id_estatus_doctrinal,
                                                                                                          :p_correo_electronico,
                                                                                                          :p_necesita_transporte,
                                                                                                          :p_equipo_arca_tesoros,
                                                                                                          :p_fecha_nacimiento,
                                                                                                          :p_id_empresa,
                                                                                                          :p_cargo_empresa,
                                                                                                          :p_id_cargo,
                                                                                                          :p_id_area_atencion,
                                                                                                          :p_usuario,
                                                                                                          :p_primer_nombre,
                                                                                                          :p_segundo_nombre,
                                                                                                          :p_primer_apellido,
                                                                                                          :p_segundo_apellido,
                                                                                                          :p_telefono_empresa,
                                                                                                          :p_celular,
                                                                                                          :p_fecha_inicio_privilegio,
                                                                                                          :p_ruta_fotografia
                                                                                                        );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;
            pgComando.Parameters.Add("p_numero_identidad", PgSqlType.VarChar).Value = txtNumeroIdentidad.Text;
            pgComando.Parameters.Add("p_genero", PgSqlType.VarChar).Value = txtGenero.Text;
            pgComando.Parameters.Add("p_id_pais_nacimiento", PgSqlType.VarChar).Value = !string.IsNullOrEmpty(glPaisNacimiento.Text) ? glPaisNacimiento.EditValue : Pro_ID_Pais;
            pgComando.Parameters.Add("p_direccion", PgSqlType.VarChar).Value = memoDireccion.Text;
            pgComando.Parameters.Add("p_id_estado_civil", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEstadoCivil.Text) ? glEstadoCivil.EditValue : Pro_ID_EstadoCivil;
            pgComando.Parameters.Add("p_id_tipo_sangre", PgSqlType.Int).Value = !string.IsNullOrEmpty(glTipoSangre.Text) ? glTipoSangre.EditValue : Pro_ID_TipoSangre;
            pgComando.Parameters.Add("p_estado_profesional", PgSqlType.VarChar).Value = txtEstadoProfesional.Text;
            pgComando.Parameters.Add("p_nivel_educativo", PgSqlType.VarChar).Value = txtNivelEducativo.Text;
            pgComando.Parameters.Add("p_fecha_ingreso_iglesia", PgSqlType.Date).Value = !string.IsNullOrEmpty(dateFechaIngresoIglesia.Text) ? dateFechaIngresoIglesia.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_cobertura", PgSqlType.Date).Value = !string.IsNullOrEmpty(dateFechaCobertua.Text) ? dateFechaCobertua.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_reconciliacion", PgSqlType.Date).Value = !string.IsNullOrEmpty(dateFechaReconciliacion.Text) ? dateFechaReconciliacion.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_bautismo_agua", PgSqlType.Date).Value = !string.IsNullOrEmpty(datFechaBautismoAgua.Text) ? datFechaBautismoAgua.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_conversion", PgSqlType.Date).Value = !string.IsNullOrEmpty(dateFechaConversion.Text) ? dateFechaConversion.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_bautismo_espiritu", PgSqlType.Boolean).Value = toggleBautismoEspiritu.IsOn;
            pgComando.Parameters.Add("p_otros_equipos_privilegio", PgSqlType.VarChar).Value = txtOtrosEquiposPriviliegio.Text;
            pgComando.Parameters.Add("p_id_estatus_doctrinal", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEstatusDoctrinal.Text) ? glEstatusDoctrinal.EditValue : Pro_ID_EstatusDoctrinal;
            pgComando.Parameters.Add("p_correo_electronico", PgSqlType.VarChar).Value = txtCorreoElectronico.Text;
            pgComando.Parameters.Add("p_necesita_transporte", PgSqlType.Boolean).Value = toggleNecesitaTransporte.IsOn;
            pgComando.Parameters.Add("p_equipo_arca_tesoros", PgSqlType.VarChar).Value = !string.IsNullOrEmpty(glEquipoArcaTesoros.EditValue.ToString()) ? glEquipoArcaTesoros.EditValue : Pro_ID_EquipoArca;
            pgComando.Parameters.Add("p_fecha_nacimiento", PgSqlType.Date).Value = !string.IsNullOrEmpty(dateFechaNacimiento.EditValue.ToString()) ? dateFechaNacimiento.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_id_empresa", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEmpresa.Text) ? glEmpresa.EditValue : Pro_ID_Empresa;
            pgComando.Parameters.Add("p_cargo_empresa", PgSqlType.VarChar).Value = txtCargo.Text;
            pgComando.Parameters.Add("p_id_cargo", PgSqlType.Int).Value = !string.IsNullOrEmpty(glCargos.Text) ? glCargos.EditValue : Pro_ID_Cargo;
            if (Pro_ID_Cargo == 1 || Pro_ID_Cargo == 2 || Pro_ID_Cargo == 3)
            {
                pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = 0;
            }
            else
            {
                pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEdadArea.Text) ? glEdadArea.EditValue : Pro_ID_AreaAtencion;
            }
                        
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario.Pro_Usuario;
            pgComando.Parameters.Add("p_primer_nombre", PgSqlType.VarChar).Value = txtEditarPrimerNombre.Text;
            pgComando.Parameters.Add("p_segundo_nombre", PgSqlType.VarChar).Value = txtEditarSegundoNombre.Text;
            pgComando.Parameters.Add("p_primer_apellido", PgSqlType.VarChar).Value = txtEditarPrimerApellido.Text;      
            pgComando.Parameters.Add("p_segundo_apellido", PgSqlType.VarChar).Value = txtEditarSegundoApellido.Text;
            pgComando.Parameters.Add("p_telefono_empresa", PgSqlType.VarChar).Value = txtTelefonoEmpresa.Text;
            pgComando.Parameters.Add("p_celular", PgSqlType.VarChar).Value = txtCelular.Text;
            pgComando.Parameters.Add("p_fecha_inicio_privilegio", PgSqlType.Date).Value = !string.IsNullOrEmpty(dateFechaInicioPrivilegio.Text) ? dateFechaInicioPrivilegio.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_ruta_fotografia", PgSqlType.VarChar).Value = v_ruta_fotografia;

            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();

            try
            {

                pgComando.ExecuteNonQuery();
                pgTrans.Commit();

               
                popupModificarNombre.HidePopup();
                this.ParentForm.BringToFront();

                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Los cambios fueron realizados!", Utilidades.BotonesDialogo.Ok);

                CargarDatos();

            }
            catch (Exception Exc)
            {
                pgTrans.Rollback();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "GuardarCambios");
                Utilidades.MostrarDialogo(FindForm(), "Falla en el ingreso de datos", "¡Algo falló mientras se actualizaba datos en la ficha de ingreso, por favor vuelva a intentarlo!", Utilidades.BotonesDialogo.Ok);

            }
        }

        private void ModificarFotografia()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.InitialDirectory = ConfigurationManager.AppSettings["DIRECTORIO_INICIAL_CARGA_FOTOS"];
                file.RestoreDirectory = true;
                file.Title = "Seleccione Imagen para la Ficha de Ingreso";
                file.Filter = ConfigurationManager.AppSettings["FILTRO_IMAGENES_COLABORADOR"];
                file.Multiselect = false;

                if (file.ShowDialog() == DialogResult.OK)
                {
                    v_ruta_local = file.FileName;

                    GuardarImagenEnDirectorio();
                
                    using (var fs = new System.IO.FileStream(file.FileName, System.IO.FileMode.Open))
                    {
                        var bmp = new Bitmap(fs);
                        picColaborador.Image = (Bitmap)bmp.Clone();
                    }
                }
            }
        }

        private void GuardarImagenEnDirectorio()
        {   
                Pro_Credenciales = GetCredentials();

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = Pro_Credenciales,
                    ApplicationName = "Carga_GoogleDrive",
                });

                CargarImagen(service);

                string pageToken = null;

                do
                {
                    ListaArchivos(service, ref pageToken);
                    if (!string.IsNullOrEmpty(lblID_Generado.Text))
                    {
                        pageToken = null;
                    }

                } while (pageToken != null);


                pageToken = null;
                service = null;
               
            
        }

        private static void ListaArchivos(DriveService p_servicio, ref string p_token_pagina)
        {

            FilesResource.ListRequest listRequest = p_servicio.Files.List();
            listRequest.PageSize = 1;
            listRequest.Fields = "nextPageToken, files(name)";
            listRequest.PageToken = p_token_pagina;
            listRequest.Q = "mimeType='image/jpeg'";

            var request = listRequest.Execute();

            if (request.Files != null && request.Files.Count > 0)
            {
                p_token_pagina = request.NextPageToken;

            }
        }

        private void CargarImagen(DriveService pServicio)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            var v_fileMetaData = new Google.Apis.Drive.v3.Data.File();
            v_fileMetaData.Name = Path.GetFileName(v_ruta_local);
            v_fileMetaData.MimeType = "imagen_prueba/jpeg";
            FilesResource.CreateMediaUpload v_request;

            using (var v_stream = new System.IO.FileStream(v_ruta_local, System.IO.FileMode.Open))
            {
                v_request = pServicio.Files.Create(v_fileMetaData, v_stream, "imagen_prueba/jpeg");
                v_request.Fields = "id";
                v_request.Upload();
                v_stream.Close();
            }

            var v_archivo = v_request.ResponseBody;
            v_id_generado = v_archivo.Id;
            v_ruta_fotografia = v_archivo.Id;
            lblID_Generado.Text = "ID Generado: " + v_archivo.Id;

            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
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

            try
            {
                Pro_Credenciales = GetCredentials();

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = Pro_Credenciales,
                    ApplicationName = "Carga_GoogleDrive",
                });



                DescargarImagen(service, v_ruta_fotografia);

                if (File.Exists(v_ruta_fotografia + ".jpg"))
                {
                    var bmp = new Bitmap(v_ruta_fotografia + ".jpg");
                    picColaborador.Image = (Bitmap)bmp.Clone();

                }



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
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "PrepararDescarga");
                MessageBox.Show(Exc.Message);
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
                           //Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            {
                                //Console.WriteLine("Download complete.");

                                GuardarStreaming(v_stream, pArchivo + ".jpg");
                                break;
                            }
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                         //   Console.WriteLine("Download failed.");
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

            if (Pro_Genero == "MASCULINO")
            {
                pgComando.Parameters.Add("p_genero", PgSqlType.Boolean).Value = 2; 
            }
            else
            {
                pgComando.Parameters.Add("p_genero", PgSqlType.Boolean).Value = 1; 
            }
           
            
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

        private void PonerModoLectura()
        {
            cmdEditarNombre.Visible = false;
            txtNumeroIdentidad.ReadOnly = true;
            txtGenero.ReadOnly = true;
            glEstadoCivil.ReadOnly = true;
            dateFechaNacimiento.ReadOnly = true;
            glEstadoCivil.ReadOnly = true;
            txtCorreoElectronico.ReadOnly = true;
            txtCelular.ReadOnly = true;
            glPaisNacimiento.ReadOnly = true;
            glTipoSangre.ReadOnly = true;
            toggleNecesitaTransporte.ReadOnly = true;
            memoDireccion.ReadOnly = true;
            dateFechaConversion.ReadOnly = true;
            dateFechaIngresoIglesia.ReadOnly = true;
            datFechaBautismoAgua.ReadOnly = true;
            glEquipoArcaTesoros.ReadOnly = true;
            glCargos.ReadOnly = true;
            glEstatusDoctrinal.ReadOnly = true;
            dateFechaCobertua.ReadOnly = true;
            dateFechaReconciliacion.ReadOnly = true;
            toggleBautismoEspiritu.ReadOnly = true;
            glEdadArea.ReadOnly = true;
            dateFechaInicioPrivilegio.ReadOnly = true;
            txtOtrosEquiposPriviliegio.ReadOnly = true;
            glEmpresa.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtTelefonoEmpresa.ReadOnly = true;
            txtEstadoProfesional.ReadOnly = true;
            txtNivelEducativo.ReadOnly = true;
            txtEstadoCivil.ReadOnly = true;
            txtPaisNacimiento.ReadOnly = true;
            txtTipoSangre.ReadOnly = true;
            txtEdadArea.ReadOnly = true;
            txtEquipoArcaTesoros.ReadOnly = true;
            txtCargoArcaTesoros.ReadOnly = true;
            txtEstatusDoctrinal.ReadOnly = true;
            txtEmpresa.ReadOnly = true;
            cmdGuardar.Visible = false;
            cmdAgregarUsuario.Visible = false;
            txtModificarRolUsuario.Visible = false;
            toggleHabilitar.Visible = false;

        }

        #endregion

        #region EVENTOS

        public event EventHandler OnPresionaIrAtras;

        #endregion

        #region EVENTOS CONTROLES
       
        private void BgCargarDatosConfigurcion_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CargarDatosTipoSangre();
            CargarEmpresas();
            CargarDatosEquipoArcaTesoros();
            CargarDatosAreasAtencion();
            CargarDatosPaises();
            CargarDatosCargos();
            CargarDatosEstatusDoctrinal();
        }

        private void ToggleHabilitar_Toggled(object sender, EventArgs e)
        {
            HabilitarDeshabilitarColaborador();
            
        }

        private void PicPdf_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            string v_nombre_documento = "Ficha_";

            rptFichaIngreso rptFicha = new rptFichaIngreso();
            rptFicha.ConstruirControl(Pro_Conexion, Pro_ID_Colaborador, Pro_Usuario);
            rptFicha.CreateDocument();

            v_nombre_documento = v_nombre_documento + Pro_ID_Colaborador.ToString() + ".pdf";

            rptFicha.ExportToPdf(v_nombre_documento);


            ProcessStartInfo startInfo = new ProcessStartInfo( v_nombre_documento);
            Process.Start(startInfo);

            Cursor.Current = Cursors.Arrow;
        }

        private void ctlCrearUsuario1_OnCerrar(object sender, EventArgs e)
        {
            popupCreacionUsuario.HidePopup();
            this.ParentForm.BringToFront();
            CmdActualizar_Click(sender, e);
        }

        private void PicAtras_Click(object sender, EventArgs e)
        {
            picColaborador.Image = null;
            OnPresionaIrAtras?.Invoke(sender, e);
        }

        private void PicCrearUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pro_UsuarioColaborador))
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "El colaborador " + txtEditarPrimerNombre.Text + " " + txtEditarPrimerApellido.Text + " ya posee un usuario para el sistema.", Utilidades.BotonesDialogo.Ok);
                return;
            }
            else if (Pro_ID_Cargo == 5)//Si es maestro
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "No es posible crear un usuario para un colaborador con cargo de Maestro.", Utilidades.BotonesDialogo.Ok);
                return;
            }



            popupCreacionUsuario.ShowPopup();
            ctlCrearUsuario1.ConstruirControl(Pro_Conexion,
                                              txtEditarPrimerNombre.Text,
                                              txtEditarSegundoNombre.Text,
                                              txtEditarPrimerApellido.Text,
                                              txtEditarSegundoApellido.Text,
                                              Pro_ID_Colaborador,
                                              Pro_UsuarioColaborador,
                                              Pro_ID_Cargo
                                              );
        }

        private void CmdEditarNombre_Click(object sender, EventArgs e)
        {
            popupModificarNombre.ShowPopup();
        }

        private void PopupModificarNombre_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            this.ParentForm.BringToFront();
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(glCargos.Text))
            {
                if ((int)glCargos.EditValue == 4 || (int)glCargos.EditValue == 5)
                {
                    if (string.IsNullOrEmpty(glEdadArea.Text))
                    {
                        Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "Es necesario que ingrese el Área de Atención para los cargos: Coordinadores de Edad y Maestros.", Utilidades.BotonesDialogo.Ok);
                        return;
                    }
                }
            }

            Cursor.Current = Cursors.WaitCursor;

            GuardarCambios();

            Cursor.Current = Cursors.Arrow;
        }

        private void CmdActualizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            CargarDatos();

            Cursor.Current = Cursors.Arrow;
        }

        private void PicColaborador_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ModificarFotografia();

            Cursor.Current = Cursors.Arrow;
        }

        #endregion


        private void GlCargos_EditValueChanged(object sender, EventArgs e)
        {
            txtCargoArcaTesoros.Text = glCargos.Text;
        }

        private void GlEquipoArcaTesoros_EditValueChanged(object sender, EventArgs e)
        {
            txtEquipoArcaTesoros.Text = glEquipoArcaTesoros.Text;
        }

        private void GlEstatusDoctrinal_EditValueChanged(object sender, EventArgs e)
        {
            txtEstatusDoctrinal.Text = glEstatusDoctrinal.Text;
        }

        private void GlEdadArea_EditValueChanged(object sender, EventArgs e)
        {
            txtEdadArea.Text = glEdadArea.Text;
        }

        private void GlEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpresa.Text = glEmpresa.Text;
        }

        private void GlPaisNacimiento_EditValueChanged(object sender, EventArgs e)
        {
            txtPaisNacimiento.Text = glPaisNacimiento.Text;
        }

        private void GlTipoSangre_EditValueChanged(object sender, EventArgs e)
        {
            txtTipoSangre.Text = glTipoSangre.Text;
        }

        private void GlEstadoCivil_EditValueChanged(object sender, EventArgs e)
        {
            txtEstadoCivil.Text = glEstadoCivil.Text;
        }

        private void TxtModificarRolUsuario_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            popupCreacionUsuario.ShowPopup();

            Cursor.Current = Cursors.Arrow;

            ctlCrearUsuario1.ConstruirControl(Pro_Conexion,
                                              txtEditarPrimerNombre.Text,
                                              txtEditarSegundoNombre.Text,
                                              txtEditarPrimerApellido.Text,
                                              txtEditarSegundoApellido.Text,
                                              Pro_ID_Colaborador,
                                              Pro_UsuarioColaborador,
                                              Pro_ID_Cargo,
                                              true
                                              );
        }

        private void PicVerImagen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            popupVerFoto.ShowPopup();
            if (File.Exists(v_ruta_fotografia + ".jpg"))
            {
                var bmp = new Bitmap(v_ruta_fotografia + ".jpg");
                picFotoGrande.Image = (Bitmap)bmp.Clone();
            }

            Cursor.Current = Cursors.Arrow;
        }

        private void PopupVerFoto_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            this.ParentForm.BringToFront();
        }
    }
}
