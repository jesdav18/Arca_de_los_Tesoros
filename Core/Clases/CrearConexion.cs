using Devart.Data.PostgreSql;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Core.Clases
{
    public class CrearConexion
    {

        #region PROPIEDADES

        public static string Pro_Usuario { get; set; }
        public static string Pro_Contrasenia { get; set; }
        public static string Pro_NombreHost { get; set; }
        public static string Pro_BaseDatos { get; set; }
        public static string Pro_Puerto { get; set; }

        #endregion

        #region FUNCIONES
       
        public static PgSqlConnection Crear_Conexion(string pUsuario,
                                                    string pContrasenia,
                                                    string pNombreHost,
                                                    string pBaseDatos,
                                                    string pPuerto)
        {

            Pro_Usuario = pUsuario;
            Pro_Contrasenia = pContrasenia;
            Pro_NombreHost = pNombreHost;
            Pro_BaseDatos = pBaseDatos;
            Pro_Puerto = pPuerto;
            

            PgSqlConnection v_conexion;
            StringBuilder v_cadena_conexion = new StringBuilder();
            v_cadena_conexion.Append("User Id=");
            v_cadena_conexion.Append(pUsuario);
            v_cadena_conexion.Append(";Password=");
            v_cadena_conexion.Append(pContrasenia);
            v_cadena_conexion.Append(";Host=");
            v_cadena_conexion.Append(pNombreHost);
            v_cadena_conexion.Append(";Database=");
            v_cadena_conexion.Append(pBaseDatos);
            v_cadena_conexion.Append(";Port=");
            v_cadena_conexion.Append(pPuerto);

            string v_cadena = v_cadena_conexion.ToString();

            v_conexion = new PgSqlConnection(v_cadena);

            try
            {               
                if (v_conexion.State != ConnectionState.Open)
                {
                    v_conexion.Unicode = true;
                    v_conexion.Open();
                }

               
            }
            catch (Exception Exc)
            {
                if (Exc.Message == "Timeout expired.")
                {
                    
                    
                    if (MessageBox.Show("No pudo establecerse la conexión. " + Environment.NewLine +
                                        "Presione Si para Reintentarlo, ó Presione No para cancelar el inicio de Arca de los Tesoros. ", "Arca de los Tesoros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {                                          
                        Crear_Conexion(Pro_Usuario,
                                      Pro_Contrasenia,
                                      Pro_NombreHost,
                                      Pro_BaseDatos,
                                      Pro_Puerto);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Log_Excepciones.CapturadorExcepciones(Exc,
                                                          "CrearConexion",
                                                          "CrearConexion()");                
                }
            }

            return v_conexion;
        }

        

        #endregion

    }
}
