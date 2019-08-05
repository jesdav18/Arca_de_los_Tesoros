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

namespace Core.Controles
{
    public partial class ctlVistaFichaIngreso : UserControl
    {
        public ctlVistaFichaIngreso()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;

            CargarDatos();
        }

        private void CargarDatos()
        {
            splashScreenManager1.ShowWaitForm();

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }
         
            try
            {
                string sentencia = @"SELECT * FROM arca_tesoros.ft_view_ficha_ingreso (:p_id_colaborador );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_ID_Colaborador;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    lblNombreColaborador.Text = pgDr.GetString("nombre_colaborador");
                    lblNumeroIdentidad.Text = pgDr.GetString("numero_identidad");
                    lblFechaNacimiento.Text = pgDr.GetString("fecha_nacimiento");
                    lblEstadoCivil.Text = pgDr.GetString("estado_civil");
                    lblGenero.Text = pgDr.GetString("genero");
                    lblCorreo.Text = pgDr.GetString("correo_electronico");
                    lblDireccion.Text = pgDr.GetString("direccion");
                    lblCelular.Text = pgDr.GetString("celular");
                    lblPaisNacimiento.Text = pgDr.GetString("pais_nacimiento");
                    lblTipoSangre.Text = pgDr.GetString("tipo_sangre");
                    lblNecesitaTransporte.Text = pgDr.GetString("necesita_transporte");
                    lblFechaConversion.Text = pgDr.GetString("fecha_conversion");
                    lblFechaIngresoIglesia.Text = pgDr.GetString("fecha_ingreso_iglesia");
                    lblFechaBautismoAgua.Text = pgDr.GetString("fecha_bautismo_agua");
                    lblEquipoArcaTesoros.Text = pgDr.GetString("equipo_arca_tesoros");
                    lblCargoColaborador.Text = pgDr.GetString("cargo_colaborador");
                    lblFechaCobertura.Text = pgDr.GetString("fecha_cobertura");
                    lblFechaReconciliacion.Text = pgDr.GetString("fecha_reconciliacion");
                    lblBautismoEspiritu.Text = pgDr.GetString("bautismo_espiritu");
                    lblEdadArea.Text = pgDr.GetString("area_atencion");
                    lblFechaInicioPrivilegio.Text = pgDr.GetString("fecha_inicio_privilegio");
                    lblOtrosEquiposPrivilegio.Text = pgDr.GetString("otros_equipos_privilegio");
                    lblEmpresa.Text = pgDr.GetString("empresa");
                    lblCargo.Text = pgDr.GetString("cargo_en_empresa");
                    lblTelefonoEmpresa.Text = pgDr.GetString("telefono_empresa");
                    lblEstadoProfesional.Text = pgDr.GetString("estado_profesional");
                    lblNivelEducativo.Text = pgDr.GetString("nivel_educativo");
                }

                pgDr.Close();

                sentencia = null;
                pgDr = null;
                pgComando.Dispose();

                splashScreenManager1.CloseWaitForm();

            }
            catch (PgSqlException Exc)
            {

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                MessageBox.Show(Exc.Message, "Arca de los Tesoros");

            }

        }
    }
}
