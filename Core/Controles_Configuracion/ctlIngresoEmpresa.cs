using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Core.Controles_Configuracion
{
    public partial class ctlIngresoEmpresa : UserControl
    {

        #region INICIALIZADOR

        public ctlIngresoEmpresa()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

        #endregion

        #region EVENTOS

        public event EventHandler OnEmpresaRegistrada;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;
            memoEmpresa.Focus();
        }

        private void InsertarEmpresa()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            int v_resultado;
            string sql = @"SELECT * FROM arca_tesoros_conf.ft_mant_insertar_empresa (
                                                                                      :p_nombre_empresa,
                                                                                      :p_telefono_empresa
                                                                                    )";

            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            pgComando.Parameters.Add("p_nombre_empresa",PgSqlType.VarChar).Value = memoEmpresa.Text;
            pgComando.Parameters.Add("p_telefono_empresa",PgSqlType.VarChar).Value = txtTelefono.Text;

            try
            {
                v_resultado = Convert.ToInt32(pgComando.ExecuteScalar());

                if (v_resultado != 0)
                {
                    OnEmpresaRegistrada?.Invoke(v_resultado,new EventArgs());
                }
              
            }
            catch (Exception Exc)
            {
      
            }

        }

        #endregion

        private void CmdGuardarEmpresa_Click(object sender, EventArgs e)
        {
            InsertarEmpresa();
        }
    }
}
