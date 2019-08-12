﻿using System;
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

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_Actividad, 
                                     string pFecha)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Actividad = pID_Actividad;
            Pro_Fecha = pFecha;

            lblEncabezado.Text = "Ingrese actividades para el día " + Pro_Fecha;

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
                                                                                                      :p_id_actividad
                                                                                                    )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_clase", PgSqlType.VarChar).Value = txtClase.Text;
            pgComando.Parameters.Add("p_tema", PgSqlType.VarChar).Value = memoTema.Text;
            pgComando.Parameters.Add("p_versiculo", PgSqlType.VarChar).Value = txtVersiculo.Text;
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad;


            try
            {
                pgComando.ExecuteNonQuery();
                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ActualizarRegistrosActividad");
                MessageBox.Show("Algo salió mal mientras se registraban las actividades para el día ." + Pro_Fecha,"Arca de los Tesoros");
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
