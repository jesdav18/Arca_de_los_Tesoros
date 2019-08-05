using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlDiasTrimestre : UserControl
    {
        public ctlDiasTrimestre()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Anio { get; set; }
        public int Pro_NumeroTrimestre { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, 
                                      string pUsuario,
                                      string pAnio,
                                      string pDescripcionTrimestre,
                                      int pNumeroTrimestre)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_NumeroTrimestre = pNumeroTrimestre;
            Pro_Anio = pAnio;
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
                MessageBox.Show("Algo salió mal en el momento de recuperar fecha del trimestre. ");
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ObtenerFechasTrimestre");
              
            }
        }

        public event EventHandler OnSeleccionaDia;

        private void v_item_dia_selecciona_dia(object sender, EventArgs e)
        {
            OnSeleccionaDia?.Invoke(sender, e);
        }

        public event EventHandler OnIrAtras;
        private void PicAtras_Click(object sender, EventArgs e)
        {
            OnIrAtras?.Invoke(sender, e);
        }
    }
}
