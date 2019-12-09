using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlMiEquipo : UserControl
    {
        public ctlMiEquipo()
        {
            InitializeComponent();
        }

        private void CmdVerFicha_Click(object sender, EventArgs e)
        {

            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            dsVistas.dtMiEquipoRow v_fila = (dsVistas.dtMiEquipoRow)gvMiEquipo.GetFocusedDataRow();
            if (v_fila != null)
            {
                NavigationMiEquipo.SelectedPage = PageFichaIngreso;
                ctlVistaFichaIngreso1.ConstruirControl(Pro_Conexion, v_fila.id_colaborador);
            }

            if (splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvMiEquipo.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, Usuario pUsuario)
        {
            Pro_Usuario = pUsuario;
            Pro_Conexion = pConexion;
            lblEncabezado.Text = pUsuario.Pro_NombreEquipo;
            NavigationMiEquipo.SelectedPage = PageMiEquipo;


            ctlVistaFichaIngreso1.Pro_Conexion = Pro_Conexion;
            if (!ctlVistaFichaIngreso1.bgCargarDatosConfigurcion.IsBusy)
            {
                ctlVistaFichaIngreso1.bgCargarDatosConfigurcion.RunWorkerAsync();
            }

            LimpiarBusqueda();
            CargarDatos();

        }

        private void LimpiarBusqueda()
        {
            txtBusqueda.Text = "";
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }
            

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_mi_equipo(:p_id_colaborador);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_Usuario.Pro_ID_Colaborador;

            try
            {
                dsVistas1.dtMiEquipo.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtMiEquipo);


                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

              

            }
            catch (Exception Exc)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatos");
                
            }
        }

        
    }
}
