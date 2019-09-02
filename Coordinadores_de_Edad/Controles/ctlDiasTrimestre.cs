using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Data;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlDiasTrimestre : UserControl
    {
        #region INICIALIZADOR

        public ctlDiasTrimestre()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Anio { get; set; }
        public int Pro_NumeroTrimestre { get; set; }
        public int Pro_ID_Area_Atencion { get; set; }
        public int Pro_ID_Actividad_Generado { get; set; }

        #endregion

        #region EVENTOS

        public event EventHandler OnSeleccionaDia;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                      string pUsuario,
                                      string pAnio,
                                      string pDescripcionTrimestre,
                                      int pNumeroTrimestre,
                                      int pID_AreaAtencion)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_NumeroTrimestre = pNumeroTrimestre;
            Pro_Anio = pAnio;
            Pro_ID_Area_Atencion = pID_AreaAtencion;
            lblTituloEncabezado.Text = pDescripcionTrimestre + " del Año " + pAnio;
           
            ObtenerFechasTrimestre();
        }

        private void ObtenerFechasTrimestre()
        {
           

            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros_conf.ft_view_dias_trimestre(:p_numero_trimestre,
                                                                                        :p_anio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_numero_trimestre", PgSqlType.Int).Value = Pro_NumeroTrimestre;
            pgComando.Parameters.Add("p_anio", PgSqlType.VarChar).Value = Pro_Anio;

            try
            {
                TileDias.Controls.Clear();

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                while (pgDr.Read())
                {
                    ctlItemDiaTrabajo v_item_dia = new ctlItemDiaTrabajo();
                    v_item_dia.ConstruirControl(pgDr.GetString("dia_trimestre"));
                    v_item_dia.OnSeleccionaDia += v_item_dia_selecciona_dia;

                    TileDias.Controls.Add(v_item_dia);

                    v_item_dia = null;
                }

                pgDr.Close();

                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

              
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de recuperar fecha del trimestre. ","Arca de los Tesoros");
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ObtenerFechasTrimestre");
              
            }
        }

        private int CreacionActividad(string pFecha)
        {
            int v_id_area_atencion;
            
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_creacion_actividad (
                                                                                          :p_fecha_actividad,
                                                                                          :p_id_area_atencion,
                                                                                          :p_usuario
                                                                                        )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_fecha_actividad", PgSqlType.Date).Value = Convert.ToDateTime(pFecha);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_Area_Atencion;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
       
            try
            {
                v_id_area_atencion = Convert.ToInt32 (pgComando.ExecuteScalar());

                sentencia = null;
                pgComando.Dispose();

                return v_id_area_atencion;

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CreacionActividad");
                MessageBox.Show("Algo salió mal mientras se creaba la actividad.","Arca de los Tesoros");
                return 0;
            }
        }

        #endregion

        #region EVENTOS CONTROLES
 
        private void v_item_dia_selecciona_dia(object sender, EventArgs e)
        {

            Pro_ID_Actividad_Generado = CreacionActividad((string)sender);
            if (Pro_ID_Actividad_Generado != 0)
            {
                OnSeleccionaDia?.Invoke(sender, e);
            }
           
        }

        #endregion

    }
}
