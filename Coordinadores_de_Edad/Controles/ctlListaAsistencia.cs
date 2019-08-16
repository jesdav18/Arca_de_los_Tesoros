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

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public int Pro_ID_Actividad { get; set; }

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

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_postear_asistencia (:p_id_actividad)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;

            try
            {
                pgComando.ExecuteNonQuery();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosAsistencia");
                MessageBox.Show("Algo salió mal mientras se cargaba lista asistencia.");
            }
        }

        private void MarcarAsistencia(int pID_Colaborador)
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_postear_asistencia (
                                                                                          :p_id_colaborador,
                                                                                          :p_presente,
                                                                                          :p_usando_uniforme,
                                                                                          :p_usando_carnet,
                                                                                          :p_id_actividad,
                                                                                          :p_motivo_inasistencia,
                                                                                          :p_observaciones,
                                                                                          :p_id_medio_cubri_ausencia
                                                                                        )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_presente", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_usando_uniforme", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_usando_carnet", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_motivo_inasistencia", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_observaciones", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_id_medio_cubri_ausencia", PgSqlType.Int).Value = pID_Colaborador;

            try
            {
                pgComando.ExecuteNonQuery();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "MarcarAsistencia");
                MessageBox.Show("Algo salió mal mientras se marcaba asistencia del colaborador en la lista.");
            }

        }

        private void CmdAsistencia_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtListaAsistenciaRow v_fila = (dsCoordinadoresEdad.dtListaAsistenciaRow)gvListaAsistencia.GetFocusedDataRow();
            if (v_fila != null)
            {
                MarcarAsistencia(v_fila.id_colaborador);
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvListaAsistencia.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }
    }
}
