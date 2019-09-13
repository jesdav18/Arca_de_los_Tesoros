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
    public partial class ctlCubrirAusencias : UserControl
    {
        #region INICIALIZADOR

        public ctlCubrirAusencias()
        {
            InitializeComponent();
            ctlSeleccionAyuda1.OnExteder_EncojerControl += ctlSeleccionAyuda1_OnSeleccionAyuda;
            ctlSeleccionAyuda1.OnSeleccionaAyudaParaCubrir += ctlSeleccionAyuda1_OnSeleccionaAyudaParaCubrir;

            ctlSeleccionMaestros_Ayudas1.OnPresionaExtender_Encojer += ctlSeleccionMaestros_Ayudas1_OnSeleccionAyuda;
            ctlSeleccionMaestros_Ayudas1.OnSeleccionaMaestroParaCubrir += ctlSeleccionMaestros_Ayudas1_OnSeleccionaAyuda;
        }

        int v_id_colaborador_cubre_ausencia;



        private void ctlSeleccionMaestros_Ayudas1_OnSeleccionaAyuda(object sender, EventArgs e)
        {
             v_id_colaborador_cubre_ausencia = (int)sender;

            if (v_id_colaborador_cubre_ausencia != 0)
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.AYUDA;
            }
            else
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NINGUNO;
            }
            
            
        }

        private void ctlSeleccionAyuda1_OnSeleccionaAyudaParaCubrir(object sender, EventArgs e)
        {
            v_id_colaborador_cubre_ausencia = (int)sender;

            if (v_id_colaborador_cubre_ausencia != 0)
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.MAESTROS;
        
            }
            else
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NINGUNO;
            }

            
            
        }

        private void ctlSeleccionMaestros_Ayudas1_OnSeleccionAyuda(object sender, EventArgs e)
        {
            Pro_ExtenderMaestros = !Pro_ExtenderMaestros;
        }

        private void ctlSeleccionAyuda1_OnSeleccionAyuda(object sender, EventArgs e)
        {
            Pro_ExtenderAyuda = !Pro_ExtenderAyuda;
        }

        #endregion

        private void GuardarCubrirAusencia()
        {

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_proc_insertar_detalles_cubrir_ausencia (
                                                                                                        :p_id_colaborar_asistencia_actividades,
                                                                                                        :p_id_medio_cubrir_ausencia,
                                                                                                        :p_id_colaborador_cubre_ausencia
                                                                                                      )";
                                                                                        

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborar_asistencia_actividades", PgSqlType.Int).Value = Pro_ID_Colaborar_Actividad;
            pgComando.Parameters.Add("p_id_medio_cubrir_ausencia", PgSqlType.Int).Value = (int)v_tipo_cubrir_ausencia;
            pgComando.Parameters.Add("p_id_colaborador_cubre_ausencia", PgSqlType.Boolean).Value = v_id_colaborador_cubre_ausencia;
            

            try
            {
                pgComando.ExecuteNonQuery();

                
                Utilidades.MostrarDialogo(FindForm(), "Confirmación de Registros", "¡La asistencia se procesó correctamente!", Utilidades.BotonesDialogo.Ok);
                OnCubrirAusenciaIngresada?.Invoke(new object(), new EventArgs());

               
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "MarcarAsistencia");
                MessageBox.Show("Algo salió mal mientras se marcaba asistencia del colaborador en la lista.");
               
            }
        }

        public event EventHandler OnCubrirAusenciaIngresada;

        public enum TIPOS_CUBRIR_AUSENCIA
        {
            NINGUNO = 0,
            AYUDA = 1,
            MAESTROS = 2,
            SERVIDOR_EQUIPO = 3,
            NO_NECESITA_CUBRIR = 4
        }

        TIPOS_CUBRIR_AUSENCIA v_tipo_cubrir_ausencia;
        
        #region PROPIEDADES

        private PgSqlConnection Pro_Conexion { get; set; }
        private int Pro_ID_Colaborador { get; set; }
        private int Pro_AlturaOriginal { get; set; }

        
        private bool Pro_ExtenderAyuda {
            get
            {
                return v_extender_ayuda;
            }
            set
            {
                v_extender_ayuda = value;
                if (value)
                {
                    ctlSeleccionAyuda1.Height = 425;
                }
                else
                {
                    ctlSeleccionAyuda1.Height = 85;
                }

            }
        }
        private bool Pro_ExtenderMaestros {
            get
            {
                return v_extender_maestros;
            }
            set
            {
                v_extender_maestros = value;
                if (value)
                {
                    ctlSeleccionMaestros_Ayudas1.Height = 425;
                }
                else
                {
                    ctlSeleccionMaestros_Ayudas1.Height = 85;
                }
            }
        }

        public bool Pro_SeleccionaServidorEquipo {
            get
            {
                return v_selecciona_servidor;
            }
            set
            {
                v_selecciona_servidor = value;
                if (value)
                {
                    v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.SERVIDOR_EQUIPO;
                    picReemplazarConServidorEquipo.Image = Resources.iconCheck;
                }
                else
                {
                    picReemplazarConServidorEquipo.Image = Resources.iconUncheck_32;
                    v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NINGUNO;
                }
            }
        }
        public bool Pro_SeleccionaNoNecesitaCubrir {
            get
            {
                return v_seleccion_no_necesita_cubrir;
            }
            set
            {
                v_seleccion_no_necesita_cubrir = value;
                if (value)
                {
                    v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NO_NECESITA_CUBRIR;
                    picReemplazarConServidorEquipo.Image = Resources.iconCheck;
                }
                else
                {
                    picReemplazarConServidorEquipo.Image = Resources.iconUncheck_32;
                    v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NINGUNO;
                }
            }
        }

        public int Pro_ID_Colaborar_Actividad { get; set; }

        #endregion

        bool v_selecciona_servidor;
        bool v_seleccion_no_necesita_cubrir;
        bool v_extender_ayuda;
        bool v_extender_maestros;

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador, int pID_Colaborador_Actividad = 0)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_ID_Colaborar_Actividad = pID_Colaborador_Actividad;

            Pro_ExtenderAyuda = false;
            Pro_ExtenderMaestros = false;
            Pro_SeleccionaNoNecesitaCubrir = false;
            Pro_SeleccionaServidorEquipo = false;

        }


        #endregion

       
        private void PicReemplazarConServidorEquipo_Click(object sender, EventArgs e)
        {
            Pro_SeleccionaServidorEquipo = !Pro_SeleccionaServidorEquipo;
        }

        private void PicNoEsNecsarioCubrirAusencia_Click(object sender, EventArgs e)
        {
            Pro_SeleccionaNoNecesitaCubrir = !Pro_SeleccionaNoNecesitaCubrir;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            GuardarCubrirAusencia();
        }
    }
}
