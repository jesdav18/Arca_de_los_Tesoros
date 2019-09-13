using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using Coordinadores_de_Edad.DataSet;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlSeleccionAyuda : UserControl
    {
        public ctlSeleccionAyuda()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Fecha { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public bool Pro_MostrarEncabezadoOriginal {
            get
            {
                return v_mostrar_encabezado_original;
            }
            set
            {
                v_mostrar_encabezado_original = value;
                if (!v_mostrar_encabezado_original)
                {
                    NavigationEncabezado.SelectedPage = PageEncabezadoApilado;

                }
                else
                {
                    NavigationEncabezado.SelectedPage = PageEncabezadoOriginal;
                    lblEncabezado.Text = "Selección de Ayudas para el día " + Pro_Fecha;
                }
            }
        }


        bool v_mostrar_encabezado_original;

        public event EventHandler OnExteder_EncojerControl;
      


        public void ConstruirControl(PgSqlConnection pConexion,
                                   string pUsuario,
                                   string pFecha,
                                   int pID_Actividad,
                                   int pID_AreaAtencion,
                                   bool pMostrarEncabezadoOriginal = true)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_Fecha = pFecha;
            Pro_ID_AreaAtencion = pID_AreaAtencion;
            Pro_MostrarEncabezadoOriginal = pMostrarEncabezadoOriginal;
            Pro_ID_Actividad = pID_Actividad;

           
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros.ft_view_colaboradores_ayudas_disponibles(:p_id_area_atencion)";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_AreaAtencion;

            try
            {
                dsCoordinadoresEdad1.dtAyudasDisponibles.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsCoordinadoresEdad1.dtAyudasDisponibles);

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
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pID_Colaborador;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_clasificacion", PgSqlType.Int).Value = 2;


            try
            {
                pgComando.ExecuteNonQuery();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "GuardarEnListaAsistencia");
                MessageBox.Show("Algo salió mal mientras se registraba al colaborador en la lista.");
            }

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvMestrosDisponibles.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

        private void CmdGuardarEnListaAsistencia_Click(object sender, EventArgs e)
        {
            dsCoordinadoresEdad.dtAyudasDisponiblesRow v_fila = (dsCoordinadoresEdad.dtAyudasDisponiblesRow)gvMestrosDisponibles.GetFocusedDataRow();
            if (v_fila != null)
            {
                if (Pro_MostrarEncabezadoOriginal)
                {
                    GuardarEnListaAsistencia(v_fila.id_colaborador);
                }
                else
                {
                    OnSeleccionaAyudaParaCubrir?.Invoke(v_fila.id_colaborador, new EventArgs());
                }

            }
        }

        public event EventHandler OnSeleccionaAyudaParaCubrir;

        private void PicTituloApilado_Click(object sender, EventArgs e)
        {
            OnExteder_EncojerControl?.Invoke(sender, e);
        }
    }
}
