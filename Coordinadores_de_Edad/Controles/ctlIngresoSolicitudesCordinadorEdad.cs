using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlIngresoSolicitudesCordinadorEdad : UserControl
    {
        public ctlIngresoSolicitudesCordinadorEdad()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;

            CargarDatosTipoSolicitud();
            LimpiarCajasTexto();
        }

        private void CargarDatosTipoSolicitud()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            splashScreenManager1.ShowWaitForm();

            string sentencia = @"SELECT * FROM arca_tesoros_conf.ft_view_tipo_solicitud();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
           
            try
            {
                dsConfiguracion1.dtTiposSolicitud.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtTiposSolicitud);

       
                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

                splashScreenManager1.CloseWaitForm();
               
            }
            catch (Exception Exc)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosTipoSolicitud");
                MessageBox.Show(Exc.Message, "Arca de los tesoros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GuardarSolicitud()
        {
            splashScreenManager1.ShowWaitForm();

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

                splashScreenManager1.CloseWaitForm();

                LimpiarCajasTexto();
                MessageBox.Show("¡La solicitud fue enviada al coordinador de día!","Arca de los Tesoros");
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
                MessageBox.Show(Exc.Message, "Arca de los tesoros", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LimpiarCajasTexto()
        {
            txtObservacionesSolicitud.Text = "";
            dateFechaSolicitud.Text = "";
            glTipoSolicitud.Text = "";
        }

        private void CmdGuardarSolicitud_Click(object sender, EventArgs e)
        {
            GuardarSolicitud();
        }

    }
}
