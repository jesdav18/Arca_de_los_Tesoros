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
using Coordinadores_de_Dia.DataSet;

namespace Coordinadores_de_Dia.Controles
{
    public partial class ctlVistaSolicitudes : UserControl
    {
        public ctlVistaSolicitudes()
        {
            InitializeComponent();
        }

        enum ESTADOS_SOLICITUD
        {
            EN_ESPERA = 1,
            EN_PROCESO = 2,
            APROBADA = 3,
            RECHAZADA = 4
        }


        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion,string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            try
            {
                string sentencia = "SELECT * FROM arca_tesoros.ft_view_solicitudes();";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

                try
                {
                    dsCoordinador_Dia1.dtSolicitudes.Clear();
                    new PgSqlDataAdapter(pgComando).Fill(dsCoordinador_Dia1.dtSolicitudes);

                }
                catch (Exception Exc)
                {
                }
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosAsistencia");
                MessageBox.Show("Algo salió mal mientras se cargaba lista asistencia.");
            }
        }

        private void RegistrarEstadoSolicitud(int p_id_colaborador_solicitud,ESTADOS_SOLICITUD p_estado_solicitud)
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM  arca_tesoros.ft_mant_respuesta_solicitud (
                                                                                          :p_id_colaborador_solicitud,
                                                                                          :p_usuario,
                                                                                          :p_estado,
                                                                                          :p_observaciones_rechazo
                                                                                        )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador_solicitud", PgSqlType.Int).Value = p_id_colaborador_solicitud;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_estado", PgSqlType.Int).Value = (int) p_estado_solicitud;
            pgComando.Parameters.Add("p_observaciones_rechazo",PgSqlType.VarChar).Value = memoMotivosRechazo.Text;

            try
            {
                pgComando.ExecuteNonQuery();
                MessageBox.Show("Solicitud Aprobada");
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal mientras se registraba el estado de la solicitud.");
            }

        }
       
        private void CmdRechazar_Click(object sender, EventArgs e)
        {
            popupIngresoMotivoRechazo.ShowPopup();

        }

        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            var v_fila = (dsCoordinador_Dia.dtSolicitudesRow)gvVistaSolicitud.GetFocusedDataRow();
            if (v_fila != null)
            {
                RegistrarEstadoSolicitud(v_fila.id_colaborador_solicitud, ESTADOS_SOLICITUD.APROBADA);
            }
        }

        private void CmdGuardarRechazo_Click(object sender, EventArgs e)
        {
            var v_fila = (dsCoordinador_Dia.dtSolicitudesRow)gvVistaSolicitud.GetFocusedDataRow();
            if (v_fila != null)
            {

                if (!string.IsNullOrEmpty(memoMotivosRechazo.Text))
                {
                    RegistrarEstadoSolicitud(v_fila.id_colaborador_solicitud, ESTADOS_SOLICITUD.RECHAZADA);
                    popupIngresoMotivoRechazo.HidePopup();
                    this.Parent.BringToFront();
                }
                else
                {
                    MessageBox.Show("Necesita ingresar el motivo por el cual rechaza la solicitud");
                }       
            }
        }

        private void CmdCerrarPoupRechazo_Click(object sender, EventArgs e)
        {

            popupIngresoMotivoRechazo.HidePopup();
            this.Parent.BringToFront();
        }
    }
}
