using System;
using System.Data;
using System.Windows.Forms;
using Coordinadores_de_Edad.DataSet;
using Core.Clases;
using Devart.Data.PostgreSql;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlSeleccionMaestros_Ayudas : UserControl
    {

        #region INICIALIZADOR

        public ctlSeleccionMaestros_Ayudas()
        {
            InitializeComponent();
        }

        #endregion

        #region VARIABLES GLOBALES

        bool v_mostrar_encabezado_principal;

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Fecha { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public bool Pro_MostrarEncabezadoPrincipal
        {
            get
            {
                return v_mostrar_encabezado_principal;
            }
            set
            {
                v_mostrar_encabezado_principal = value;
                if (!v_mostrar_encabezado_principal)
                {
                    NavegacionEncabezado.SelectedPage = PageReducido;
                }
                else
                {
                    NavegacionEncabezado.SelectedPage = PageEncabezadoPrincipal;
                    lblEncabezado.Text = "Selección de Maestros para el día " + Pro_Fecha;
                }
            }
        }

        public DateTime Pro_FechaActividad { get; set; }

        #endregion

        #region FUNCIONES


        public void ConstruirControl(PgSqlConnection pConexion, 
                                      string pUsuario, 
                                      string pFecha,
                                      int pID_Actividad,
                                      int pID_AreaAtencion,
                                      bool pMostrarEncabezadoPrincipal = true)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_Fecha = pFecha;
            Pro_ID_AreaAtencion = pID_AreaAtencion;
            Pro_MostrarEncabezadoPrincipal = pMostrarEncabezadoPrincipal;
            Pro_ID_Actividad = pID_Actividad;

            CargarDatosActividad();
            CargarDatos();
            
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_maestros_disponibles(:p_id_area_atencion,
                                                                                         :p_id_actividad)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_AreaAtencion;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            try
            {
                dsCoordinadoresEdad1.dtMaestrosDisponibles.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCoordinadoresEdad1.dtMaestrosDisponibles);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }

        private void CargarDatosActividad()
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
                PgSqlDataReader pgDR = pgComando.ExecuteReader();
                if (pgDR.Read())
                {
                    Pro_FechaActividad = pgDR.GetDateTime("fecha");
                }

                pgDR.Close();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosActividad");
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Algo salió mal mientras se obtenian los datos de la actividad!", Utilidades.BotonesDialogo.Ok);

            }
        }

        private bool GuardarEnListaAsistencia(int pID_Colaborador, bool pSeleccionar)
        {

            bool v_resultado = false;

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_registrar_en_lista_asistencia (
                                                                                                  :p_id_colaborador,
                                                                                                  :p_id_actividad,
                                                                                                  :p_usuario,
                                                                                                  :p_clasificacion,
                                                                                                  :p_seleccionar
                                                                                                )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador",PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_clasificacion", PgSqlType.Int).Value = 1;
            pgComando.Parameters.Add("p_seleccionar", PgSqlType.Boolean).Value = pSeleccionar;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                return v_resultado;

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "GuardarEnListaAsistencia");
                Utilidades.MostrarDialogo(FindForm(), "Falla en el ingreso de datos", Exc.Message, Utilidades.BotonesDialogo.Ok);
                return v_resultado;
            }
          
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnPresionaExtender_Encojer;
        public event EventHandler OnSeleccionaMaestroParaCubrir;

        #endregion

        #region EVENTOS CONTROLES

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvMestrosDisponibles.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

 
        private void PicTituloApilado_Click(object sender, EventArgs e)
        {
            OnPresionaExtender_Encojer?.Invoke(sender, e);
        }

       
        private void ChkSeleccionar_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Utilidades.ObtenerHoraServidor(Pro_Conexion) .Date > Pro_FechaActividad)
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡La fecha de la actividad ya finalizó!", Utilidades.BotonesDialogo.Ok);
                e.Cancel = true;
                return;
            }


            dsCoordinadoresEdad.dtMaestrosDisponiblesRow v_fila = (dsCoordinadoresEdad.dtMaestrosDisponiblesRow)gvMestrosDisponibles.GetFocusedDataRow();
            if (v_fila != null)
            {

                if (v_fila.vino_ultima_actividad)
                {
                    if (Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", v_fila.nombre + " colaboró en la última actividad, realizada en la fecha " + v_fila.fecha_ultima_actividad + ". ¿Desea siempre registrarlo en la lista de asistencia?", Utilidades.BotonesDialogo.YesNo) == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                if (Pro_MostrarEncabezadoPrincipal)
                {
                    if (GuardarEnListaAsistencia(v_fila.id_colaborador, !v_fila.esta_en_lista))
                    {
                       
                        v_fila.esta_en_lista = !v_fila.esta_en_lista;
                        v_fila.AcceptChanges();
                    } 
                }
                else
                {
                    OnSeleccionaMaestroParaCubrir?.Invoke(v_fila.id_colaborador, new EventArgs());
                }
            }
        }

        #endregion


    }
}
