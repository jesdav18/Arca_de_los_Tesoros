using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;


namespace Core.Controles
{
    public partial class ctlIngresoFicha : UserControl
    {
        public ctlIngresoFicha()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            txtNombre.Focus();

            if (! bgCargarConfiguraciones.IsBusy)
            {
                bgCargarConfiguraciones.RunWorkerAsync();
            }
        }

        private void GuardarFichaIngreso()
        {

            splashScreenManager1.ShowWaitForm();

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
                                                                                              :p_usuario 
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_nombre", PgSqlType.VarChar).Value = txtNombre.Text;
            pgComando.Parameters.Add("p_apellido", PgSqlType.VarChar).Value = txtApellido.Text;
            pgComando.Parameters.Add("p_segundo_nombre", PgSqlType.VarChar).Value = txtSegundoNombre.Text;
            pgComando.Parameters.Add("p_segundo_apellido", PgSqlType.VarChar).Value = txtSegundoApellido.Text;
            pgComando.Parameters.Add("p_numero_identidad", PgSqlType.VarChar).Value = txtIdentidad.Text;
            

            if (radioFemenino.Checked)
            {
                pgComando.Parameters.Add("p_genero", PgSqlType.VarChar).Value = radioFemenino.Text;
            }
            else if (radioMasculino.Checked) {
                pgComando.Parameters.Add("p_genero", PgSqlType.VarChar).Value = radioMasculino.Text;
            }

            pgComando.Parameters.Add("p_fecha_nacimiento", PgSqlType.Date).Value = dateFechaNacimiento.EditValue;
            pgComando.Parameters.Add("p_id_pais_nacimiento", PgSqlType.VarChar).Value = glPaisNacimiento.EditValue;
            pgComando.Parameters.Add("p_direccion", PgSqlType.VarChar).Value = memoDireccion.Text;
            pgComando.Parameters.Add("p_id_estado_civil", PgSqlType.Int).Value = glEstadosCiviles.EditValue;
            pgComando.Parameters.Add("p_id_tipo_sangre", PgSqlType.Int).Value = glTipoSangre.EditValue;
            pgComando.Parameters.Add("p_estado_profesional", PgSqlType.VarChar).Value = txtEstadoProfesional.Text;
            pgComando.Parameters.Add("p_nivel_educativo", PgSqlType.VarChar).Value = txtNivelEducativo.Text;
            pgComando.Parameters.Add("p_fecha_ingreso_iglesia", PgSqlType.Date).Value = dateFechaIngresoIglesia.EditValue;
            pgComando.Parameters.Add("p_fecha_cobertura", PgSqlType.Date).Value = dateFechaCobertura.EditValue;
            pgComando.Parameters.Add("p_fecha_reconciliacion", PgSqlType.Date).Value = dateFechaReconciliacion.EditValue;
            pgComando.Parameters.Add("p_fecha_bautismo_agua", PgSqlType.Date).Value = dateFechaBautismoAgua.EditValue;
            pgComando.Parameters.Add("p_fecha_conversion", PgSqlType.Date).Value = dateFechaConversion.EditValue;

            if (radioBautismoEspirituSi.Checked)
            {
                pgComando.Parameters.Add("p_bautismo_espiritu_santo", PgSqlType.Boolean).Value = radioBautismoEspirituSi.Checked;
            }
            else if (radioBautismoEspirituNo.Checked)
            {
                pgComando.Parameters.Add("p_bautismo_espiritu_santo", PgSqlType.Boolean).Value = radioBautismoEspirituNo.Checked;
            }

            pgComando.Parameters.Add("p_otros_equipos_privilegio", PgSqlType.VarChar).Value = txtOtrosEquiposPrivilegio.Text;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;


            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();
            try
            {
                pgComando.ExecuteNonQuery();
                pgTrans.Commit();

                sentencia = null;
                pgComando.Dispose();

                splashScreenManager1.CloseWaitForm();

                LimpiarCajasTexto();
                MessageBox.Show("¡La ficha logró registrarse correctamente!");
            }
            catch (Exception Exc)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                pgTrans.Rollback();
                sentencia = null;
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "GuardarFichaIngreso");
                MessageBox.Show(Exc.Message, "Arca de los tesoros",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
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
           memoDireccion.Text = "";
           radioFemenino.Checked = false;
           radioMasculino.Checked = false;
           radioBautismoEspirituSi.Checked = false;
           radioBautismoEspirituNo.Checked = false;
           dateFechaNacimiento.Text = "";
           dateFechaIngresoIglesia.Text  ="";
           dateFechaCobertura.Text = "";
           dateFechaReconciliacion.Text = "";
           dateFechaBautismoAgua.Text = "";
           dateFechaConversion.Text = "";
           glPaisNacimiento.Text = "";
           glEstadosCiviles.Text ="";
           glTipoSangre.Text = "";
      
        }

