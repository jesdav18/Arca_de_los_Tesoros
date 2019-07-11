using System;
using System.IO;

namespace Core.Clases
{
    public static class Log_Excepciones
    {
        public static void CapturadorExcepciones(Exception pExcepcion,
                                         string pNombreControl,
                                         string pNombreFuncion)
        {
            try
            {
                AlmacenaArchivoExcepciones(pExcepcion,
                                           pNombreControl,
                                           pNombreFuncion);
            }
            catch (Exception ex)
            {
                AlmacenaArchivoExcepciones(ex,
                                           "class DepuradorExcepcion",
                                           "CapturadorExcepciones");
            }
        }

        public static void AlmacenaArchivoExcepciones(Exception pExcepcion,
                                               string pNombreControl,
                                               string pNombreFuncion)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!filepath.EndsWith("\\"))
            {
                filepath += "\\";
            }

            filepath += DateTime.Today.ToString("dd-MM-yyyy") + ".txt";
            StreamWriter escritor = File.AppendText(filepath);
            escritor.WriteLine("-------------ARCA DE LOS TESOROS | DEPURACION-------------");
            escritor.WriteLine("Fecha y Hora: " + DateTime.Now.ToString("hh:mm:ss"));
            escritor.WriteLine("Control o Clase: " + pNombreControl);
            escritor.WriteLine("Función donde se generó: " + pNombreFuncion);
            escritor.WriteLine("Mensaje: " + pExcepcion.Message + "..........");
            escritor.WriteLine("Pila de Llamadas: " + pExcepcion.StackTrace);
            escritor.WriteLine("Target Site: " + pExcepcion.TargetSite.Name);
            escritor.WriteLine("Target Site: " + pExcepcion.TargetSite.Name);
            escritor.WriteLine("-------------------------------------------");
            escritor.WriteLine("\n\n");
            escritor.Close();
            escritor.Dispose();
        }
    }
}
