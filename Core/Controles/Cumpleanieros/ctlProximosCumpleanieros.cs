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
using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Core.Controles.Cumpleanieros
{
    public partial class ctlProximosCumpleanieros : UserControl
    {
        public ctlProximosCumpleanieros()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }

        public UserCredential Pro_Credenciales { get; set; }

        string v_ruta_fotografia = "";
        static string[] Scopes = { DriveService.Scope.Drive };

        public void ConstruirControl(PgSqlConnection pConexion)
        {

            Pro_Conexion = pConexion;

            CargarTarjetasCumpleanieros();
        }

        private void CargarTarjetasCumpleanieros()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_proximos_cumpleanieros();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {

                tileProximosCumpleanieros.Controls.Clear();
                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                while (pgDr.Read())
                {
                    ctlTarjetaCumpleaniero v_tarjeta = new ctlTarjetaCumpleaniero();
                    v_tarjeta.lblNombreColaborador.Text = pgDr.GetString("nombre_colaborador");
                    v_tarjeta.lblEdadColaborador.Text = pgDr.GetString("anios");
                    v_tarjeta.lblEquipo.Text = pgDr.GetString("equipo");

                    if (!string.IsNullOrEmpty(pgDr.GetString("ruta_fotografia")))
                    {
                        v_ruta_fotografia = pgDr.GetString("ruta_fotografia");
                        CargarFotografiaColaborador();

                        var bmp = new Bitmap(v_ruta_fotografia + ".jpg");
                        v_tarjeta.picImagenColaborador.Image = (Bitmap)bmp.Clone();
                    }

                    tileProximosCumpleanieros.Controls.Add(v_tarjeta);
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {

             
            }
        }

        private void CargarFotografiaColaborador()
        {
            if (!File.Exists(v_ruta_fotografia + ".jpg"))
            {
                PrepararDescarga();
            }
        }

        private static void DescargarImagen(Google.Apis.Drive.v3.DriveService pServicio, string pArchivo)
        {
            var v_request = pServicio.Files.Get(pArchivo);
            var v_stream = new System.IO.MemoryStream();


            v_request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case Google.Apis.Download.DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            {
                                Console.WriteLine("Download complete.");

                                GuardarStreaming(v_stream, pArchivo + ".jpg");
                                break;
                            }
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            break;
                        }
                }
            };

            v_request.Download(v_stream);

        }

        private static void GuardarStreaming(System.IO.MemoryStream pStream, string pGuardarA)
        {
            if (!File.Exists(pGuardarA))
            {
                using (System.IO.FileStream file = new System.IO.FileStream(pGuardarA, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    pStream.WriteTo(file);

                }
            }
        }


        private void PrepararDescarga()
        {
            Pro_Credenciales = GetCredentials();

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = Pro_Credenciales,
                ApplicationName = "Carga_GoogleDrive",
            });

            DescargarImagen(service, v_ruta_fotografia);

            string pageToken = null;

            do
            {
                ListFiles(service, ref pageToken);
                if (!string.IsNullOrEmpty(v_ruta_fotografia))
                {
                    pageToken = null;
                }

            } while (pageToken != null);


            pageToken = null;
            service = null;

        }

        private static void ListFiles(DriveService service, ref string pageToken)
        {

            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 1;

            listRequest.Fields = "nextPageToken, files(name)";
            listRequest.PageToken = pageToken;
            listRequest.Q = "mimeType='image/jpeg'";


            var request = listRequest.Execute();


            if (request.Files != null && request.Files.Count > 0)
            {

                pageToken = request.NextPageToken;

                if (request.NextPageToken != null)
                {

                }
            }
        }

        private static UserCredential GetCredentials()
        {
            UserCredential credential;

            using (var stream = new FileStream(@"C:\credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = @"C:\";

                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

            }

            return credential;
        }

    }
}
