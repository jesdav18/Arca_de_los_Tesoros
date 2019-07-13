using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Controles
{
    public partial class ctlIngresoFicha : UserControl
    {
        public ctlIngresoFicha()
        {
            InitializeComponent();
        }

        private void PicSiguientePag1_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page2;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "2 de 7";

        }

        private void PicSiguientePag2_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page3;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "3 de 7";
        }

        private void PicAtrasPag2_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page1;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "1 de 7";
        }

        private void PicAtrasPag3_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page2;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "2 de 7";
        }

        private void PicSiguientePag3_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page4;
            lblEncabezado.Text = "Datos Laborales y Educativos";
            lblPagina.Text = "4 de 7";
        }

        private void PicAtrasPag4_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page3;
            lblEncabezado.Text = "Datos Generales";
            lblPagina.Text = "3 de 7";

        }

        private void PicSiguientePag4_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page5;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "5 de 7";
        }

        private void PicSiguientePag5_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page6;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "6 de 7";
        }

        private void PicAtrasPag5_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page4;
            lblEncabezado.Text = "Datos Laborales y Educativos";
            lblPagina.Text = "4 de 7";
        }

        private void PicSiguientePag6_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page7;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "7 de 7";

        }

        private void PicAtrasPag6_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page5;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "5 de 7";
        }

        private void PicAtrasPag7_Click(object sender, EventArgs e)
        {
            NavigationFicha.SelectedPage = Page6;
            lblEncabezado.Text = "Datos de Establecimiento en la Iglesia";
            lblPagina.Text = "6 de 7";
        }

        private void CmdGuardarFichaIngreso_Click(object sender, EventArgs e)
        {

        }

   
    }
}
