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
        public bool Pro_MostrarEncabezado {
            get
            {
                return v_mostrar_encabezado;
            }
            set
            {
                v_mostrar_encabezado = value;
                if (!v_mostrar_encabezado)
                {
                    pnlEncabezado.Visible = false;
                    panel2.Visible = false;
                }
                else
                {
                    lblEncabezado.Text = "Selección de Ayudas para el día " + Pro_Fecha;
                }
            }
        }


        bool v_mostrar_encabezado;
      


        public void ConstruirControl(PgSqlConnection pConexion,
                                   string pUsuario,
                                   string pFecha,
                                   int pID_AreaAtencion,
                                   bool pMostrarEncabezado = true)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_Fecha = pFecha;
            Pro_ID_AreaAtencion = pID_AreaAtencion;
            Pro_MostrarEncabezado = pMostrarEncabezado;

           
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



       

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvMestrosDisponibles.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }
    }
}
