using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coordinadores_de_Edad.DataSet;
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
        public string Pro_Usuario { get; set; }
        public int Pro_ID_Actividad { get; set; }

        #endregion

        #region EVENTOS

        public delegate void GenerarAsistencias(int pID_Colaborador, bool pPresente);
        public event GenerarAsistencias OnMarcarAsistencia;

        #endregion

        public void ConstruirControl(PgSqlConnection pConexion,
                                      string pUsuario,
                                      int pActividad)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_ID_Actividad = pActividad;

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
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosAsistencia");
                MessageBox.Show("Algo salió mal mientras se cargaba lista asistencia.");
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
    }
}
