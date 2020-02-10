using System;
using System.Data;
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
         

            ctlSeleccionMaestros_Ayudas1.OnPresionaExtender_Encojer += ctlSeleccionMaestros_Ayudas1_OnSeleccionAyuda;
            ctlSeleccionMaestros_Ayudas1.OnSeleccionaMaestroParaCubrir += ctlSeleccionMaestros_Ayudas1_OnSeleccionaAyuda;
        }

        int v_id_colaborador_cubre_ausencia;



        private void ctlSeleccionMaestros_Ayudas1_OnSeleccionaAyuda(object sender, EventArgs e)
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


        #endregion

        #region EVENTOS

        public event EventHandler OnCubrirAusenciaIngresada;
        public event EventHandler OnIrAtras;

        #endregion

        #region ENUMERACIONES

        public enum TIPOS_CUBRIR_AUSENCIA
        {
            NINGUNO = 0,
            AYUDA = 1,
            MAESTROS = 2,
            SERVIDOR_EQUIPO = 3,
            NO_NECESITA_CUBRIR = 4
        }

        #endregion
     
        #region PROPIEDADES

        private PgSqlConnection Pro_Conexion { get; set; }
        private int Pro_ID_Colaborador { get; set; }
        private int Pro_AlturaOriginal { get; set; }
        public Usuario Pro_Usuario { get; set; }
        public int Pro_ID_Actividad { get; set; }

       
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
                    ctlSeleccionMaestros_Ayudas1.Height = 50;
                }
            }
        }

        public bool Pro_NoNecesitaCubrir {
            get
            {
                return v_no_necesita_cubrir;
            }
            set
            {
                v_no_necesita_cubrir = value;
                if (v_no_necesita_cubrir)
                {
                    picNoEsNecesarioCubrir.Image = Coordinadores_de_Edad.Resources.iconCheckVerde_24;
                }
                else
                {
                    picNoEsNecesarioCubrir.Image = Coordinadores_de_Edad.Resources.iconUncheck_32;
                }
            }
        }
        public bool Pro_CubrirConServidor {
            get
            {
                return v_cubrir_con_servidor;
            }
            set
            {
                v_cubrir_con_servidor = value;
                if (v_cubrir_con_servidor)
                {
                    picReemplazar.Image = Coordinadores_de_Edad.Resources.iconCheckVerde_24;
                }
                else
                {
                    picReemplazar.Image = Coordinadores_de_Edad.Resources.iconUncheck_32;
                }
            }
        }



        public int Pro_ID_Colaborar_Actividad { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }

        #endregion

        #region VARIABLES GLOBALES

        TIPOS_CUBRIR_AUSENCIA v_tipo_cubrir_ausencia;
        bool v_no_necesita_cubrir;
        bool v_cubrir_con_servidor;
        bool v_extender_ayuda;
        bool v_extender_maestros;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_Colaborador,
                                     Usuario pUsuario,
                                     int pID_Actividad,
                                     int pID_AreaAtencion,
                                     int pID_Colaborador_Actividad = 0)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_ID_Colaborar_Actividad = pID_Colaborador_Actividad;
            Pro_Usuario = pUsuario;
            Pro_ID_Actividad = pID_Actividad;
            Pro_ID_AreaAtencion = pID_AreaAtencion;

           
            Pro_ExtenderMaestros = false;
            Pro_NoNecesitaCubrir = false;
            Pro_CubrirConServidor = false;

            ctlSeleccionMaestros_Ayudas1.ConstruirControl(Pro_Conexion,
                                                         Pro_Usuario.Pro_Usuario,
                                                         DateTime.Now.ToString(),
                                                         Pro_ID_Actividad,
                                                         Pro_ID_AreaAtencion,
                                                         false);


        }

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

        #endregion

        #region EVENTOS CONTROLES

        private void PicNoEsNecesarioCubrir_Click(object sender, EventArgs e)
        {
            Pro_NoNecesitaCubrir = !Pro_NoNecesitaCubrir;
            if (Pro_NoNecesitaCubrir)
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NO_NECESITA_CUBRIR;
            }
            else {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NINGUNO;
            }


            if (Pro_CubrirConServidor)
            {
                
                Pro_CubrirConServidor = false;
            }
        }

        private void PicReemplazar_Click(object sender, EventArgs e)
        {
            Pro_CubrirConServidor = !Pro_CubrirConServidor;
            if (Pro_CubrirConServidor)
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.SERVIDOR_EQUIPO;
            }
            else
            {
                v_tipo_cubrir_ausencia = TIPOS_CUBRIR_AUSENCIA.NINGUNO;
            }

            if (Pro_NoNecesitaCubrir)
            {
                Pro_NoNecesitaCubrir = false;
            }
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (v_tipo_cubrir_ausencia != TIPOS_CUBRIR_AUSENCIA.NINGUNO)
            {
                GuardarCubrirAusencia();
            }
            else
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "Es necesario que seleccione algún medio para cubrir la ausencia, puede buscar entre las ayudas, los maestros, marcar ausencia con servidor de otro equipo o marcar que no necesita cubrir.",Utilidades.BotonesDialogo.Ok);
            }
            
        }


        private void PicAtras_Click(object sender, EventArgs e)
        {
            OnIrAtras?.Invoke(sender, e);   
        }

        #endregion

    }

}
