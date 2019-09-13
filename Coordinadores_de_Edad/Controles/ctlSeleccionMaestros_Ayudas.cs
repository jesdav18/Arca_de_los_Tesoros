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
        public ctlSeleccionMaestros_Ayudas()
        {
            InitializeComponent();
        }

        bool v_mostrar_encabezado_principal;

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string  Pro_Fecha { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public bool Pro_MostrarEncabezadoPrincipal{
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

            CargarDatos();
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros.ft_view_maestros_disponibles(:p_id_area_atencion)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_AreaAtencion;

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

        private void GuardarEnListaAsistencia(int pID_Colaborador)
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_registrar_en_lista_asistencia (
                                                                                                  :p_id_colaborador,
                                                                                                  :p_id_actividad,
                                                                                                  :p_usuario,
                                                                                                  :p_clasificacion
                                                                                                )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador",PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_clasificacion", PgSqlType.Int).Value = 1;


            try
            {
                pgComando.ExecuteNonQuery();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, "ctlSeleccionMestros", "GuardarEnListaAsistencia");
                MessageBox.Show("Algo salió mal mientras se registraba al colaborador en la lista.");
            }
          
        }

        public event EventHandler OnPresionaExtender_Encojer;

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvMestrosDisponibles.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

        private void CmdSeleccionar_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtMaestrosDisponiblesRow v_fila = (dsCoordinadoresEdad.dtMaestrosDisponiblesRow) gvMestrosDisponibles.GetFocusedDataRow();
            if (v_fila != null)
            {
                if (Pro_MostrarEncabezadoPrincipal)
                {
                    GuardarEnListaAsistencia(v_fila.id_colaborador);
                }
                else
                {
                    OnSeleccionaMaestroParaCubrir?.Invoke(v_fila.id_colaborador, new EventArgs());
                }          
            }
        }

        public event EventHandler OnSeleccionaMaestroParaCubrir;

        private void PicTituloApilado_Click(object sender, EventArgs e)
        {
            OnPresionaExtender_Encojer?.Invoke(sender, e);
        }
    }
}
