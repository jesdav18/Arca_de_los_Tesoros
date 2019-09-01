using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlDetallesAsistencia : UserControl
    {
        #region INICIALIZADOR

        public ctlDetallesAsistencia()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }
        public int Pro_ID_Actividad { get; set; }

        public bool Pro_Carnet {
            get
            {
                return v_carnet;
            }
            set
            {
                v_carnet = value;
                if (v_carnet)
                {
                    toggleCarnet.Image = Resources.iconToggleSi;
                }
                else
                {
                    toggleCarnet.Image = Resources.iconToggleNo;
                }
            }
        }

        public bool Pro_Uniforme {
            get
            {
                return v_uniforme;
            }
            set
            {
                v_uniforme = value;

                if (v_uniforme)
                {
                    toggleCarnet.Image = Resources.iconToggleSi;
                }
                else
                {
                    toggleCarnet.Image = Resources.iconToggleNo;
                }             
            }
        }

        public bool Pro_Presente {
            get
            {
                return v_presente;
            }
            set
            {
                v_presente = value;
                if (v_presente)
                {
                    picCaratulaAsistencia.Image = Resources.happy;
                    NavegacionObservaciones.SelectedPage = page;
                }
                else
                {
                    picCaratulaAsistencia.Image = Resources.frown;
                    NavegacionObservaciones.SelectedPage = pageInasistencias;
                }
            }
        }


        #endregion

        #region VARIABLES GLOBALES

        private bool v_motivo_inasistencia;
        private bool v_carnet;
        private bool v_uniforme;
        private bool v_presente;
        private string v_ruta_fotografia;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                    int pID_Colaborador,
                                    int pID_Actividad,
                                    bool pPresente)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_ID_Actividad = pID_Actividad;
            Pro_Presente = pPresente;

            CargarDatosColaborador();
            CargarFotografiaColaborador();
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
                                                                                          :p_observaciones                                                                                        
                                                                                        )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_presente", PgSqlType.Boolean).Value = Pro_Presente;
            pgComando.Parameters.Add("p_usando_uniforme", PgSqlType.Boolean).Value = Pro_Uniforme;
            pgComando.Parameters.Add("p_usando_carnet", PgSqlType.Boolean).Value = Pro_Carnet;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            pgComando.Parameters.Add("p_motivo_inasistencia", PgSqlType.VarChar).Value = v_motivo_inasistencia;
            pgComando.Parameters.Add("p_observaciones", PgSqlType.VarChar).Value = memoObservacionesInasistencia.Text;
         
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

        private void CargarDatosColaborador()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_ficha_ingreso (p_id_colaborador)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    txtNombreColaborador.Text = pgDr.GetString("nombre_colaborador");
                    txtIdentidadColaborador.Text = pgDr.GetString("numero_identidad");
                    txtFuerzasEspeciales.Text = pgDr.GetString("area_atencion");
                    v_ruta_fotografia = pgDr.GetString("direccion_fotografia");
                }

                pgDr.Close();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosColaborador");
                MessageBox.Show("Algo salió mal mientras se cargaba detalles de asistencia.");
            }
        }

        private void CargarFotografiaColaborador()
        {
            if (!string.IsNullOrEmpty(v_ruta_fotografia))
            {
                picFotoColaborador.Image = Image.FromFile(v_ruta_fotografia);
            }
        }

        #endregion

        private void CmdGuardarAsistencia_Click(object sender, EventArgs e)
        {
            MarcarAsistencia(Pro_ID_Colaborador);
        }

        private void ToggleUniforme_Click(object sender, EventArgs e)
        {
            Pro_Uniforme = !Pro_Uniforme;
        }

        private void ToggleCarnet_Click(object sender, EventArgs e)
        {
            Pro_Carnet = !Pro_Carnet;
        }

        private void CmdSeleccionarCubrirAusencia_Click(object sender, EventArgs e)
        {
            MarcarAsistencia(Pro_ID_Colaborador);
            NavigationPrincipal.SelectedPage = PageCubrirAusencia;
            ctlCubrirAusencias1.ConstruirControl(Pro_Conexion, Pro_ID_Colaborador);

        }
    }
}
