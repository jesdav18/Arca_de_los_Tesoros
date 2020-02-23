using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Drawing;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlIngresoSolicitudesCordinadorEdad : UserControl
    {

        #region INICIALIZADOR

        public ctlIngresoSolicitudesCordinadorEdad()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;

            CargarDatosTipoSolicitud();
            LimpiarCajasTexto();

            CargarMisSolicitudes();

        }

        private void CargarMisSolicitudes()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            string sql = @"SELECT * FROM arca_tesoros.ft_view_mis_solicitudes (
                                                                                  :p_id_colaborador
                                                                                )";
            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;

            try
            {
                dsVistas1.dtMisSolicitudes.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtMisSolicitudes);


            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarMisSolicitudes");

            }


            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }
        }


        private void CargarDatosTipoSolicitud()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            string sentencia = @"SELECT * FROM arca_tesoros_conf.ft_view_tipo_solicitud();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
           
            try
            {
                dsConfiguracion1.dtTiposSolicitud.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtTiposSolicitud);

       
                sentencia = null;
                pgComando.Dispose();
                pgComando = null;


                if (splashScreenManager1.IsSplashFormVisible)
                {

                    splashScreenManager1.CloseWaitForm();
                }


            }
            catch (Exception Exc)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosTipoSolicitud");
                
            }
            
        }

        private void GuardarSolicitud()
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_insertar_solicitud_coordinador_edad (
                                                                                                          :p_tipo_solicitud,
                                                                                                          :p_fecha_ejecucion,
                                                                                                          :p_observaciones,
                                                                                                          :p_id_colaborador_solicitante
                                                                                                        )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_tipo_solicitud", PgSqlType.Int).Value = glTipoSolicitud.EditValue;
            pgComando.Parameters.Add("p_fecha_ejecucion", PgSqlType.Date).Value = dateFechaSolicitud.EditValue;
            pgComando.Parameters.Add("p_observaciones", PgSqlType.VarChar).Value = txtObservacionesSolicitud.Text;
            pgComando.Parameters.Add("p_id_colaborador_solicitante", PgSqlType.Int).Value = Pro_ID_Colaborador;
           
            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();
            try
            {
                pgComando.ExecuteNonQuery();
                pgTrans.Commit();

                sentencia = null;
                pgComando.Dispose();




                if (splashScreenManager1.IsSplashFormVisible)
                {

                    splashScreenManager1.CloseWaitForm();
                }

              

                LimpiarCajasTexto();

                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡La solicitud fue enviada al coordinador de día!", Utilidades.BotonesDialogo.Ok);
                popupIngresarSolicitudes.HidePopup();
                CargarMisSolicitudes();
             
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
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "GuardarSolicitud");
               

            }
        }

        private void LimpiarCajasTexto()
        {
            txtObservacionesSolicitud.Text = "";
            dateFechaSolicitud.Text = "";
            glTipoSolicitud.Text = "";
        }


        #endregion

        #region EVENTOS CONTROLES

        private void CmdGuardarSolicitud_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GuardarSolicitud();

            Cursor.Current = Cursors.Arrow;
        }


        #endregion

        private void PicCerrarPopup_Click(object sender, EventArgs e)
        {
            popupIngresarSolicitudes.HidePopup();
        }

        private void PopupIngresarSolicitudes_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            this.ParentForm.BringToFront();
        }

        private void CmdAgregarSolicitud_Click(object sender, EventArgs e)
        {
            popupIngresarSolicitudes.ShowPopup();
            glTipoSolicitud.Focus();
        }
    }
}
