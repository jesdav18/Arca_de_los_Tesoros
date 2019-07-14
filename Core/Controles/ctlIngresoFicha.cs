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
        public static System.Text.Encoding UTF8 { get; }

        private void PicSiguientePag1_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page2;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "2 de 8";

        }

        private void PicSiguientePag2_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page3;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "3 de 8";
        }

        private void PicAtrasPag2_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page1;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "1 de 8";
        }

    

        private void PicAtrasPag4_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page3;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "3 de 8";

        }

        private void PicSiguientePag4_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page5;
            lblEncabezado.Text = "Datos Laborales y Educativos";
            lblPagina.Text = "5 de 8";
        }

        private void PicSiguientePag5_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page6;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "6 de 8";
        }

        private void PicAtrasPag5_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page4;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "4 de 8";
        }

        private void PicSiguientePag6_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page7;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "7 de 8";

        }

        private void PicAtrasPag6_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page5;
            lblEncabezado.Text = "Datos Laborales y Educativos";
            lblPagina.Text = "5 de 8";
        }

        private void PicAtrasPag7_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page6;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "6 de 8";
        }

        private void CmdGuardarFichaIngreso_Click(object sender, EventArgs e)
        {
            GuardarFichaIngreso();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            CargarDatosTipoSangre();
            CargarEstadosCiviles();
            CargarEmpresas();
            CargarDatosEquipoArcaTesoros();
            CargarDatosAreasAtencion();
            CargarDatosPaises();
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

                LimpiarCajasTexto();
            }
            catch (Exception Exc)
            {
                pgTrans.Rollback();
                sentencia = null;
                pgComando.Dispose();
                MessageBox.Show("Algo salió mal en el momento de generar la ficha de Ingreso. ", "Arca de los tesoros");
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlIngresoFicha", "GuardarFichaIngreso");
            }
        }

        private void LimpiarCajasTexto()
        {
           txtNombre.Text = "";
           txtApellido.Text = "";
           txtIdentidad.Text = "";
           txtEstadoProfesional.Text = "";
           txtNivelEducativo.Text = "";
           txtOtrosEquiposPrivilegio.Text = "";
           memoDireccion.Text = "";
           radioFemenino.Checked = false;
           radioMasculino.Checked = false;
           radioBautismoEspirituSi.Checked = false;
           radioBautismoEspirituNo.Checked = false;
           dateFechaNacimiento.EditValue = "";
           dateFechaIngresoIglesia.EditValue  ="";
           dateFechaCobertura.EditValue = "";
           dateFechaReconciliacion.EditValue = "";
           dateFechaBautismoAgua.EditValue = "";
           dateFechaConversion.EditValue = "";
           glPaisNacimiento.EditValue = "";
           glEstadosCiviles.EditValue ="";
           glTipoSangre.EditValue = "";
      
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

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

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

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
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

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
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

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
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

        private void PicSiguientePage3_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page4;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "4 de 8";
        }

        private void PicAtrasPage3_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page2;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "2 de 8";
        }

        private void PicAtrasPage8_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page7;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "7 de 8";
        }

        private void PicSiguientePage7_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page8;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "8 de 8";
        }
    }
}
