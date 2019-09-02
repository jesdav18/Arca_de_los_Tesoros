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
    public partial class ctlContenedorAsistencias : UserControl
    {
        public ctlContenedorAsistencias()
        {
            InitializeComponent();
            ctlListaAsistencia1.OnMarcarAsistencia += ctlListaAsistencia1_OnMarcarAsistencia;

            ctlDetallesAsistencia1.OnAsistenciaIngresada += ctlDetallesAsistencia1_OnAsistenciaIngresada;
        }

        private void ctlDetallesAsistencia1_OnAsistenciaIngresada(object sender, EventArgs e)
        {
            NavegacionAsistencias.SelectedPage = PageListaAsistencia;

        }

        private void ctlListaAsistencia1_OnMarcarAsistencia(int pID_Colaborador, bool pPresente)
        {
          
            NavegacionAsistencias.SelectedPage = PageDetalleAsistencia;
            ctlDetallesAsistencia1.ConstruirControl(Pro_Conexion, 
                                                    pID_Colaborador,
                                                    Pro_ID_Actividad,
                                                    pPresente);
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public int Pro_ID_Area_Atencion { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public void ConstruirControl(PgSqlConnection pConexion,
                                     string pUsuario,
                                     int pID_Area_Atencion)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_ID_Area_Atencion = pID_Area_Atencion;

            ObtenerActividad();

            if (Pro_ID_Actividad == 0)
            {
                NavegacionAsistencias.SelectedPage = PageMensaje;
            }
            else
            {
                NavegacionAsistencias.SelectedPage = PageListaAsistencia;
                ctlListaAsistencia1.ConstruirControl(Pro_Conexion, 
                                                     Pro_Usuario,
                                                     Pro_ID_Actividad);
            }
        }

        private void ObtenerActividad()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_proc_obtener_actividad_del_dia (:p_id_area_atencion)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_Area_Atencion;
            
            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    Pro_ID_Actividad = pgDr.GetInt32("id_actividad");
                }
                pgDr.Close();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ObtenerActividad");
                MessageBox.Show("Algo salió mal mientras se obtenía información de la actividad.");
            }

        }
    }
}
