using Devart.Data.PostgreSql;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Core.Clases
{
    public static class Utilidades
    {
        public enum BotonesDialogo
        {
            None,
            YesNo,
            OkCancel,
            Ok
        };

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

        public static string ObtenerFechaServidor(PgSqlConnection pConexion)
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
                    v_resultado = pgDr.GetString("fecha");
                }

                pgDr.Close();

                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

                return v_resultado;
            }
            catch (Exception Exc)
            {
                
                Log_Excepciones.CapturadorExcepciones(Exc, "Utilidades.cs", "ObtenerHoraServidor");
                return null;
            }
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

        public static DialogResult MostrarDialogo(Form pFormPadre, 
                                                  string pEtiqueta, 
                                                  string pDescripcion, 
                                                  BotonesDialogo pBotones)
        {
            FlyoutAction v_accion = new FlyoutAction()
            {
                Caption = pEtiqueta,
                Description = pDescripcion
            };

            FlyoutCommand v_comando_1;
            FlyoutCommand v_comando_2;

            switch (pBotones)

            {
                case BotonesDialogo.None:
                    break;

                case BotonesDialogo.Ok:
                    v_comando_1 = new FlyoutCommand()
                    {
                        Text = "Aceptar",
                        Result = DialogResult.OK
                    };

                    v_accion.Commands.Add(v_comando_1);

                    break;

                case BotonesDialogo.YesNo:
                    v_comando_1 = new FlyoutCommand()
                    {
                        Text = "Si",
                        Result = DialogResult.Yes
                    };

                    v_accion.Commands.Add(v_comando_1);

                    v_comando_2 = new FlyoutCommand()
                    {
                        Text = "No",
                        Result = DialogResult.No
                    };

                    v_accion.Commands.Add(v_comando_2);
                    break;

                case BotonesDialogo.OkCancel:

                    v_comando_1 = new FlyoutCommand()
                    {
                        Text = "Aceptar",
                        Result = DialogResult.OK
                    };

                    v_accion.Commands.Add(v_comando_1);

                    v_comando_2 = new FlyoutCommand()
                    {
                        Text = "Cancelar",
                        Result = DialogResult.Cancel
                    };

                    v_accion.Commands.Add(v_comando_1);
                    break;

                default:

                    break;

            }

            FlyoutProperties v_propiedades = new FlyoutProperties()
            {
                ButtonSize = new Size(100, 40),
                Style = FlyoutStyle.MessageBox

            };

            Predicate<DialogResult> v_predicado = canCloseFunc;

            return FlyoutDialog.Show(pFormPadre, v_accion, v_propiedades, v_predicado);

        }

        private static bool canCloseFunc(DialogResult pParametro)
        {
            return pParametro != DialogResult.Cancel;
        }
    }
}
