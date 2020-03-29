using System;
using System.Data;
using System.Windows.Forms;
using Core.DataSet;
using Core.Clases;
using Devart.Data.PostgreSql;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlListaAsistencia : UserControl
    {
        public ctlListaAsistencia()
        {
            InitializeComponent();
            
        }

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }

        #endregion

        #region EVENTOS

        public delegate void GenerarAsistencias(int pID_Colaborador, bool pPresente);
        public event GenerarAsistencias OnMarcarAsistencia;

        #endregion

        public void ConstruirControl(PgSqlConnection pConexion,
                                      Usuario pUsuario,
                                      int pActividad,
                                      int pID_AreaAtencion)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_ID_Actividad = pActividad;
            Pro_ID_AreaAtencion = pID_AreaAtencion;


            dateFechaAsistencia.EditValue = Utilidades.ObtenerFechaServidor(Pro_Conexion);

            ObtenerInformacionActividad();
            CargarDatosAsistencia();
        }

        private void CargarDatosAsistencia()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_lista_asistencia ( :p_id_actividad )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;

            try
            {
                dsCoordinadoresEdad1.dtListaAsistencia.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCoordinadoresEdad1.dtListaAsistencia);

                CargarImagenesEstadoAsistencia();
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosAsistencia");
                
            }
        }

        private void CargarDatosAsistenciaHistoricos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_lista_asistencia_historico (:p_fecha,
                                                                                                :p_id_area_atencion)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_fecha", PgSqlType.Date).Value = dateFechaAsistencia.EditValue;
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_AreaAtencion;



            try
            {
                dsCoordinadoresEdad1.dtListaAsistenciaHistorico.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCoordinadoresEdad1.dtListaAsistenciaHistorico);

                if (dsCoordinadoresEdad1.dtListaAsistenciaHistorico.Count == 0)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡No se encontraron registros para esta fecha!", Utilidades.BotonesDialogo.Ok);
                }



                CargarImagenesEstadoAsistencia();
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosAsistencia");
      
            }
        }

        private void CargarImagenesEstadoAsistencia()
        {
            foreach (dsCoordinadoresEdad.dtListaAsistenciaRow iterador in dsCoordinadoresEdad1.dtListaAsistencia)
            {
                if (iterador.IsasistioNull())
                {
                    iterador.asistencia = null;
                    iterador.inasistencia = null;
                }
                else if (iterador.asistio)
                {
                    iterador.asistencia = Resources.iconCheckVerde_24;
                    iterador.inasistencia = null;
                }
                else if (!iterador.asistio)
                {
                    iterador.asistencia = null;
                    iterador.inasistencia = Resources.iconMaloRojo_24;
                }
            }
        }

        private void ObtenerInformacionActividad()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_datos_actividades (
                                                                                       :p_id_actividad
                                                                                    )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    lblEncabezado.Text = "Lista de Asistencia para el día " + pgDr.GetDateTime("fecha").Date.ToShortDateString();
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ObtenerInformacionActividad");
               
            }
        }
      
        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvListaAsistencia.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

        private void CmdAsistio_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtListaAsistenciaRow v_fila = (dsCoordinadoresEdad.dtListaAsistenciaRow)gvListaAsistencia.GetFocusedDataRow();
            if (v_fila != null)
            {
                OnMarcarAsistencia?.Invoke(v_fila.id_colaborador, true);
            }
        }

        private void CmdNoAsistio_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtListaAsistenciaRow v_fila = (dsCoordinadoresEdad.dtListaAsistenciaRow)gvListaAsistencia.GetFocusedDataRow();
            if (v_fila != null)
            {
                OnMarcarAsistencia?.Invoke(v_fila.id_colaborador, false);
            }
        }

        private void PicNoAsistio_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtListaAsistenciaRow v_fila = (dsCoordinadoresEdad.dtListaAsistenciaRow)gvListaAsistencia.GetFocusedDataRow();
            if (v_fila != null)
            {
                OnMarcarAsistencia?.Invoke(v_fila.id_colaborador, false);
            }
        }

        private void PicAsistio_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtListaAsistenciaRow v_fila = (dsCoordinadoresEdad.dtListaAsistenciaRow)gvListaAsistencia.GetFocusedDataRow();
            if (v_fila != null)
            {
                OnMarcarAsistencia?.Invoke(v_fila.id_colaborador, true);
            }
        }

        public void CmdVerHistorico_Click(object sender, EventArgs e)
        {
            lblEncabezado.Text = "Buscar listado de asistencias";
            navigationFrame1.SelectedPage = pageHistoricoAsistencia;
            cmdVerHistorico.Visible = false;
            picAtras.Visible = true;
        }

        private void PicAtras_Click(object sender, EventArgs e)
        {
            ObtenerInformacionActividad();
            navigationFrame1.SelectedPage = PageListaAsistencia;
            cmdVerHistorico.Visible = true;
            picAtras.Visible = false;
        }

        private void PicCargar_Click(object sender, EventArgs e)
        {
            CargarDatosAsistenciaHistoricos();
        }
    }
}
