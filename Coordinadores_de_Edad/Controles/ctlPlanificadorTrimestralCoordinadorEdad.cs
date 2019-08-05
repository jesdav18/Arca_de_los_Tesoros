using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;


namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlPlanificadorTrimestralCoordinadorEdad : UserControl
    {
        public ctlPlanificadorTrimestralCoordinadorEdad()
        {
            InitializeComponent();
            ctlDiasTrimestre1.OnIrAtras += ctlDiasTrimestre1_OnIrAtras;
            ctlDiasTrimestre1.OnSeleccionaDia += ctlDiasTrimestre1_OnSeleccionaDia;
            ctlSeleccionMaestros_Ayudas1.OnIrAtras += ctlSeleccionMaestros_Ayudas1_OnIrAtras;
        }

        private void ctlDiasTrimestre1_OnSeleccionaDia(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageSeleccionMaestros;
            ctlSeleccionMaestros_Ayudas1.ConstruirControl(Pro_Conexion, 
                                                          Pro_Usuario, 
                                                          (string)sender,
                                                          Pro_ID_AreaAtencion);           
        }

        private void ctlSeleccionMaestros_Ayudas1_OnIrAtras(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageDias;
            
        }

        private void ctlDiasTrimestre1_OnIrAtras(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = PageTrimestres;
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Anio { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion,
                                     string pUsuario,
                                     int pID_AreaAtencion)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_ID_AreaAtencion = pID_AreaAtencion;
            Pro_Anio = Utilidades.ObtenerAnioServidor(Pro_Conexion);
            lblEncabezado.Text = "Planificador Trimestral Año " + Pro_Anio;
         
            NavigationPrincipal.SelectedPage = PageTrimestres;
           

        }

        private void CmdPrimerTrimestre_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion, 
                                               Pro_Usuario, 
                                               Pro_Anio, 
                                               "Primer Trimestre", 
                                               1);
        }

        private void CmdSegundoTrimestre_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion,
                                               Pro_Usuario,
                                               Pro_Anio,
                                               "Segundo Trimestre",
                                               2);
        }

        private void CmdTercerTrimestre_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion,
                                               Pro_Usuario,
                                               Pro_Anio,
                                               "Tercer Trimestre",
                                               3);
        }

        private void CmdCuartoTrimestre_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion,
                                               Pro_Usuario,
                                               Pro_Anio,
                                               "Cuarto Trimestre",
                                               4);
        }

      

    }
}
