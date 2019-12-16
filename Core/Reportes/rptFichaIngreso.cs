using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Core.Reportes
{
    public partial class rptFichaIngreso : DevExpress.XtraReports.UI.XtraReport
    {

        #region INICIALIZADOR
    
        public rptFichaIngreso()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }


        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pId_Colaborador, Usuario Pro_Usuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pId_Colaborador;

            txtUsuarioImprime.Text = Pro_Usuario.Pro_NombreColaborador;
            txtFecha.Text = Utilidades.ObtenerFechaServidor(Pro_Conexion);

           CargarDatos();
        }

        private void CargarDatos()
        {
            string sql = "SELECT* FROM arca_tesoros.ft_view_ficha_ingreso(:p_id_colaborador);";
            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador",PgSqlType.Int).Value = Pro_ID_Colaborador;

            try
            {
                dsVistas1.dtVistasFichaIngreso.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtVistasFichaIngreso);

               
            }
            catch (Exception Exc)
            {
               
            }
        }

        #endregion

    }
}
