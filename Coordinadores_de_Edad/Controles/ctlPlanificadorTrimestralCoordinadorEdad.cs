using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;


namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlPlanificadorTrimestralCoordinadorEdad : UserControl
    {

        #region INICIALIZADOR
 
        public ctlPlanificadorTrimestralCoordinadorEdad()
        {
            InitializeComponent();          
            ctlDiasTrimestre1.OnSeleccionaDia += ctlDiasTrimestre1_OnSeleccionaDia;
           
        }

        #endregion

        #region PROPIEDADES
  
        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Anio { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }
        public int Pro_Trimestre { get; set; }
       

        #endregion

        #region VARIABLES GLOBALES

        string v_dia_seleccionado;

        #endregion

        #region FUNCIONES

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
            pnlDesplazamiento.Visible = false;
           
        }

        private void IrAtras()
        {
            if (NavigationPrincipal.SelectedPage == pageDias)
            {
                NavigationPrincipal.SelectedPage = PageTrimestres;
            }
            else if (NavigationPrincipal.SelectedPage == pageSeleccionMaestros)
            {
                NavigationPrincipal.SelectedPage = pageDias;
            }
            else if (NavigationPrincipal.SelectedPage == pageSeleccionAyuda)
            {
                NavigationPrincipal.SelectedPage = pageSeleccionMaestros;
            }
            else if (NavigationPrincipal.SelectedPage == PageIngresoActividades)
            {
                NavigationPrincipal.SelectedPage = pageSeleccionAyuda;
            }
        }

        private void IrAdelante()
        {      
            if (NavigationPrincipal.SelectedPage == pageSeleccionMaestros)
            {
                NavigationPrincipal.SelectedPage = pageSeleccionAyuda;
                ctlSeleccionAyuda1.ConstruirControl(Pro_Conexion,
                                                    Pro_Usuario,
                                                    v_dia_seleccionado,
                                                    ctlDiasTrimestre1.Pro_ID_Actividad_Generado,
                                                    Pro_ID_AreaAtencion
                                                    );

            }   
            else if (NavigationPrincipal.SelectedPage == pageSeleccionAyuda)
            {
                NavigationPrincipal.SelectedPage = PageIngresoActividades;
                ctlngresoActividad1.ConstruirControl(Pro_Conexion,
                                                     ctlDiasTrimestre1.Pro_ID_Actividad_Generado,
                                                     v_dia_seleccionado,
                                                     Pro_Usuario);
            }         
        }

        #endregion

        #region EVENTOS CONTROLES

      

        private void ctlDiasTrimestre1_OnSeleccionaDia(object sender, EventArgs e)
        {
            v_dia_seleccionado = (string)sender;

            NavigationPrincipal.SelectedPage = pageSeleccionMaestros;
            ctlSeleccionMaestros_Ayudas1.ConstruirControl(Pro_Conexion,
                                                          Pro_Usuario,
                                                          v_dia_seleccionado,
                                                          ctlDiasTrimestre1.Pro_ID_Actividad_Generado,
                                                          Pro_ID_AreaAtencion);
        }

        private void CmdPrimerTrimestre_Click(object sender, EventArgs e)
        {
            Pro_Trimestre = 1;

            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion, 
                                               Pro_Usuario, 
                                               Pro_Anio, 
                                               "Primer Trimestre", 
                                               Pro_Trimestre,
                                               Pro_ID_AreaAtencion);
        }

        private void CmdSegundoTrimestre_Click(object sender, EventArgs e)
        {
            Pro_Trimestre = 2;

            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion,
                                               Pro_Usuario,
                                               Pro_Anio,
                                               "Segundo Trimestre",
                                               Pro_Trimestre,
                                               Pro_ID_AreaAtencion);
        }

        private void CmdTercerTrimestre_Click(object sender, EventArgs e)
        {
            Pro_Trimestre = 3;

            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion,
                                               Pro_Usuario,
                                               Pro_Anio,
                                               "Tercer Trimestre",
                                               Pro_Trimestre,
                                               Pro_ID_AreaAtencion);
        }

        private void CmdCuartoTrimestre_Click(object sender, EventArgs e)
        {
            Pro_Trimestre = 4;

            NavigationPrincipal.SelectedPage = pageDias;
            ctlDiasTrimestre1.ConstruirControl(Pro_Conexion,
                                               Pro_Usuario,
                                               Pro_Anio,
                                               "Cuarto Trimestre",
                                               Pro_Trimestre,
                                               Pro_ID_AreaAtencion);
        }

        private void PicSiguiente_Click(object sender, EventArgs e)
        {
            IrAdelante();
        }

        private void PicAtras_Click(object sender, EventArgs e)
        {
            IrAtras();
        }

        private void NavigationPrincipal_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (NavigationPrincipal.SelectedPage == PageTrimestres)
            {
                pnlDesplazamiento.Visible = false;
            }
            else
            {
                pnlDesplazamiento.Visible = true;
                if (NavigationPrincipal.SelectedPage == pageDias || NavigationPrincipal.SelectedPage == PageIngresoActividades)
                {
                    picSiguiente.Visible = false;
                }
                else
                {
                    picSiguiente.Visible = true;
                }
            }
        }

        #endregion
    }
}
