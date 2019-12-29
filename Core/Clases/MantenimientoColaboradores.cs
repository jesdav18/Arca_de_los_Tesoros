using Devart.Data.PostgreSql;
using System;
using System.Windows.Forms;


namespace Core.Clases
{
    public static class MantenimientoColaboradores
    {
       

        public static bool ActualizarFechaCobertura(PgSqlConnection pConexion,
                                                   int pCodigoColaborador,
                                                   DateTime pFechaCobertura)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_cobertura(:pCodigoColaborador, 
                                                                                               :pFechaCobertura);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pFechaCobertura", PgSqlType.TimeStamp).Value = pFechaCobertura;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la fecha de cobertura. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarFechaConversion(PgSqlConnection pConexion,
                                                     int pCodigoColaborador,
                                                     DateTime pFechaConversion)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_conversion(:pCodigoColaborador, 
                                                                                               :pFechaConversion);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pFechaConversion", PgSqlType.TimeStamp).Value = pFechaConversion;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la Fecha de Conversión. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }


        public static bool ActualizarFechaIngresoIglesia(PgSqlConnection pConexion, int pCodigoColaborador, DateTime pFechaIngreso)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_ingreso_iglesia(:pCodigoColaborador, 
                                                                                                     :pFechaIngreso);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pFechaIngreso", PgSqlType.TimeStamp).Value = pFechaIngreso;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la Fecha de Ingreso. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarFechaReconciliacion(PgSqlConnection pConexion, int pCodigoColaborador, DateTime pFechaReconciliacion)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_reconciliacion(:pCodigoColaborador, 
                                                                                                     :pFechaReconciliacion);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pFechaReconciliacion", PgSqlType.TimeStamp).Value = pFechaReconciliacion;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la Fecha de Reconciliación. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarFechaBautismoAgua(PgSqlConnection pConexion, int pCodigoColaborador, DateTime pFechaBautismoAgua)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_bautismo_agua(:pCodigoColaborador, 
                                                                                                   :pFechaBautismoAgua);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pFechaBautismoAgua", PgSqlType.TimeStamp).Value = pFechaBautismoAgua
                ;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la Fecha Bautismo de Agua. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarFechaInicioPrivilegio(PgSqlConnection pConexion, int pCodigoColaborador, DateTime pFechaInicioPrivilegio)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_inicio_privilegio(:pCodigoColaborador, 
                                                                                                       :pFechaInicioPrivilegio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pFechaInicioPrivilegio", PgSqlType.TimeStamp).Value = pFechaInicioPrivilegio
                ;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la Fecha de Inicio Privilegio. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarFechaNacimiento(PgSqlConnection pConexion, int pCodigoColaborador, DateTime pFechaNacimiento)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_fecha_nacimiento (
                                                                                                    :p_id_colaborador,
                                                                                                    :p_fecha_nacimiento
                                                                                                );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_fecha_nacimiento", PgSqlType.TimeStamp).Value = pFechaNacimiento;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en la Fecha de Nacimiento. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }


        public static bool ActualizarBautismoEspiritu(PgSqlConnection pConexion, int pCodigoColaborador, bool pBautismoEspiritu)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_bautismo_espiritu(:pCodigoColaborador, 
                                                                                                 :pBautismoEspiritu);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pBautismoEspiritu", PgSqlType.Boolean).Value = pBautismoEspiritu;
            ;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en indicador Bautismo Espiritú. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarEquipoArcaTesoros(PgSqlConnection pConexion, int pCodigoColaborador, string pEquipoArcaTesoros)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_equipo_arca_tesoros(:pCodigoColaborador, 
                                                                                                   :pEquipoArcaTesoros);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pEquipoArcaTesoros", PgSqlType.VarChar).Value = pEquipoArcaTesoros;
            ;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en el Equipo Arca Tesoros. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }


        public static bool ActualizarOtrosEquiposPrivilegio(PgSqlConnection pConexion, int pCodigoColaborador, string pOtrosEquipos)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_otros_equipos_privilegio(:pCodigoColaborador, 
                                                                                                        :pOtrosEquipos);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pOtrosEquipos", PgSqlType.VarChar).Value = pOtrosEquipos
                ;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarEstatusDoctrinal(PgSqlConnection pConexion, int pCodigoColaborador, int pEstatusDoctrinal)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_estatus_doctrinal(:pCodigoColaborador, 
                                                                                                   :pEstatusDoctrinal);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pEstatusDoctrinal", PgSqlType.Int).Value = pEstatusDoctrinal;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios en el Estatus Doctrinal. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarEmpresaColaborador(PgSqlConnection pConexion, int pCodigoColaborador, int pID_Empresa, string pCargo)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_empresa_colaborador(:pCodigoColaborador, 
                                                                                                   :pID_Empresa,
                                                                                                   :pCargoColaborador);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pID_Empresa", PgSqlType.Int).Value = pID_Empresa;
            pgComando.Parameters.Add("pCargoColaborador", PgSqlType.VarChar).Value = pCargo;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarTelefonoEmpresa(PgSqlConnection pConexion, int pCodigoColaborador, string pTelefonoEmpresa)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_telefono_empresa(:pCodigoColaborador, 
                                                                                                   :pTelefonoEmpresa);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pTelefonoEmpresa", PgSqlType.VarChar).Value = pTelefonoEmpresa;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarEstadoProfesional(PgSqlConnection pConexion, int pCodigoColaborador, string pEstadoProfesional)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_estado_profesional(:pCodigoColaborador, 
                                                                                                   :pEstadoProfesional);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pEstadoProfesional", PgSqlType.VarChar).Value = pEstadoProfesional;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarNivelEducativo(PgSqlConnection pConexion, int pCodigoColaborador, string pNivelEducativo)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_nivel_educativo(:pCodigoColaborador, 
                                                                                               :pNivelEducativo);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("pCodigoColaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("pNivelEducativo", PgSqlType.VarChar).Value = pNivelEducativo;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarInsertarCargoColaborador(PgSqlConnection pConexion, int pCodigoColaborador, int pID_Cargo, string pUsuario)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_insert_cargo_colaborador (
                                                                                                          :p_id_colaborador ,
                                                                                                          :p_id_cargo ,
                                                                                                          :p_usuario 
                                                                                                        );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_id_cargo", PgSqlType.Int).Value = pID_Cargo;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = pUsuario;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizarEdadAreaAtencion(PgSqlConnection pConexion, int pCodigoColaborador, int pID_Cargo, string pUsuario, int pID_AreaAtencion)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_edad_area_atencion (
                                                                                                  :p_id_colaborador,
                                                                                                  :p_id_area_atencion,
                                                                                                  :p_id_cargo,
                                                                                                  :p_usuario
                                                                                                )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_id_area_atencion", PgSqlType.Int).Value = pID_AreaAtencion;
            pgComando.Parameters.Add("p_id_cargo", PgSqlType.Int).Value = pID_Cargo;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = pUsuario;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool CrearUsuarioColaborador(PgSqlConnection pConexion, int pCodigoColaborador, int pRolUsuario, string pUsuario)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_proc_creacion_usuarios (
                                                                                          :p_id_colaborador,
                                                                                          :p_usuario,
                                                                                          :p_rol_usuario
                                                                                        )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = pUsuario;
            pgComando.Parameters.Add("p_rol_usuario", PgSqlType.Int).Value = pRolUsuario;


            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizaCelularColaborador(PgSqlConnection pConexion, int pCodigoColaborador, string pCelular)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_celular (
                                                                                      :p_id_colaborador,
                                                                                      :p_celular
                                                                                    )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_celular", PgSqlType.VarChar).Value = pCelular;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizaCorreoElectronicoColaborador(PgSqlConnection pConexion, int pCodigoColaborador, string pCorreoElectronico)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_correo_electronico (
                                                                                                      :p_id_colaborador,
                                                                                                      :p_correo_electronico
                                                                                                    )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_correo_electronico", PgSqlType.VarChar).Value = pCorreoElectronico;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());
                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizaEstadoCivilColaborador(PgSqlConnection pConexion, int pCodigoColaborador, int pEstadoCivil)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_estado_civil (
                                                                                              :p_id_colaborador,
                                                                                              :p_estado_civil
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_estado_civil", PgSqlType.Int).Value = pEstadoCivil;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());

                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizaNumeroIdentidad(PgSqlConnection pConexion, int pCodigoColaborador, string pNumeroIdentidad)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_numero_identidad (
                                                                                                  :p_id_colaborador,
                                                                                                  :p_numero_identidad
                                                                                                )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_numero_identidad", PgSqlType.VarChar).Value = pNumeroIdentidad;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());

                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizaPaisNacimientoColaborador(PgSqlConnection pConexion, int pCodigoColaborador, int pID_Pais)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_pais_nacimiento (
                                                                                                :p_id_colaborador,
                                                                                                :p_id_pais
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_id_pais", PgSqlType.Int).Value = pID_Pais;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());

                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }

        public static bool ActualizaTipoSangre(PgSqlConnection pConexion, int pCodigoColaborador, int pTipoSangre)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualiza_tipo_sangre (
                                                                                              :p_id_colaborador,
                                                                                              :p_id_tipo_sangre
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_id_tipo_sangre", PgSqlType.Int).Value = pTipoSangre;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());

                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }


        public static bool ActualizaNecesitaTransporteColaborador(PgSqlConnection pConexion, int pCodigoColaborador, bool pNecesitaTransporte)
        {
            bool v_resultado = false;

            string sentencia = @"SELECT * FROM arca_tesoros.ft_mant_actualizar_necesita_transporte (
                                                                                                      :p_id_colaborador ,
                                                                                                      :p_necesita_transporte 
                                                                                                    )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = pCodigoColaborador;
            pgComando.Parameters.Add("p_necesita_transporte", PgSqlType.Boolean).Value = pNecesitaTransporte;

            try
            {
                v_resultado = Convert.ToBoolean(pgComando.ExecuteScalar());

                if (!v_resultado)
                {
                    MessageBox.Show("No se guardaron los cambios. Por favor intente nuevamente.");
                    return v_resultado;
                }

                return v_resultado;

            }
            catch (Exception Exc)
            {
                return v_resultado;
            }
        }


    }
}
