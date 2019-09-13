using Core.Clases;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Arca_de_los_Tesoros
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       

            ThreadExceptionHandler handler = new ThreadExceptionHandler();
            Application.ThreadException += new ThreadExceptionEventHandler(handler.LanzadorExcepciones);
            try
            {
                Application.Run(new frmContructor());
            }
            catch (Exception exc)
            {
               Log_Excepciones.CapturadorExcepciones(exc,
                                                      "program.cs",
                                                      "Main()");
               
            }

        }
        internal class ThreadExceptionHandler
        {
            /// 
            /// Manejador de Excepciones.
            /// 
            public void LanzadorExcepciones(object sender, ThreadExceptionEventArgs e)
            {
                try
                {
                    // Cierra el programa si el usuario presiona Abortar
                    DialogResult result = MostrarMensajeDeError(e.Exception);

                    if (result == DialogResult.Abort)
                        Application.Exit();
                }
                catch (Exception exc)
                {
                    // Error fatal, el programa será cerrado
                    try
                    {
                        Log_Excepciones.CapturadorExcepciones (exc,
                                                              "program.cs",
                                                              "LanzadorExcepciones(object sender, ThreadExceptionEventArgs e)");
                      

                        MessageBox.Show("No se legró recuperar la estabilidad del programa. A continuación el programa será cerrado. \n", "Arca de los Tesoros", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        Application.Exit();
                    }
                }
            }

           
            private DialogResult MostrarMensajeDeError(Exception ex)
            {
                string errorMessage = @"Algo salió mal durante la ejecución, el programa será cerrado.";

                Log_Excepciones.CapturadorExcepciones(ex,
                                                      "program.cs",
                                                      "MostrarMensajeDeError(Exception ex)");


                return MessageBox.Show(errorMessage, 
                                       "Arca de los Tesoros | Error", 
                                       MessageBoxButtons.AbortRetryIgnore,
                                       MessageBoxIcon.Stop);
            }
        }
    }
}
