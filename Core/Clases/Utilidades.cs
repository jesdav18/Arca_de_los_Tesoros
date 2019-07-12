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

            if (pConexion.State != System.Data.ConnectionState.Open)
            {
                pConexion.Open();
            }
            string sentencia = "SELECT * FROM configuracion.ft_obtener_hora_servidor();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);

            try
            {
                return (DateTime)pgComando.ExecuteScalar();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en el momento de recuperar la hora del servidor. ");
                return Convert.ToDateTime(null);
            }
        }

        public static int ObtenerNumeroMes(PgSqlConnection pConexion)
        {
            string sentencia = "SELECT * FROM configuracion.ft_proc_obtener_numero_mes();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);

            return (int)pgComando.ExecuteScalar();
        }
    }
}
