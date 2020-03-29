using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlSeleccionAreaAtencion : UserControl
    {
        public ctlSeleccionAreaAtencion()
        {
            InitializeComponent();
        }

        public event EventHandler OnSeleccionaAreaAtencion;

        public PgSqlConnection Pro_Conexion { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                dsVistas1.dtAreasAtencion.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtAreasAtencion);            
            }
            catch (Exception Exc)
            {                      
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatos");
            }
        }

        private void GvAreasAtencion_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dsVistas.dtAreasAtencionRow v_fila = (dsVistas.dtAreasAtencionRow)gvAreasAtencion.GetFocusedDataRow();
            if (v_fila != null)
            {
                OnSeleccionaAreaAtencion?.Invoke(v_fila, new EventArgs());
            }
        }
    }
}
