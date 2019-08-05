using Devart.Data.PostgreSql;
using System;
using System.Net;
using System.Windows.Forms;

namespace Core.Clases
{
    public static class Utilidades
    {
        public static string ObtenerIP_Host()
        {
            IPHostEntry v_host;
            string v_ip_host = "";
            v_host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iterador_ip in v_host.AddressList)
            {
                if (iterador_ip.AddressFamily.ToString() == "InterNetwork")
                {
                    v_ip_host = iterador_ip.ToString();
                    break;
                }
            }

            return v_ip_host;
        }

        public static DateTime ObtenerHoraServidor(PgSqlConnection pConexion)
        {
            DateTime v_resultado = Convert.ToDateTime(null);

            if (pConexion.State != System.Data.ConnectionState.Open)
            {
                pConexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_variables_tiempo();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    v_resultado = pgDr.GetDateTime("fecha_hora_servidor");
                }

                pgDr.Close();

                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

                return v_resultado;
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de recuperar la hora del servidor. ");
                Log_Excepciones.CapturadorExcepciones(Exc, "Utilidades.cs", "ObtenerHoraServidor");
                return Convert.ToDateTime(null);              
            }
        }

        public static string ObtenerAnioServidor(PgSqlConnection pConexion)
        {
            string v_resultado = null;

            if (pConexion.State != System.Data.ConnectionState.Open)
            {
                pConexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros_conf.ft_view_variables_tiempo();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    v_resultado = pgDr.GetString("anio");
                }

                pgDr.Close();

                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

                return v_resultado;
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de recuperar el año de desde la fecha/hora del servidor. ");
                Log_Excepciones.CapturadorExcepciones(Exc, "Utilidades.cs", "ObtenerMesServidor");
                return null;
            }
        }


    }
}
