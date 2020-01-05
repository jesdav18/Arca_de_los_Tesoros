using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Text;

namespace Core.Controles
{
    public partial class ctlLogin : UserControl
    {

        #region INICIALIZADOR

        public ctlLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_NombreColaborador { get; private set; }
        public string Pro_UsuarioColaborador { get; private set; }
        public int Pro_ID_RolUsuario { get; private set; }
        public string Pro_DescripcionRolUsuario { get; private set; }
        public int Pro_ID_Colaborador { get; private set; }
        public string Pro_NombreEquipo { get; set; }
        public int Pro_ID_Cargo { get; set; }
        public string Pro_DescripcionCargo { get; set; }
        public int Pro_ID_AreaAtencion { get; set; }
        public bool Pro_EsPrimerLogin { get; set; }

        #endregion

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;

            txtUsuario.Focus();
            txtUsuario.Select();
        }

        public event EventHandler OnUsuarioLogueado;

        private void CmdAcceder_Click(object sender, EventArgs e)
        {

           
            if (ValidarUsuarioLogueo())
            {
                Usuario c_Usuario = new Usuario();
                c_Usuario.Pro_ID_Colaborador = Pro_ID_Colaborador;
                c_Usuario.Pro_Usuario = Pro_UsuarioColaborador;
                c_Usuario.Pro_DescripcionRolUsuario = Pro_DescripcionRolUsuario;
                c_Usuario.Pro_ID_RolUsuario = Pro_ID_RolUsuario;
                c_Usuario.Pro_NombreColaborador = Pro_NombreColaborador;
                c_Usuario.Pro_NombreEquipo = Pro_NombreEquipo;
                c_Usuario.Pro_ID_Cargo = Pro_ID_Cargo;
                c_Usuario.Pro_DescripcionCargo = Pro_DescripcionCargo;
                c_Usuario.Pro_ID_AreaAtencion = Pro_ID_AreaAtencion;
              

                OnUsuarioLogueado?.Invoke(c_Usuario, e);
                c_Usuario = null;
            }
           
        }


        private void ValidarConexion()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                try
                {
                    Pro_Conexion.Open();
                }
                catch (Exception Exc)
                {
                    Log_Excepciones.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ValidarConexion()");
                    
                    PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
                    v_conexion.Password = Pro_Conexion.Password;
                    Pro_Conexion = v_conexion;
                    Pro_Conexion.Open();
                    v_conexion = null;
                }
            }
        }

        private bool ValidarUsuarioLogueo()
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            bool v_encontro_usuario = false;

            ValidarConexion();
            Pro_Conexion.Unicode = true;
            Pro_Conexion.Open();
            try
            {
                string sentencia = @"SELECT * FROM arca_tesoros.ft_proc_valida_usuario_acceso (
                                                                                                  :p_usuario,
                                                                                                  :p_contrasenia            
                                                                                                );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = txtUsuario.Text;
                pgComando.Parameters.Add("p_contrasenia", PgSqlType.VarChar).Value = txtContrasenia.Text;
           
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    Pro_NombreColaborador = pgDr.GetString("nombre_colaborador");
                    Pro_UsuarioColaborador = pgDr.GetString("usuario");                  
                    Pro_DescripcionRolUsuario = pgDr.GetString("descripcion");
                    Pro_ID_RolUsuario = pgDr.GetInt32("id_rol_usuario");
                    Pro_ID_Colaborador = pgDr.GetInt32("id_colaborador");
                    Pro_ID_Cargo = pgDr.GetInt32("id_cargo");
                    Pro_DescripcionCargo = pgDr.GetString("descripcion_cargo");
                    Pro_NombreEquipo = pgDr.GetString("nombre_equipo");
                    Pro_ID_AreaAtencion = pgDr.GetInt32("id_area_atencion");
                    Pro_EsPrimerLogin = pgDr.GetBoolean("es_primer_login");
                  


                    if (Pro_EsPrimerLogin)
                    {
                       
                        popupCambiarContrasenia.ShowPopup();
                        txtNuevaContrasenia.Focus();
                    }
                    else
                    {
                        v_encontro_usuario = true;
                    }
                }

                pgDr.Close();

                sentencia = null;
                pgDr = null;
                pgComando.Dispose();


                if (splashScreenManager1.IsSplashFormVisible)
                {

                    splashScreenManager1.CloseWaitForm();
                }


                if (v_encontro_usuario)
                {
                    return true;
                }
                else
                {
                    return false;
                }

               

            }
            catch (PgSqlException Exc)
            {

                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                if (Exc.Message == "Unexpected server response.")
                {
                    Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "En este momento hay dificultades en la conexión de red. Por favor vuelva a intentar.", Utilidades.BotonesDialogo.Ok);
                }
                else
                {
                    Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", Exc.Message, Utilidades.BotonesDialogo.Ok);
                }


                

       
                txtUsuario.Focus();
                return false;
            }

        }

        private void ResetearContrasenia()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_reestablecer_clave_usuario (
                                                                                                  :p_usuario,
                                                                                                  :p_nueva_contrasenia
                                                                                                )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_UsuarioColaborador;
            pgComando.Parameters.Add("p_nueva_contrasenia", PgSqlType.VarChar).Value = txtNuevaContrasenia.Text;


            try
            {
                pgComando.ExecuteNonQuery();
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡La contraseña fue modificada!", Utilidades.BotonesDialogo.Ok);
                popupCambiarContrasenia.HidePopup();
                this.BringToFront();
                txtContrasenia.Focus();

            }
            catch (Exception Exc)
            {
                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatos");

            }
        }
    

        private void TxtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmdAcceder_Click(sender, new EventArgs());
            }
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            popupCambiarContrasenia.HidePopup();
            this.BringToFront();
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasenia.Text == txtConfirmacionContrasenia.Text)
            {
                ResetearContrasenia();
            }
            else
            {
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Las contraseñas no coinciden!", Utilidades.BotonesDialogo.Ok);               
            }

            
        }
    }
}
