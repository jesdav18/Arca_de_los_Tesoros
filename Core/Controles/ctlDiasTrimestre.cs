﻿using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Data;

namespace Core.Controles
{
    public partial class ctlDiasTrimestre : UserControl
    {
        #region INICIALIZADOR

        public ctlDiasTrimestre()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Usuario { get; set; }
        public string Pro_Anio { get; set; }
        public int Pro_NumeroTrimestre { get; set; }
        public int Pro_ID_Area_Atencion { get; set; }
        public int Pro_ID_Actividad_Generado { get; set; }
        public DateTime Pro_FechaActividad { get; set; }

        #endregion

        #region EVENTOS

        public event EventHandler OnSeleccionaDia;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                      string pUsuario,
                                      string pAnio,
                                      string pDescripcionTrimestre,
                                      int pNumeroTrimestre,
                                      int pID_AreaAtencion)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            Pro_NumeroTrimestre = pNumeroTrimestre;
            Pro_Anio = pAnio;
            Pro_ID_Area_Atencion = pID_AreaAtencion;
            lblTituloEncabezado.Text = pDescripcionTrimestre + " del Año " + pAnio;

            ToggleOrdinarias_Toggled(new object(), new EventArgs());

        }

        private void ObtenerFechasExtraordinarias()
        {
            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_proc_obtener_fechas_extraordinarias ();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            

            try
            {
                TileDias.Controls.Clear();

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                while (pgDr.Read())
                {
                    ctlItemDiaTrabajo v_item_dia = new ctlItemDiaTrabajo();
                    v_item_dia.ConstruirControl(pgDr.GetString("dia"), pgDr.GetString("dia_semana"));
                    v_item_dia.OnSeleccionaDia += v_item_dia_selecciona_dia;

                    TileDias.Controls.Add(v_item_dia);

                    v_item_dia = null;
                }

                pgDr.Close();

                sentencia = null;
                pgComando.Dispose();
                pgComando = null;


            }
            catch (Exception Exc)
            {
                //Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡Algo salió mal en el momento de recuperar fechas extraordinarias!", Utilidades.BotonesDialogo.Ok);                       
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ObtenerFechasExtraordinarias");

            }
        }


        private void ObtenerFechasTrimestre()
        {
           

            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros_conf.ft_view_dias_trimestre(:p_numero_trimestre,
                                                                                        :p_anio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_numero_trimestre", PgSqlType.Int).Value = Pro_NumeroTrimestre;
            pgComando.Parameters.Add("p_anio", PgSqlType.VarChar).Value = Pro_Anio;

            try
            {
                TileDias.Controls.Clear();

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                while (pgDr.Read())
                {
                    ctlItemDiaTrabajo v_item_dia = new ctlItemDiaTrabajo();
                    v_item_dia.ConstruirControl(pgDr.GetString("dia_trimestre"), pgDr.GetString("dia_semana"));
                    v_item_dia.OnSeleccionaDia += v_item_dia_selecciona_dia;

                    TileDias.Controls.Add(v_item_dia);

                    v_item_dia = null;
                }

                pgDr.Close();

                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

              
            }
            catch (Exception Exc)
            {
                //MessageBox.Show("Algo salió mal en el momento de recuperar fecha del trimestre. ","Arca de los Tesoros");
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "ObtenerFechasTrimestre");
              
            }
        }

        private int CreacionActividad(string pFecha,bool pEsOrdinaria = true)
        {
            int v_id_actividad;
            
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();

            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_creacion_actividad (
                                                                                          :p_fecha_actividad,
                                                                                          :p_id_area_atencion,
                                                                                          :p_usuario,
                                                                                          :p_es_ordinaria
                                                                                        )";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_fecha_actividad", PgSqlType.Date).Value = Convert.ToDateTime(pFecha);
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = Pro_ID_Area_Atencion;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_es_ordinaria", PgSqlType.Boolean).Value = pEsOrdinaria;
            try
            {
                v_id_actividad = Convert.ToInt32 (pgComando.ExecuteScalar());

                if (!pEsOrdinaria)
                {
                    Pro_ID_Actividad_Generado = v_id_actividad;
                }

                sentencia = null;
                pgComando.Dispose();

                return v_id_actividad;

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CreacionActividad");
                Utilidades.MostrarDialogo(FindForm(), "Falla en el ingreso de datos", "¡Algo falló mientras se creaba la actividad!", Utilidades.BotonesDialogo.Ok);
               
                return 0;
            }
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
            pgComando.Parameters.Add("p_id_actividad", PgSqlType.Int).Value = Pro_ID_Actividad_Generado;

            try
            {
                PgSqlDataReader pgDR = pgComando.ExecuteReader();
                if (pgDR.Read())
                {
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

        #endregion

        #region EVENTOS CONTROLES

        private void v_item_dia_selecciona_dia(object sender, EventArgs e)
        {
                   
            Pro_ID_Actividad_Generado = CreacionActividad((string)sender);
            CargarDatosActividad();


            if (Pro_ID_Actividad_Generado != 0)
            {
              
                if (Utilidades.ObtenerHoraServidor(Pro_Conexion).Date > Pro_FechaActividad)
                {
                    Utilidades.MostrarDialogo(FindForm(), "Arca de los Tesoros", "¡La fecha de la actividad ya finalizó!", Utilidades.BotonesDialogo.Ok);
                }
                else
                {
                    OnSeleccionaDia?.Invoke(sender, e);
                }

        
            }

        }

        #endregion

        private void CmCrearActividadHoy_Click(object sender, EventArgs e)
        {
            CreacionActividad(Utilidades.ObtenerFechaServidor(Pro_Conexion),false);
            toggleOrdinarias.IsOn = true;
            ToggleOrdinarias_Toggled(new object(), new EventArgs());
        }

        private void ToggleOrdinarias_Toggled(object sender, EventArgs e)
        {
            if (toggleOrdinarias.IsOn)
            {
                ObtenerFechasExtraordinarias();
            }
            else
            {
                ObtenerFechasTrimestre();
            }
        }
    }
}
