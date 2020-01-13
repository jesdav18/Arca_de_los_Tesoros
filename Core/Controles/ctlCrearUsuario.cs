using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlCrearUsuario : UserControl
    {

        #region INICIALIZADOR

        public ctlCrearUsuario()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        private PgSqlConnection Pro_Conexion { get; set; }
        private string Pro_PrimerNombre { get; set; }
        private string Pro_SegundoNonbre { get; set; }
        private string Pro_PrimerApellido { get; set; }
        private string Pro_SegundoApellido { get; set; }
        public int Pro_ID_Colaborador { get; set; }
        public string Pro_Usuario { get; set; }
       

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     string pPrimerNombre, 
                                     string pSegundoNombre,
                                     string pPrimerApellido,
                                     string pSegundoApellido,
                                     int pID_Colaborador,
                                     string pUsuario, 
                                     int pID_Cargo,
                                     bool pEsVista = false)
        {
            Pro_Conexion = pConexion;
            Pro_PrimerNombre = pPrimerNombre;
            Pro_SegundoNonbre = pSegundoNombre;
            Pro_PrimerApellido = pPrimerApellido;
            Pro_SegundoApellido = pSegundoApellido;
            Pro_ID_Colaborador = pID_Colaborador;
            Pro_Usuario = pUsuario;

            NavegacionPrincipal.SelectedPage = PageCreacionUsuario;

            if (pEsVista)
            {
                lblEncabezado.Text = "Reestablecer Contraseña";
                txtUsuario.Text = pUsuario;
                lblEtiquetaUsuario.Text = "Usuario";
                cmdGuardarUsuario.Visible = false;

                CargarDatosCargos();

                foreach (dsConfiguracion.dtCargosRow item in dsConfiguracion1.dtCargos)
                {
                    if (item.id_cargo == pID_Cargo)
                    {
                        glPerfilUsuario.EditValue = pID_Cargo;
                        break;
                    }
                }
            }
            else
            {
                CargarSugerenciaUsuario();
                CargarDatosCargos();
            }
        }

        private void CargarSugerenciaUsuario()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sql = @"SELECT * FROM arca_tesoros.ft_proc_obtener_usuario_sugerido (
                                                                                          :p_primer_nombre,
                                                                                          :p_primer_apellido,
                                                                                          :p_segundo_nombre,
                                                                                          :p_segundo_apellido
                                                                                        );";
            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            pgComando.Parameters.Add("p_primer_nombre",PgSqlType.VarChar).Value = Pro_PrimerNombre;
            pgComando.Parameters.Add("p_primer_apellido",PgSqlType.VarChar).Value = Pro_PrimerApellido;
            pgComando.Parameters.Add("p_segundo_nombre",PgSqlType.VarChar).Value = Pro_SegundoNonbre;
            pgComando.Parameters.Add("p_segundo_apellido",PgSqlType.VarChar).Value = Pro_SegundoApellido;

            try
            {
                string v_resultado = Convert.ToString(pgComando.ExecuteScalar());
                txtUsuario.Text = v_resultado;


            }
            catch (Exception Exc)
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", Exc.Message, Utilidades.BotonesDialogo.Ok);
            }


        }

        private void CargarDatosCargos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sql = @"SELECT * FROM arca_tesoros_conf.ft_view_cargos ( );";


            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            

            try
            {
                dsConfiguracion1.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguracion1.dtCargos);


            }
            catch (Exception Exc)
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", Exc.Message, Utilidades.BotonesDialogo.Ok);
            }


        }

        private void ReestablecerContrasenia()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sql = @"SELECT * FROM arca_tesoros.ft_mant_reestablecer_clave_usuario (
                                                                                          :p_usuario,
                                                                                          :p_nueva_contrasenia
                                                                                        )";
            PgSqlCommand pgComando = new PgSqlCommand(sql, Pro_Conexion);
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_nueva_contrasenia", PgSqlType.VarChar).Value = txtContraseniaTemporal.Text;
        

            try
            {
                pgComando.ExecuteNonQuery();
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡La contraseña fue reestablecida!", Utilidades.BotonesDialogo.Ok);
                OnCerrar?.Invoke(new object(),new EventArgs());
            }
            catch (Exception Exc)
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", Exc.Message, Utilidades.BotonesDialogo.Ok);
            }


        }


        #endregion

        #region EVENTOS

        public event EventHandler OnCerrar;

        #endregion

        private void CmdGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "Por favor ingrese un nombre de usuario.",Utilidades.BotonesDialogo.Ok);
                return;
            }
            else if (string.IsNullOrEmpty(glPerfilUsuario.EditValue.ToString()))
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "Por favor seleccione el perfil del usuario.", Utilidades.BotonesDialogo.Ok);
                return;
            }

          
                MantenimientoColaboradores.CrearUsuarioColaborador(Pro_Conexion,
                                                              Pro_ID_Colaborador,
                                                              (int)glPerfilUsuario.EditValue,
                                                              txtUsuario.Text);
            
            

           
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            OnCerrar?.Invoke(sender, e);
        }

        private void CmdReeestablecerContrasenia_Click(object sender, EventArgs e)
        {
            txtContraseniaTemporal.ResetText();
            NavegacionPrincipal.SelectedPage = pageReestablecerContrasenia;
        }

        private void CmdReestablecerContrasenia_Click(object sender, EventArgs e)
        {
            ReestablecerContrasenia();
        }
    }
}
