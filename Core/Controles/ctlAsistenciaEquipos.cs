using System;
using System.Windows.Forms;
using Core.Clases;
using Devart.Data.PostgreSql;

namespace Core.Controles
{
    public partial class ctlAsistenciaEquipos : UserControl
    {
        #region INICIALIZADOR

        public ctlAsistenciaEquipos()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public DateTime Pro_Desde { get; set; }

        public DateTime Pro_Hasta { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, DateTime pDesde, DateTime pHasta)

        {
            Pro_Conexion = pConexion;
            Pro_Desde = pDesde;
            Pro_Hasta = pHasta;
            CargarDatos();
        }

        private void CargarDatos()
        {
            PgSqlConnection v_conexion_temporal = new PgSqlConnection(Pro_Conexion.ConnectionString);
            v_conexion_temporal.Password = Pro_Conexion.Password;
            v_conexion_temporal.Open();

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_dashboard_asistencia_equipos (
                                                                                                    :p_fecha_desde,
                                                                                                    :p_fecha_hasta
                                                                                                );";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, v_conexion_temporal);
            pgComando.Parameters.Add("p_fecha_desde",PgSqlType.Date).Value = Pro_Desde;
            pgComando.Parameters.Add("p_fecha_hasta",PgSqlType.Date).Value = Pro_Hasta;

            try
            {
                dsVistas1.dtAsistenciasEquipos.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtAsistenciasEquipos);

                chartControl1.Show();
                chartControl1.RefreshData();

            }
            catch (Exception Exc)
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Algo salió mal en la carga de datos!", Utilidades.BotonesDialogo.Ok);
               
            }

        }

        #endregion


    }
}
