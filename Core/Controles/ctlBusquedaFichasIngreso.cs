﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlBusquedaFichasIngreso : UserControl
    {
        public ctlBusquedaFichasIngreso()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;
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
                MessageBox.Show("Por favor ingrese un filtro para realizar la busqueda");
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

            }
        }
    }
}