﻿using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.DataSets;
using Core.Clases;

namespace Core.Controles
{
    public partial class ctlBusquedaFichasIngreso : UserControl
    {

        #region INICIALIZADOR

        public ctlBusquedaFichasIngreso()
        {
            InitializeComponent();
            ctlVistaFichaIngreso1.OnPresionaIrAtras += ctlVistaFichaIngreso1_OnIrAtras;
        }

   
        #endregion

        #region PROPIEDADES


        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }


        #endregion

        #region EVENTOS

        public event EventHandler OnPresionarVerFicha;
        public event EventHandler OnIrAtras;

        #endregion

        #region FUNCIONES


        public void ConstruirControl(PgSqlConnection pConexion, Usuario pUsuario)
        {
            Pro_Conexion = pConexion;
            ctlVistaFichaIngreso1.Pro_Conexion = Pro_Conexion;
            Pro_Usuario = pUsuario;

            NavegacionPrincipal.SelectedPage = PageBusquedas;
            NavigationBusqueda.SelectedPage = PageBusqueda;
            txtBusqueda.ResetText();


            txtBusqueda.Focus();     
        }

        private void RealizarBusqueda()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_proc_busqueda_fichas_ingreso(:p_filtros_busqueda);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_filtros_busqueda", PgSqlType.VarChar).Value = txtBusqueda.Text;

            try
            {
                dsVistas1.dtVistasFichaIngreso.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtVistasFichaIngreso);
            }
            catch (Exception Exc)
            {

                MessageBox.Show("Algo salió mal en el momento de realizar la busqueda");
            }

        }


        #endregion

        #region EVENTOS CONTROLES


        private void PicBusqueda_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusqueda.Text))
            {
               
                RealizarBusqueda();
                if (dsVistas1.dtVistasFichaIngreso.Count > 0)
                {
                    NavigationBusqueda.SelectedPage = PageVistaFichasIngreso;
                }
                else
                {
                    MessageBox.Show("La busqueda no obtuvo ningun resultado");
                }
            }
            else
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "Por favor ingrese un filtro para realizar la busqueda", Utilidades.BotonesDialogo.Ok);
             
            }

        }

        private void CmdIrAtras_Click(object sender, EventArgs e)
        {
            NavigationBusqueda.SelectedPage = PageBusqueda;
        }

        private void CmdVerFicha_Click(object sender, EventArgs e)
        {
            var v_fila = (dsVistas.dtVistasFichaIngresoRow)gvVistasFichaIngreso.GetFocusedDataRow();
            if (v_fila != null)
            {
                
                ctlVistaFichaIngreso1.ConstruirControl(Pro_Conexion, v_fila.id_colaborador,Pro_Usuario,v_fila.genero);             
                NavegacionPrincipal.SelectedPage = PageFichaIngreso;
            }
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PicBusqueda_Click(sender, new KeyEventArgs(Keys.Enter));
            }
        }

        private void ctlVistaFichaIngreso1_OnIrAtras(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageBusquedas;
            NavigationBusqueda.SelectedPage = PageVistaFichasIngreso;
        }

        #endregion

        private void CmdAtras_Click(object sender, EventArgs e)
        {
            NavigationBusqueda.SelectedPage = PageBusqueda;
        }

        private void PageBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            gvVistasFichaIngreso.FindFilterText = "\"" + txtBuscar.Text + "\"";
        }
    }
}
