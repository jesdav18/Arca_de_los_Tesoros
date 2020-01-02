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
using Core.Clases;

namespace Core.Controles
{
    public partial class ctlIndicadores : UserControl
    {

        #region INICIALIZADOR

        public ctlIndicadores()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;

        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sqlEncabezado = @"SELECT * FROM arca_tesoros_conf.ft_view_areas_atencion ()";
            PgSqlCommand pgComandoEncabezado = new PgSqlCommand(sqlEncabezado, Pro_Conexion);

            string sqlEncabezadoIntermedio = @"SELECT * FROM  arca_tesoros.ft_view_actividades_por_intervalo (
                                                                                                              :p_fecha_desde,
                                                                                                              :p_fecha_hasta
                                                                                                            )";

            PgSqlCommand pgComandoEncabezadoIntermedio = new PgSqlCommand(sqlEncabezadoIntermedio, Pro_Conexion);
            pgComandoEncabezadoIntermedio = new PgSqlCommand(sqlEncabezadoIntermedio, Pro_Conexion);
            pgComandoEncabezadoIntermedio.Parameters.Add("p_fecha_desde", PgSqlType.Date).Value = dateDesde.DateTime;
            pgComandoEncabezadoIntermedio.Parameters.Add("p_fecha_hasta", PgSqlType.Date).Value = dateHasta.DateTime;


            string sqlDetalle = @"SELECT * FROM arca_tesoros.ft_view_detalle_asistencia (
                                                                                          :p_fecha_desde,
                                                                                          :p_fecha_hasta
                                                                                        )";

            PgSqlCommand pgComandoDetalle = new PgSqlCommand(sqlDetalle, Pro_Conexion);
            pgComandoDetalle.Parameters.Add("p_fecha_desde",PgSqlType.Date).Value = dateDesde.DateTime;
            pgComandoDetalle.Parameters.Add("p_fecha_hasta",PgSqlType.Date).Value = dateHasta.DateTime;


            try
            {
                dsVistas1.dtDetalleAsistencias.Clear();
                dsVistas1.dtActividad.Clear();
                dsVistas1.dtAreasAtencion.Clear();

                new PgSqlDataAdapter(pgComandoEncabezado).Fill(dsVistas1.dtAreasAtencion);
                new PgSqlDataAdapter(pgComandoEncabezadoIntermedio).Fill(dsVistas1.dtActividad);
                new PgSqlDataAdapter(pgComandoDetalle).Fill(dsVistas1.dtDetalleAsistencias);
            }
            catch (Exception Exc)
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", Exc.Message, Utilidades.BotonesDialogo.Ok);
                return;

            }

        }

        private void PicCargar_Click(object sender, EventArgs e)
        {
            ctlAsistenciaEquipos1.ConstruirControl(Pro_Conexion,dateDesde.DateTime,dateHasta.DateTime);
            CargarDatos();
        }

        #endregion


    }
}
