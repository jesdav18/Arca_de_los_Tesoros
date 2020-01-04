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
using Core.Clases;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlngresoActividad : UserControl
    {
        public ctlngresoActividad()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Actividad { get; set; }
        public string Pro_Fecha { get; set; }
        public string Pro_Usuario { get; set; }
        public DateTime Pro_FechaActividad { get; set; }

        public event EventHandler OnIngresoActividad;


        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_Actividad, 
                                     string pFecha,
                                     string pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Actividad = pID_Actividad;
            Pro_Fecha = pFecha;
            Pro_Usuario = pUsuario;
            CargarDatosActividad();

            lblEncabezado.Text = "Ingrese información para la actividad del día " + Pro_Fecha;

        }

        private void CargarDatosActividad()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_datos_actividades (
                                                                                          :p_id_actividad
                                                                                        )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;

            try
            {
                PgSqlDataReader pgDR = pgComando.ExecuteReader();
                if (pgDR.Read())
                {
                    txtVersiculo.Text = pgDR.GetString("versiculo");
                    txtClase.Text = pgDR.GetString("clase");
                    memoTema.Text = pgDR.GetString("tema");
                    Pro_FechaActividad = pgDR.GetDateTime("fecha");
                }

                pgDR.Close();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatosActividad");
                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Algo salió mal mientras se obtenian los datos de la actividad!", Utilidades.BotonesDialogo.Ok);

            }
        }


        private void ActualizarRegistrosActividad()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_registros_actividad (
                                                                                                      :p_clase,
                                                                                                      :p_tema,
                                                                                                      :p_versiculo,
                                                                                                      :p_id_actividad,
                                                                                                      :p_usuario
                                                                                                    )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_clase", PgSqlType.VarChar).Value = txtClase.Text;
            pgComando.Parameters.Add("p_tema", PgSqlType.VarChar).Value = memoTema.Text;
            pgComando.Parameters.Add("p_versiculo", PgSqlType.VarChar).Value = txtVersiculo.Text;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;

            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();

                Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Actividad Completada!", Utilidades.BotonesDialogo.Ok);
                OnIngresoActividad?.Invoke(new object(), new EventArgs());

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ActualizarRegistrosActividad");
                Utilidades.MostrarDialogo(FindForm(), "Falla en el ingreso de datos", "¡Algo salió mal mientras se registraban las actividades para el día " + Pro_Fecha + " !", Utilidades.BotonesDialogo.Ok);
              
            }

        }

        private bool ValidarCampos() {

            if (string.IsNullOrEmpty(txtClase.Text))
            {
                MessageBox.Show("¡Por favor Ingrese una Clase!");
                return false;
            }
            else if (string.IsNullOrEmpty(txtVersiculo.Text))
            {
                MessageBox.Show("¡Por favor Ingrese un Versiculo!");
                return false;
            }
            else if (string.IsNullOrEmpty(memoTema.Text))
            {
                MessageBox.Show("¡Por favor Ingrese un Tema!");
                return false;
            }
            else
            {
                return true;
            }
        }

     
        private void CmdGuardarPlanificacion_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ActualizarRegistrosActividad();
            }          
        }

      
    }
}
