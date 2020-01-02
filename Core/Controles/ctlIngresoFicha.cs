using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Configuration;
using System.Drawing;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using System.IO;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using System.Diagnostics;
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlIngresoFicha : UserControl
    {
        #region INICIALIZADOR

        public ctlIngresoFicha()
        {
            InitializeComponent();
            ctlIngresoEmpresa1.OnEmpresaRegistrada += ctlIngresoEmpresa1_OnEmpresaRegistrada;
        }


        #endregion

        #region EVENTOS

        public event EventHandler OnFichaIngresada;

        #endregion

        #region PROPIEDADES

        public bool Pro_EstaCreandoFicha { get; set; }
        public UserCredential Pro_Credenciales { get; set; }
        private PgSqlConnection Pro_Conexion { get; set; }
        private string Pro_Usuario { get; set; }
        private bool Pro_UsarUpperCase {
            get
            {
                return v_usar_upper_case;
            }
            set
            {
                v_usar_upper_case = value;
                if (v_usar_upper_case)
                {
                    txtNombre.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtSegundoNombre.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtApellido.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtSegundoApellido.Properties.CharacterCasing = CharacterCasing.Upper;
                    memoDireccion.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtCargoEnEmpresa.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtEstadoProfesional.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtNivelEducativo.Properties.CharacterCasing = CharacterCasing.Upper;
                    txtOtrosEquiposPrivilegio.Properties.CharacterCasing = CharacterCasing.Upper;
                }
                else
                {
                    txtNombre.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtSegundoNombre.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtApellido.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtSegundoApellido.Properties.CharacterCasing = CharacterCasing.Normal;
                    memoDireccion.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtCargoEnEmpresa.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtEstadoProfesional.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtNivelEducativo.Properties.CharacterCasing = CharacterCasing.Normal;
                    txtOtrosEquiposPrivilegio.Properties.CharacterCasing = CharacterCasing.Normal;
                }
            }
        }

        #endregion

        #region VARIABLES GLOBALES

        bool v_usar_upper_case;     
        static string[] Scopes = { DriveService.Scope.Drive };
        string v_ruta = "";
        string v_id_generado = "";

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     string pUsuario
                                     )
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            LimpiarCajasTexto();
            NavigationFicha.SelectedPage = Page1;

            Pro_UsarUpperCase = Convert.ToBoolean(ConfigurationSettings.AppSettings["USAR_UPPER_CASE"]);
           

            txtNombre.Focus();
            picAtras.Visible = false;

            if (! bgCargarConfiguraciones.IsBusy)
            {
                bgCargarConfiguraciones.RunWorkerAsync();
            }
        }


        private void GuardarFichaIngreso()
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_insertar_ficha_ingreso (
                                                                                              :p_nombre,
                                                                                              :p_apellido,
                                                                                              :p_segundo_nombre,
                                                                                              :p_segundo_apellido,
                                                                                              :p_numero_identidad,
                                                                                              :p_genero,
                                                                                              :p_fecha_nacimiento,
                                                                                              :p_id_pais_nacimiento,
                                                                                              :p_direccion,
                                                                                              :p_id_estado_civil,
                                                                                              :p_id_tipo_sangre,
                                                                                              :p_estado_profesional,
                                                                                              :p_nivel_educativo,
                                                                                              :p_fecha_ingreso_iglesia,
                                                                                              :p_fecha_cobertura ,
                                                                                              :p_fecha_reconciliacion ,
                                                                                              :p_fecha_bautismo_agua ,
                                                                                              :p_fecha_conversion ,
                                                                                              :p_bautismo_espiritu_santo ,
                                                                                              :p_otros_equipos_privilegio ,
                                                                                              :p_usuario,
                                                                                              :p_cargo_arca_tesoros,
                                                                                              :p_id_area_atencion,
                                                                                              :p_estatus_doctrinal,
                                                                                              :p_fecha_inicio_privilegio,
                                                                                              :p_telefono_fijo,
                                                                                              :p_celular,
                                                                                              :p_id_empresa,
                                                                                              :p_cargo_en_empresa,  
                                                                                              :p_telefono_empresa,
                                                                                              :p_equipo_arca_tesoros,
                                                                                              :p_ruta_imagen,
                                                                                              :p_correo_electronico
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_nombre", PgSqlType.VarChar).Value = txtNombre.Text;
            pgComando.Parameters.Add("p_apellido", PgSqlType.VarChar).Value = txtApellido.Text;
            pgComando.Parameters.Add("p_segundo_nombre", PgSqlType.VarChar).Value = txtSegundoNombre.Text;
            pgComando.Parameters.Add("p_segundo_apellido", PgSqlType.VarChar).Value = txtSegundoApellido.Text;
            pgComando.Parameters.Add("p_numero_identidad", PgSqlType.VarChar).Value = txtIdentidad.Text;
            pgComando.Parameters.Add("p_genero", PgSqlType.VarChar).Value = radioFemenino.Checked ? radioFemenino.Text : radioMasculino.Text;
            pgComando.Parameters.Add("p_fecha_nacimiento", PgSqlType.Date).Value = dateFechaNacimiento.EditValue;
            pgComando.Parameters.Add("p_id_pais_nacimiento", PgSqlType.VarChar).Value = !string.IsNullOrEmpty(glPaisNacimiento.EditValue.ToString()) ? glPaisNacimiento.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_direccion", PgSqlType.VarChar).Value = memoDireccion.Text;
            pgComando.Parameters.Add("p_id_estado_civil", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEstadosCiviles.EditValue.ToString()) ? glEstadosCiviles.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_id_tipo_sangre", PgSqlType.Int).Value = !string.IsNullOrEmpty(glTipoSangre.EditValue.ToString()) ? glTipoSangre.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_estado_profesional", PgSqlType.VarChar).Value = txtEstadoProfesional.Text;
            pgComando.Parameters.Add("p_nivel_educativo", PgSqlType.VarChar).Value = txtNivelEducativo.Text;
            pgComando.Parameters.Add("p_fecha_ingreso_iglesia", PgSqlType.Date).Value = dateFechaIngresoIglesia.EditValue != null ? dateFechaIngresoIglesia.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_cobertura", PgSqlType.Date).Value = dateFechaCobertura.EditValue != null ? dateFechaCobertura.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_reconciliacion", PgSqlType.Date).Value = dateFechaReconciliacion.EditValue != null ? dateFechaReconciliacion.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_bautismo_agua", PgSqlType.Date).Value = dateFechaBautismoAgua.EditValue != null ? dateFechaBautismoAgua.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_conversion", PgSqlType.Date).Value = dateFechaConversion.EditValue != null ? dateFechaConversion.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_bautismo_espiritu_santo", PgSqlType.Boolean).Value =  radioBautismoEspirituSi.Checked ? radioBautismoEspirituSi.Checked : radioBautismoEspirituNo.Checked;         
            pgComando.Parameters.Add("p_otros_equipos_privilegio", PgSqlType.VarChar).Value = txtOtrosEquiposPrivilegio.Text;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_cargo_arca_tesoros", PgSqlType.Int).Value = !string.IsNullOrEmpty(glArcaTesoros.EditValue.ToString()) ? glArcaTesoros.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEdadArea.EditValue.ToString()) ? glEdadArea.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_estatus_doctrinal", PgSqlType.Int).Value = !string.IsNullOrEmpty(glStatusDoctrinal.EditValue.ToString()) ? glStatusDoctrinal.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_fecha_inicio_privilegio", PgSqlType.Date).Value = dateInicioPrivilegio.EditValue != null ? dateInicioPrivilegio.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_telefono_fijo", PgSqlType.VarChar).Value = txtTelefonoFijo.Text;
            pgComando.Parameters.Add("p_celular", PgSqlType.VarChar).Value = txtCelular.Text;
            pgComando.Parameters.Add("p_id_empresa", PgSqlType.Int).Value = !string.IsNullOrEmpty(glEmpresa.EditValue.ToString()) ? glEmpresa.EditValue : DBNull.Value ;
            pgComando.Parameters.Add("p_cargo_en_empresa", PgSqlType.VarChar).Value = txtCargoEnEmpresa.Text;
            pgComando.Parameters.Add("p_telefono_empresa", PgSqlType.VarChar).Value = txtTelefonoEmpresa.Text;
            pgComando.Parameters.Add("p_equipo_arca_tesoros", PgSqlType.VarChar).Value = !string.IsNullOrEmpty(glEquipoArcaTesoros.EditValue.ToString()) ? glEquipoArcaTesoros.EditValue : DBNull.Value;
            pgComando.Parameters.Add("p_ruta_imagen", PgSqlType.VarChar).Value = v_id_generado;
            pgComando.Parameters.Add("p_correo_electronico", PgSqlType.VarChar).Value = txtCorreoElectronico.Text;

            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();

            try
            {

                pgComando.ExecuteNonQuery();
                pgTrans.Commit();

                Pro_EstaCreandoFicha = false;

                sentencia = null;
                pgComando.Dispose();
                LimpiarCajasTexto();
               
                OnFichaIngresada?.Invoke(new object(), new EventArgs());
                NavigationFicha.SelectedPage = Page1;

                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡La ficha fue almacenada!", Utilidades.BotonesDialogo.Ok);

            }
            catch (Exception Exc)
            {
                pgTrans.Rollback();
                pgComando.Dispose();
                Pro_EstaCreandoFicha = true;
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "GuardarFichaIngreso");
                Utilidades.MostrarDialogo(FindForm(), "Falla en el ingreso de datos", "¡Algo falló mientras creaba la ficha de ingreso, por favor vuelva a intentarlo!", Utilidades.BotonesDialogo.Ok);

            }
        }

        private void LimpiarCajasTexto()
        {
           txtNombre.Text = "";
           txtApellido.Text = "";
           txtIdentidad.Text = "";
           txtSegundoApellido.Text = "";
           txtSegundoNombre.Text = "";
           txtEstadoProfesional.Text = "";
           txtNivelEducativo.Text = "";
           txtOtrosEquiposPrivilegio.Text = "";
           txtTelefonoEmpresa.Text = "";
           txtCargoEnEmpresa.Text = "";
           memoDireccion.Text = "";
            txtTelefonoFijo.Text = "";
            txtCelular.Text = "";
            txtCorreoElectronico.Text = "";
         
           radioFemenino.Checked = false;
           radioMasculino.Checked = false;
           radioBautismoEspirituSi.Checked = false;
           radioBautismoEspirituNo.Checked = false;
            radioTipoFamiliaSoltero.Checked = false;
            radioTipoMiembroFamilia.Checked = false;
            radioNecesitaTransporteNo.Checked = false;
            radioNecesitaTransporteSi.Checked = false;

           dateFechaNacimiento.Text = "";
           dateFechaIngresoIglesia.Text  ="";
           dateFechaCobertura.Text = "";
           dateFechaReconciliacion.Text = "";
           dateFechaBautismoAgua.Text = "";
           dateFechaConversion.Text = "";
           dateInicioPrivilegio.Text = "";

           glEquipoArcaTesoros.Text = "";
           glPaisNacimiento.Text = "";
           glEstadosCiviles.Text ="";
           glTipoSangre.Text = "";
           glArcaTesoros.Text = "";
           glEdadArea.Text = "";
           glStatusDoctrinal.Text = "";
            glEmpresa.Text = "";

            lnlCargarFotografia.Text = "Cargar Fotografía";
        }

        private void GuardarImagenEnDirectorio()
        {

            if (ValidarImagenFueSeleccionada())
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
                Console.WriteLine("Done");
                Console.Read();
            }
        }

        private void CargarDatosTipoSangre() {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_tipos_sangre();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtTiposSangre.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtTiposSangre);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosTipoSangre");
             
            }
        }

        private void CargarDatosCargos()
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_cargos();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtCargos.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtCargos);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosCargos");
              
            }
        }


        private void CargarDatosEstatusDoctrinal()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_estatus_doctrinal();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtEstatusDoctrinal.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEstatusDoctrinal);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosEstatusDoctrinal");
              
            }
        }

        private void CargarEstadosCiviles()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_estados_civiles(:p_genero);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            if (radioFemenino.Checked)
            {
                pgComando.Parameters.Add("p_genero", PgSqlType.Boolean).Value = 1;
            }
            else if (radioMasculino.Checked)
            {
                pgComando.Parameters.Add("p_genero", PgSqlType.Boolean).Value = 2;
            }
            

            try
            {
                dsConfiguracion1.dtEstadosCiviles.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEstadosCiviles);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarEstadosCiviles");
               
            }
        }

        private void CargarEmpresas()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.ConnectionTimeout = 0;
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_empresas();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtEmpresas.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEmpresas);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarEmpresas");
               
            }
        }
        

        private void CargarDatosEquipoArcaTesoros()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_equipo_arca_tesoros();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtEquipoArcaTesoros.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtEquipoArcaTesoros);
            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosEquipoArcaTesoros");
               
            }
        }
        

        private void CargarDatosAreasAtencion()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtAreasAtencion.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtAreasAtencion);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosAreasAtencion");
               
            }
        }
        

        private void CargarDatosPaises()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_paises();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsConfiguracion1.dtPaises.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtPaises);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "CargarDatosPaises");
              
            }
        }

        public void IrAtras()
        {
            if (NavigationFicha.SelectedPage == Page2)
            {
                NavigationFicha.SelectedPage = Page1;
            }
            else if (NavigationFicha.SelectedPage == Page3)
            {
                NavigationFicha.SelectedPage = Page2;
            }
            else if (NavigationFicha.SelectedPage == Page4)
            {
                NavigationFicha.SelectedPage = Page3;
            }
            else if (NavigationFicha.SelectedPage == Page5)
            {
                NavigationFicha.SelectedPage = Page4;
            }
            else if (NavigationFicha.SelectedPage == Page6)
            {
                NavigationFicha.SelectedPage = Page5;
            }
            else if (NavigationFicha.SelectedPage == Page7)
            {
                NavigationFicha.SelectedPage = Page6;
            }
            else if (NavigationFicha.SelectedPage == Page8)
            {
                NavigationFicha.SelectedPage = Page7;
            }
        }

        public void IrAdelante()
        {
            if (ValidacionCampos())
            {
                if (NavigationFicha.SelectedPage == Page1)
                {
                    NavigationFicha.SelectedPage = Page2;
                }
                else if (NavigationFicha.SelectedPage == Page2)
                {
                    NavigationFicha.SelectedPage = Page3;
                    if (radioFemenino.Checked || radioMasculino.Checked)
                    {
                        CargarEstadosCiviles();
                    }
                }
                else if (NavigationFicha.SelectedPage == Page3)
                {
                    NavigationFicha.SelectedPage = Page4;
                }
                else if (NavigationFicha.SelectedPage == Page4)
                {
                    NavigationFicha.SelectedPage = Page5;
                }
                else if (NavigationFicha.SelectedPage == Page5)
                {
                    NavigationFicha.SelectedPage = Page6;
                }
                else if (NavigationFicha.SelectedPage == Page6)
                {
                    NavigationFicha.SelectedPage = Page7;
                }
                else if (NavigationFicha.SelectedPage == Page7)
                {
                    NavigationFicha.SelectedPage = Page8;
                }
            }
        }

        private bool ValidacionCampos()
        {
            if (NavigationFicha.SelectedPage == Page1)
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor Ingrese el primer nombre del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor Ingrese el primer apellido del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (NavigationFicha.SelectedPage == Page2)
            {
                if (string.IsNullOrEmpty(txtIdentidad.Text))
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor Ingrese el número identidad del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else if (!radioMasculino.Checked && !radioFemenino.Checked)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor seleccione género del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else if (dateFechaNacimiento.EditValue == null)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor seleccione fecha nacimiento del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else if (glPaisNacimiento.EditValue == null)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor seleccione pais nacimiento del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else if (NavigationFicha.SelectedPage == Page3)
            {
                if (string.IsNullOrEmpty(memoDireccion.Text))
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor ingrese dirección domicilio del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (NavigationFicha.SelectedPage == Page4)
            {
                if (glEstadosCiviles.EditValue == null)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor seleccione el estado civil del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (NavigationFicha.SelectedPage == Page8)
            {
                if (lnlCargarFotografia.Text == "Cargar Fotografía")
                {
                    Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor cargue la fotografía del colaborador!", Utilidades.BotonesDialogo.Ok);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private bool ValidarImagenFueSeleccionada()
        {
            if (string.IsNullOrEmpty(lnlCargarFotografia.Text) || lnlCargarFotografia.Text == "Cargar Fotografía")
            {
                Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Por favor cargue la fotografía del colaborador!", Utilidades.BotonesDialogo.Ok);
                return false;
            }
            else
            {
                return true;
            }
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

        private static UserCredential GetCredentials()
        {
            UserCredential credential;

            using (var stream = new FileStream(@"C:\credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = @"C:\";

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

        private void CargarImagen(DriveService pServicio)
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            var v_fileMetaData = new Google.Apis.Drive.v3.Data.File();
            v_fileMetaData.Name = Path.GetFileName(v_ruta);
            v_fileMetaData.MimeType = "imagen_prueba/jpeg";
            FilesResource.CreateMediaUpload v_request;

            using (var v_stream = new System.IO.FileStream(v_ruta, System.IO.FileMode.Open))
            {
                v_request = pServicio.Files.Create(v_fileMetaData, v_stream, "imagen_prueba/jpeg");
                v_request.Fields = "id";
                v_request.Upload();
                v_stream.Close();
            }

            var v_archivo = v_request.ResponseBody;
            v_id_generado = v_archivo.Id;
            lblID_Generado.Text = "ID Generado: " + v_archivo.Id;

            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        #endregion

        #region EVENTOS CONTROLES

        private void BgCargarConfiguraciones_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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

        private void CmdGuardarFichaIngreso_Click(object sender, EventArgs e)
        {

            if ((ValidacionCampos()))
            {
                if (!splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.ShowWaitForm();
                }

                GuardarImagenEnDirectorio();
                GuardarFichaIngreso();

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
               
            }
            else
            {
                Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Hay campos obligatorios que aún no han sido llenados!", Utilidades.BotonesDialogo.Ok);
                
            }        
        }

        private void TxtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PicSiguiente_Click(object sender, EventArgs e)
        { 
           IrAdelante();   
        }

        private void PicAtras_Click(object sender, EventArgs e)
        {
            IrAtras();
        }

        private void PicCargarFotografia_Click(object sender, EventArgs e)
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
                    v_ruta = file.FileName;
                    lnlCargarFotografia.Text = file.FileName;
                   
                    using (var fs = new System.IO.FileStream(file.FileName, System.IO.FileMode.Open))
                    {
                        var bmp = new Bitmap(fs);
                        picCargarFotografia.Image = (Bitmap)bmp.Clone();
                    }   
                }
            }         
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || 
                char.IsControl(e.KeyChar) || 
                char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }  
        }

        private void NavigationFicha_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            picAtras.Visible = true;
            picSiguiente.Visible = true;

            if (NavigationFicha.SelectedPage != Page1)
            {
                Pro_EstaCreandoFicha = true;
            }
           

            if (NavigationFicha.SelectedPage == Page1)
            {
                picAtras.Visible = false;
                txtNombre.Focus();
                lblEncabezado.Text = "Ingrese Datos Generales";
                lblPagina.Text = "1 de 8";
            } 
            else if (NavigationFicha.SelectedPage == Page2)
            {
                txtIdentidad.Focus();
                lblEncabezado.Text = "Ingrese Datos Generales";
                lblPagina.Text = "2 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page3)
            {
                txtTelefonoFijo.Focus();
                lblEncabezado.Text = "Ingrese Datos Generales";
                lblPagina.Text = "3 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page4)
            {
                glEstadosCiviles.Focus();
                lblEncabezado.Text = "Ingrese Datos Generales";
                lblPagina.Text = "4 de 8";

            }
            else if (NavigationFicha.SelectedPage == Page5)
            {
                glEmpresa.Focus();
                lblEncabezado.Text = "Ingrese Datos Laborales y Educativos";
                lblPagina.Text = "5 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page6)
            {
                dateFechaConversion.Focus();
                lblEncabezado.Text = "Ingrese Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "6 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page7)
            {
               
                glStatusDoctrinal.Focus();
                lblEncabezado.Text = "Ingrese Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "7 de 8";

            }
            else if (NavigationFicha.SelectedPage == Page8)
            {
                glEdadArea.Focus();
                lblEncabezado.Text = "Ingrese Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "8 de 8";
                picSiguiente.Visible = false;
            }
        }

        private void RadioFemenino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateFechaNacimiento.Focus();
            }
        }

        private void RadioTipoMiembroFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioNecesitaTransporteSi.Focus();
            }
        }

        private void RadioNecesitaTransporteNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                glTipoSangre.Focus();
            }
        }

        private void RadioBautismoEspirituNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                glEquipoArcaTesoros.Focus();
            }
        }

        private void TxtSegundoApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PicSiguiente_Click(sender, new EventArgs());
            }
        }

        private void PicCargarFotografia_DoubleClick(object sender, EventArgs e)
        {
            if (lnlCargarFotografia.Text != "Cargar Fotografía")
            {
                PopupVisualizadorFoto.ShowPopup();
                picFotoColaborador.Image = Image.FromFile(lnlCargarFotografia.Text);
            }         
        }

        private void PicCerrarPopupFoto_Click(object sender, EventArgs e)
        {
            PopupVisualizadorFoto.HidePopup();
            this.Parent.BringToFront();
        }

        private void CtlIngresoFicha_SizeChanged(object sender, EventArgs e)
        {
            int v_tamañoWidth = this.Size.Width - pnlDerecho.Size.Width - pnlCentral.Size.Width;

            NavigationFicha.Size = new Size((v_tamañoWidth / 2), NavigationFicha.Size.Height);

            panel3.Size = new Size((v_tamañoWidth / 2), panel3.Size.Height);
        }

        private void LnlCargarFotografia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PicCargarFotografia_Click(sender, new KeyEventArgs(Keys.Enter));
            }
        }

        private void TxtOtrosEquiposPrivilegio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lnlCargarFotografia.Focus();
            }
        }

       
        private void CmdAgreagarNuevaEmpresa_Click(object sender, EventArgs e)
        {
            popupAgregarNuevaEmpresa.ShowPopup();
            ctlIngresoEmpresa1.ConstruirControl(Pro_Conexion);
        }

        private void PopupAgregarNuevaEmpresa_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            this.Parent.Parent.Parent.BringToFront();
        }

        private void ctlIngresoEmpresa1_OnEmpresaRegistrada(object sender, EventArgs e)
        {
            int v_id_empresa = (int)sender;

            CargarEmpresas();

            glEmpresa.EditValue = v_id_empresa;

            popupAgregarNuevaEmpresa.HidePopup();

        }


        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) || !string.IsNullOrEmpty(txtApellido.Text))
            {
                Pro_EstaCreandoFicha = true;
            }

        }

        #endregion
    }
}