        private bool ValidacionCajasTexto()
        {

            if (txtNombre.Text != "" && 
                txtApellido.Text != "" && 
                txtIdentidad.Text != "" && 
                memoDireccion.Text != "" &&
                (radioFemenino.Checked != false || radioMasculino.Checked != false) &&
                (radioBautismoEspirituSi.Checked != false || radioBautismoEspirituNo.Checked != false) &&
                dateFechaNacimiento.Text != "" &&
                dateFechaIngresoIglesia.Text != "" &&
                dateFechaConversion.Text != "" &&
                glPaisNacimiento.Text != "" &&
                glEstadosCiviles.Text != ""
            )
            {
                return true;
            }
            else {
                return false;
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
                MessageBox.Show("Algo salió mal en el momento de Configuracion de Tipos de Sangre ", "Arca de los Tesoros");
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
                MessageBox.Show("Algo salió mal en el momento de Configuracion de Estados Civiles ", "Arca de los Tesoros");
            }
        }

    

        private void CargarEmpresas()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
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
                MessageBox.Show("Algo salió mal en el momento de cargar Configuracion de Empresas ", "Arca de los Tesoros");
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
                MessageBox.Show("Algo salió mal en el momento de Configuracion de Equipo Arca Tesoros ", "Arca de los Tesoros");
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
                MessageBox.Show("Algo salió mal en el momento de cargar Configuracion de Areas Atención ", "Arca de los Tesoros");
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
                MessageBox.Show("Algo salió mal en el momento de cargar Configuracion de Paises. ", "Arca de los Tesoros");
            }
        }

        private void BgCargarConfiguraciones_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CargarDatosTipoSangre();         
            CargarEmpresas();
            CargarDatosEquipoArcaTesoros();
            CargarDatosAreasAtencion();
            CargarDatosPaises();
        }

        private void CmdGuardarFichaIngreso_Click(object sender, EventArgs e)
        {
            if (ValidacionCajasTexto())
            {
                GuardarFichaIngreso();
            }
            else
            {
                MessageBox.Show("¡Hay campos obligatorios que aún no han sido llenados!","Arca de los Tesoros",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }

        private void TxtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void IrAtras()
        {

            if (NavigationFicha.SelectedPage == Page2)
            {
                NavigationFicha.SelectedPage = Page1;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "1 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page3)
            {               
                NavigationFicha.SelectedPage = Page2;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "2 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page4)
            {
                NavigationFicha.SelectedPage = Page3;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "3 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page5)
            {
                NavigationFicha.SelectedPage = Page4;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "4 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page6)
            {
                NavigationFicha.SelectedPage = Page5;
                lblEncabezado.Text = "Datos Laborales y Educativos";
                lblPagina.Text = "5 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page7)
            {               
                NavigationFicha.SelectedPage = Page6;
                lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "6 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page8)
            {               
                NavigationFicha.SelectedPage = Page7;
                lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "7 de 8";
            }
            
        }

        public void IrAdelante()
        {
            if (NavigationFicha.SelectedPage == Page1)
            {
                NavigationFicha.SelectedPage = Page2;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "2 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page2)
            {
                NavigationFicha.SelectedPage = Page3;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "3 de 8";

                if (radioFemenino.Checked || radioMasculino.Checked)
                {
                    CargarEstadosCiviles();
                }

            }
            else if (NavigationFicha.SelectedPage == Page3)
            {
                NavigationFicha.SelectedPage = Page4;
                lblEncabezado.Text = "Datos Generales";
                lblPagina.Text = "4 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page4)
            {
                NavigationFicha.SelectedPage = Page5;
                lblEncabezado.Text = "Datos Laborales y Educativos";
                lblPagina.Text = "5 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page5)
            {
                NavigationFicha.SelectedPage = Page6;
                lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "6 de 8";

            }
            else if (NavigationFicha.SelectedPage == Page6)
            {
                NavigationFicha.SelectedPage = Page7;
                lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "7 de 8";
            }
            else if (NavigationFicha.SelectedPage == Page7)
            {
               
                NavigationFicha.SelectedPage = Page8;
                lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
                lblPagina.Text = "8 de 8";
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
    }
}
