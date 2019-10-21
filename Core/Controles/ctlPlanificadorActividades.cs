using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using Core.DataSets;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Core.Controles
{
    public partial class ctlPlanificadorActividades : UserControl
    {

        #region INICIALIZADOR

        public ctlPlanificadorActividades()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public DateTime ProFechaSeleccionada  { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            CargarDatosCitasActividades();
            LimpiarCajasTexto();
        }

        private void LimpiarCajasTexto()
        {
            txtAsunto.Text = "";
            txtLugar.Text = "";
            memoObservaciones.Text = "";
            glColorEtiqueta.Text = "";
            /*timeHoraFin.Text = "00:00:00";
            timeHoraInicio.Text = "00:00:00";*/
        }

        private void InsertarCita()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_insertar_cita_actividad (
                                                                                              :p_asunto,
                                                                                              :p_lugar,
                                                                                              :p_fecha,
                                                                                              :p_hora_inicio,
                                                                                              :p_hora_fin,
                                                                                              :p_color_etiqueta,
                                                                                              :p_observaciones,
                                                                                              :p_usuario
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_asunto", PgSqlType.VarChar).Value = txtAsunto.Text;
            pgComando.Parameters.Add("p_lugar", PgSqlType.VarChar).Value = txtLugar.Text;
            pgComando.Parameters.Add("p_fecha", PgSqlType.Date).Value = ProFechaSeleccionada;
            pgComando.Parameters.Add("p_hora_inicio", PgSqlType.TimeStamp).Value = dateFechaInicio.EditValue;
            pgComando.Parameters.Add("p_hora_fin", PgSqlType.TimeStamp).Value = dateFechaFin.EditValue;
            pgComando.Parameters.Add("p_color_etiqueta", PgSqlType.Int).Value = 1;//glColorEtiqueta.EditValue;
            pgComando.Parameters.Add("p_observaciones", PgSqlType.VarChar).Value = memoObservaciones.Text;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;

            
            try
            {
                pgComando.ExecuteNonQuery();
              

                sentencia = null;
                pgComando.Dispose();
     
                LimpiarCajasTexto();
                CargarDatosCitasActividades();
                NavegacionPrincipal.SelectedPage = pageCalendario;

            }
            catch (Exception Exc)
            {
               
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "InsertarCita");
                MessageBox.Show(Exc.Message, "Arca de los tesoros", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarDatosCitasActividades()
        {
            if(Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_citas_actividades (:p_usuario);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;

            try
            {
                dsVistas1.dtCita_Actividad.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtCita_Actividad);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosCitasActividades");
              
            }
        }

        private void RecargarCitas()
        {
            schedulerControl1.DataStorage.RefreshData(); ;
            foreach (dsVistas.dtCita_ActividadRow iterador in dsVistas1.dtCita_Actividad)
            {
                Appointment apt = schedulerControl1.DataStorage.CreateAppointment(AppointmentType.Normal);
                apt.Start = iterador.hora_inicio;
                apt.End = iterador.hora_fin;
                apt.Subject = iterador.asunto;
                apt.Location = iterador.lugar;
                apt.Description = "Se me olvidó";
                apt.LabelKey = iterador.id_color_etiqueta;

                schedulerControl1.DataStorage.Appointments.Add(apt);
            }
        }

        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {


            RecargarCitas();
        }

        private void SchedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            e.Handled = true;
        }

        private void SchedulerControl1_DoubleClick(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageIngresoCita;
            lblSubtitulo.Text = "Crear cita para el día " + schedulerControl1.ActiveView.SelectedInterval.Start.ToString();
            ProFechaSeleccionada = schedulerControl1.ActiveView.SelectedInterval.Start;
            dateFechaFin.EditValue = dateFechaInicio.EditValue = ProFechaSeleccionada;
        }

        private void PicIrAtras_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = pageCalendario;
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {

        }

        private void PicGuardar_Click(object sender, EventArgs e)
        {
            InsertarCita();
        }
    }
}
