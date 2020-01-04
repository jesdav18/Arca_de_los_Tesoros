using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using Core.DataSets;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Drawing;

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



            schedulerControl1.GoToDate(Utilidades.ObtenerHoraServidor(Pro_Conexion));


            CargarDatosCitasActividades();
            CargarColores();
            LimpiarCajasTexto();
        }

        private void LimpiarCajasTexto()
        {
            txtAsunto.Text = "";
            txtLugar.Text = "";
            memoObservaciones.Text = "";
            glColorEtiqueta.Text = "";
           
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
            pgComando.Parameters.Add("p_hora_inicio", PgSqlType.TimeStamp).Value = timeHoraInicio.EditValue;
            pgComando.Parameters.Add("p_hora_fin", PgSqlType.TimeStamp).Value = timeHoraFin.EditValue;
            pgComando.Parameters.Add("p_color_etiqueta", PgSqlType.Int).Value = glColorEtiqueta.EditValue != null ? glColorEtiqueta.EditValue : 1;
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


                RecargarCitas();

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosCitasActividades");
              
            }
        }

        private void CargarDatosCitasActividadesPorFecha()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_citas_actividades_por_fecha (
                                                                                                  :p_fecha
                                                                                                )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_fecha", PgSqlType.Date).Value = ProFechaSeleccionada;

            try
            {
                dsVistas1.dtCita_Actividad.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtCita_Actividad);


                RecargarCitas();

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosCitasActividades");

            }
        }


        private void EliminarCita(int pID_CitaActividad)
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_eliminar_cita (
                                                                                      :p_id_cita_actividad
                                                                                    )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cita_actividad", PgSqlType.Int).Value = pID_CitaActividad;

            try
            {
                pgComando.ExecuteNonQuery();
                CargarDatosCitasActividadesPorFecha();

            }
            catch (Exception Exc)
            {

                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosCitasActividadesPorFecha");
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Algo salió mal en el momento de eliminar esta cita, por favor intente nuevamente!", Utilidades.BotonesDialogo.Ok);
                return;
            }
        }

        private void CargarColores()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros_conf.ft_view_colores_citas ();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
       

            try
            {
                dsVistas1.dtColores.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtColores);


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
            schedulerControl1.DataStorage.Appointments.Clear();
            foreach (dsVistas.dtCita_ActividadRow iterador in dsVistas1.dtCita_Actividad)
            {
                Appointment apt = schedulerControl1.DataStorage.CreateAppointment(AppointmentType.Normal);
                apt.Start = iterador.hora_inicio;
                apt.End = iterador.hora_fin;
                apt.Subject = iterador.asunto;
                apt.Location = iterador.lugar;
                apt.Description = iterador.observaciones;
                apt.LabelKey = iterador.id_color_etiqueta;

                schedulerControl1.DataStorage.Appointments.Add(apt);
            }
        }

        private void DescartarCita()
        {
            txtAsunto.ResetText();
            txtLugar.ResetText();
            memoObservaciones.ResetText();

        }

        #endregion

        #region EVENTOS CONTROLES

        private void SchedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            e.Handled = true;
        }

        private void SchedulerControl1_DoubleClick(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageVistaCitas;


            lblSubtitulo.Text = "Crear cita para el día " + schedulerControl1.ActiveView.SelectedInterval.Start.Date.ToShortDateString();
            ltlTituloCitas.Text = "Citas Programadas para el día " + schedulerControl1.ActiveView.SelectedInterval.Start.Date.ToShortDateString();
            ProFechaSeleccionada = schedulerControl1.ActiveView.SelectedInterval.Start;
            timeHoraInicio.Time = timeHoraFin.Time = ProFechaSeleccionada;

            CargarDatosCitasActividadesPorFecha();


        }

        private void PicIrAtras_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageVistaCitas;
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {
            DescartarCita();
        }

        private void PicGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAsunto.Text))
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Es necesario que ingrese un Asunto!", Utilidades.BotonesDialogo.Ok);
                return;
            }
            else if (string.IsNullOrEmpty(txtLugar.Text))
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Es necesario que ingrese un Lugar!", Utilidades.BotonesDialogo.Ok);
                return;
            }
            else if (string.IsNullOrEmpty(memoObservaciones.Text))
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Es necesario que ingrese una Observación!", Utilidades.BotonesDialogo.Ok);
                return;
            }


            InsertarCita();
        }

        private void GvColor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "boton_color")
            {

                var v_fila = (dsVistas.dtColoresRow)gvColor.GetDataRow(e.RowHandle);


                e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml(v_fila.argb);

            }
        }

        private void GlColorEtiqueta_EditValueChanged(object sender, EventArgs e)
        {
            var v_fila = (dsVistas.dtColoresRow)gvColor.GetFocusedDataRow();
            if (v_fila != null)
            {
                glColorEtiqueta.BackColor = System.Drawing.ColorTranslator.FromHtml(v_fila.argb);
            }
        }

        #endregion

        private void CmdAgregarCita_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageIngresoCita;
        }

        private void CmdIrAtrasCitas_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = pageCalendario;
            CargarDatosCitasActividades();
            RecargarCitas();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvActivdades.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            var v_fila = (dsVistas.dtCita_ActividadRow)gvActivdades.GetFocusedDataRow();

            if (v_fila != null)
            {
                EliminarCita(v_fila.id_cita_actividad);
            }

           
        }
    }
}
