using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlContenedorAsistencias : UserControl
    {

        #region INICIALIZADOR

        public ctlContenedorAsistencias()
        {
            InitializeComponent();
            ctlListaAsistencia1.OnMarcarAsistencia += ctlListaAsistencia1_OnMarcarAsistencia;

            ctlDetallesAsistencia1.OnAsistenciaIngresada += ctlDetallesAsistencia1_OnAsistenciaIngresada;
        }

        #endregion

        #region FUNCIONES

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
                                                     Pro_ID_Actividad,
                                                     Pro_ID_Area_Atencion);
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

            }
        }


        #endregion

        #region EVENTOS CONTROLES

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

        #endregion

        #region PROPIEDADES


        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public int Pro_ID_Area_Atencion { get; set; }
        public int Pro_ID_Actividad { get; set; }



        #endregion

        private void CmdVerHistorico_Click(object sender, EventArgs e)
        {
            
            ctlListaAsistencia1.CmdVerHistorico_Click(sender, e);
            ctlListaAsistencia1.Pro_Conexion = Pro_Conexion;
            ctlListaAsistencia1.Pro_ID_AreaAtencion = Pro_ID_Area_Atencion;
            ctlListaAsistencia1.picAtras.Visible = false;
            NavegacionAsistencias.SelectedPage = PageListaAsistencia;
        }
    }
}
