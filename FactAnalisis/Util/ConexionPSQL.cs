using DevComponents.DotNetBar;
using FactAnalisis.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;

namespace FactAnalisis.Util
{
    public class ConexionPSQL
    {
        private NpgsqlConnection Connection;
        private Configuracion config;

        public ConexionPSQL()
        {
            MessageBoxEx.EnableGlass = false;

            //Por defecto se carga esta configuracion
            config = Configuracion.Instance;
           
            ConnectToDatabase();
          
        }


        private void ConnectToDatabase()
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};Command Timeout=0;",
                    config.Server, config.Port, config.Username,
                    config.Password, "base_fact");
                Connection = new NpgsqlConnection(connstring);
                Connection.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }



        public List<EstructuraTarifariaModel> ObtenerEstructurasTarifarias(int grupo, int periodo)
        {
            List<EstructuraTarifariaModel> result = new List<EstructuraTarifariaModel>();

            string SQL = "SELECT est.ID, est.id_grupo, est.id_categoria, est.id_rango,est.id_periodo, period.cargo_fijo, est.agua, est.alcantarillado FROM tbl_est_tarif est INNER JOIN tbl_periodo period ON period.\"id\" = est.id_periodo WHERE est.id_grupo =" + grupo + " AND est.id_periodo = " + periodo;
            NpgsqlCommand command = new NpgsqlCommand(SQL, Connection);
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    EstructuraTarifariaModel estructTarif = new EstructuraTarifariaModel()
                    {
                        ID = Int32.Parse(reader[0].ToString()),
                        IDGrupo = Int32.Parse(reader[1].ToString()),
                        IDCategoria = Int32.Parse(reader[2].ToString()),
                        IDRango = Int32.Parse(reader[3].ToString()),
                        IDPeriodo = Int32.Parse(reader[4].ToString()),
                        CargoFijo = Double.Parse(reader[5].ToString()),
                        Agua = Double.Parse(reader[6].ToString()),
                        Alcantarillado = Double.Parse(reader[7].ToString())
                    };
                    result.Add(estructTarif);
                }
            }

            return result;
        }

        public Periodo ObtenerUltimoPeriodo()
        {
            Periodo periodo = new Periodo();
            string SQL = "select * from tbl_periodo where id = (select max(id) from tbl_periodo)";
            NpgsqlCommand command = new NpgsqlCommand(SQL, Connection);
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    periodo.ID = Int32.Parse(reader[0].ToString());
                    periodo.Desc = reader[1].ToString();
                    periodo.CargoFijo = Double.Parse(reader[2].ToString());
                }
            }
            return periodo;
        }


        public List<Periodo> ObtenerTodosPeriodos()
        {
            List<Periodo> result = new List<Periodo>();
            string SQL = "select * from tbl_periodo";
            NpgsqlCommand command = new NpgsqlCommand(SQL, Connection);
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Periodo periodo = new Periodo()
                    {
                        ID = Int32.Parse(reader[0].ToString()),
                        Desc = reader[1].ToString(),
                        CargoFijo = Double.Parse(reader[2].ToString())
                    };
                    result.Add(periodo);
                }
            }
            return result;
        }


        public void InsertarRegistrosEnBaseFacturacion(BaseCSV[] basesCSV)
        {
            NpgsqlCommand command = new NpgsqlCommand("", Connection);
            using (var transaction = Connection.BeginTransaction())
            {
                string SQL = "INSERT INTO tbl_base_fact(id, nuanio, nummes, codpeps, codamb, codloc, nomloc, nomusu, codcon, codudu, escone, codmed, codcat, nomcat, codtis, codmof, fleact, fleant, lecact, lecant, diflec, volfact, imcafi, imagua, imalca)" +
               "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25)";

                foreach (BaseCSV baseCSV in basesCSV)
                {
                    command.Parameters.Clear();
                    command.CommandText = SQL;

                    command.Parameters.AddWithValue("@p1", baseCSV.codreg);
                    command.Parameters.AddWithValue("@p2", baseCSV.nuanio);
                    command.Parameters.AddWithValue("@p3", baseCSV.nummes);
                    command.Parameters.AddWithValue("@p4", baseCSV.codeps);
                    command.Parameters.AddWithValue("@p5", baseCSV.codamb);
                    command.Parameters.AddWithValue("@p6", baseCSV.codloc);
                    command.Parameters.AddWithValue("@p7", baseCSV.nomloc);
                    command.Parameters.AddWithValue("@p8", baseCSV.nomusu);
                    command.Parameters.AddWithValue("@p9", baseCSV.codcon);
                    command.Parameters.AddWithValue("@p10", baseCSV.codudu);
                    command.Parameters.AddWithValue("@p11", baseCSV.escone);
                    command.Parameters.AddWithValue("@p12", baseCSV.codmed);
                    command.Parameters.AddWithValue("@p13", baseCSV.codcat);
                    command.Parameters.AddWithValue("@p14", baseCSV.nomcat);
                    command.Parameters.AddWithValue("@p15", baseCSV.codtis);
                    command.Parameters.AddWithValue("@p16", baseCSV.codmof);
                    if(baseCSV.fleact == null)
                    {
                        command.Parameters.AddWithValue("@p17", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p17", baseCSV.fleact);
                    }
                    if (baseCSV.fleant == null)
                    {
                        command.Parameters.AddWithValue("@p18", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p18", baseCSV.fleant);
                    }

                    if (baseCSV.lecact == null)
                    {
                        command.Parameters.AddWithValue("@p19", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p19", baseCSV.lecact);
                    }

                    if (baseCSV.lecant == null)
                    {
                        command.Parameters.AddWithValue("@p20", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p20", baseCSV.lecant);
                    }

                    if (baseCSV.diflec == null)
                    {
                        command.Parameters.AddWithValue("@p21", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p21", baseCSV.diflec);
                    }

                    command.Parameters.AddWithValue("@p22", baseCSV.volfac);
                    command.Parameters.AddWithValue("@p23", baseCSV.imcafi);

                    command.Parameters.AddWithValue("@p24", baseCSV.imagua);
                    command.Parameters.AddWithValue("@p25", baseCSV.imalca);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                transaction.Commit();
            }
        }

        public void InsertarRegistrosNotas(NotasCSV[] notasCSV)
        {

            NpgsqlCommand command = new NpgsqlCommand("", Connection);

            using (var transaction = Connection.BeginTransaction())
            {
                string SQL = "INSERT INTO tbl_notas(codsum, volagua, volalca, nvolagua, nvolalca, imagua, imalca, nimagua, nimalca, ncargo)" +
                   "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
                foreach (NotasCSV notaCSV in notasCSV)
                {
                    command.Parameters.Clear();
                    command.CommandText = SQL;
                    command.Parameters.AddWithValue("@p1", notaCSV.num_inscripcion);
                    command.Parameters.AddWithValue("@p2", notaCSV.volumen_agua_facturado);
                    command.Parameters.AddWithValue("@p3", notaCSV.volumen_desague_facturado);
                    command.Parameters.AddWithValue("@p4", notaCSV.volumen_agua_nota);
                    command.Parameters.AddWithValue("@p5", notaCSV.volumen_desague_nota);
                    command.Parameters.AddWithValue("@p6", notaCSV.importe_agua_facturado);
                    command.Parameters.AddWithValue("@p7", notaCSV.importe_desague_facturado);
                    command.Parameters.AddWithValue("@p8", notaCSV.importe_cuenta_agua_nota);
                    command.Parameters.AddWithValue("@p9", notaCSV.importe_cuenta_desague_nota);
                    command.Parameters.AddWithValue("@p10", notaCSV.importe_cuenta_cargo_fijo_nota);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }

                transaction.Commit();
            }


        }

        public void LimpiarTablasBaseYNotas()
        {
            string SQL1 = "TRUNCATE TABLE tbl_base_fact";
            string SQL2 = "TRUNCATE TABLE tbl_notas";
            NpgsqlCommand command1 = new NpgsqlCommand(SQL1, Connection);
            NpgsqlCommand command2 = new NpgsqlCommand(SQL2, Connection);
            try
            {
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public void GenerarFacturacionNeta()
        {
            string functionName = "fnc_analisis";
            NpgsqlCommand command = new NpgsqlCommand(functionName, Connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            command.Parameters.Add(new NpgsqlParameter());
            command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Varchar;
            command.Parameters[0].Value = "tbl_base_fact";

            command.Parameters.Add(new NpgsqlParameter());
            command.Parameters[1].NpgsqlDbType = NpgsqlDbType.Integer;
            command.Parameters[1].Value = 3;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public void NormalizarSegunSUNASS()
        {
            string functionName = "fnc_normalizar";
            NpgsqlCommand command = new NpgsqlCommand(functionName, Connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void InsertarNotas()
        {
            string notasVolumen = "UPDATE tbl_base_fact SET nvol = CASE WHEN(codtis = '1') THEN CASE WHEN num_unidades = 1 THEN notas.nvolagua ELSE notas.nvolagua / num_unidades END WHEN codtis = '3' THEN CASE WHEN num_unidades = 1 THEN notas.nvolalca ELSE notas.nvolalca / num_unidades END WHEN codtis = '2' THEN CASE WHEN num_unidades = 1 THEN notas.nvolagua ELSE notas.nvolagua / num_unidades END END FROM tbl_notas notas WHERE notas.codsum = codcon";
            string notasSoles = "UPDATE tbl_base_fact SET nimagua = CASE WHEN num_unidades = 1 THEN notas.nimagua ELSE notas.nimagua / num_unidades END, nimalca = CASE WHEN num_unidades = 1 THEN notas.nimalca ELSE notas.nimalca / num_unidades END, ncargo = notas.ncargo FROM tbl_notas notas WHERE notas.codsum = codcon";
            string normalizarColumnaNimagua = "UPDATE tbl_base_fact SET nimagua = 0 where nimagua is null";
            string normalizarColumnaNimalca = "UPDATE tbl_base_fact SET nimalca = 0 where nimalca is null";
            string normalizarColumnaNCargo = "UPDATE tbl_base_fact SET ncargo = 0 where ncargo is null";
            string unirParaNeta = "UPDATE tbl_base_fact SET imagua = imagua + nimagua, imalca = imalca+nimalca, imcafi = imcafi + ncargo";
            NpgsqlCommand command1 = new NpgsqlCommand(notasVolumen, Connection);
            NpgsqlCommand command2 = new NpgsqlCommand(notasSoles, Connection);
            NpgsqlCommand command3 = new NpgsqlCommand(normalizarColumnaNimagua, Connection);
            NpgsqlCommand command4 = new NpgsqlCommand(normalizarColumnaNimalca, Connection);
            NpgsqlCommand command5 = new NpgsqlCommand(normalizarColumnaNCargo, Connection);
            NpgsqlCommand command6 = new NpgsqlCommand(unirParaNeta, Connection);
            try
            {
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                command6.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GenerarDesanalisis()
        {
            string functionName = "fnc_desanalisis";
            NpgsqlCommand command = new NpgsqlCommand(functionName, Connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            command.Parameters.Add(new NpgsqlParameter());
            command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Varchar;
            command.Parameters[0].Value = "tbl_base_fact";

            command.Parameters.Add(new NpgsqlParameter());
            command.Parameters[1].NpgsqlDbType = NpgsqlDbType.Integer;
            command.Parameters[1].Value = 3;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ObtenerBaseCompleta()
        {
            string query = "SELECT * FROM tbl_base_fact";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public DataTable ObtenerSinCodigosDeUnidadDeUso()
        {
            string query = "SELECT * FROM tbl_base_fact WHERE codudu is null";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }


        public DataTable ObtenerServicioAguaActivoYConImportesAlcantarillado()
        {
            string query = "SELECT * FROM tbl_base_fact WHERE escone = '1' and codtis = '2' and imalca > 0 ";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirServicioAguaActivoYConImportesAlcantarillado()
        {
            string sql = "UPDATE tbl_base_fact SET codtis = '1' WHERE escone = '1' and codtis = '2' and imalca > 0";
            NpgsqlCommand command1 = new NpgsqlCommand(sql, Connection);
            try
            {
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable ObtenerServicioAlcantarilladoActivoYConImportesAgua()
        {
            string query = "SELECT * FROM tbl_base_fact WHERE escone = '1' and codtis = '3' and imagua > 0";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirServicioAlcantarilladoActivoYConImportesAgua()
        {
            string sql = "UPDATE tbl_base_fact SET codtis = '1' WHERE escone = '1' and codtis = '3' and imagua > 0";
            NpgsqlCommand command1 = new NpgsqlCommand(sql, Connection);
            try
            {
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable ObtenerActivosConImportes0PorRebajaYConVolumen()
        {
            string query = "SELECT * FROM tbl_base_fact WHERE escone = '1' AND imagua + imalca = 0 and volfact > 0;";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirActivosConImportes0PorRebajaYConVolumen()
        {
            string sql = "UPDATE tbl_base_fact SET volfact = 0 WHERE escone = '1' AND imagua + imalca = 0 and volfact > 0";
            NpgsqlCommand command1 = new NpgsqlCommand(sql, Connection);
            try
            {
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable ObtenerCortadosConImportes()
        {
            string query = "SELECT * FROM tbl_base_fact WHERE escone = '2' AND imagua + imalca > 0";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirCortadosConImportes()
        {
            string sql = "UPDATE tbl_base_fact SET escone = '1' WHERE escone = '2' AND imagua + imalca > 0";
            NpgsqlCommand command1 = new NpgsqlCommand(sql, Connection);
            try
            {
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ObtenerUsuariosConImportesYSinVolumen()
        {
            string query = "SELECT * FROM tbl_base_fact WHERE escone = '1'  AND imalca + imagua > 0 AND volfact = 0;";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirUsuariosConImportesYSinVolumen()
        {
            string sql = "UPDATE tbl_base_fact SET volagua = 0 WHERE volagua is null;";
            string sql3 = "UPDATE tbl_base_fact SET volalca = 0 WHERE volalca is null;";
            string sql0 = "update tbl_base_fact set codtis = (CASE when imagua > 0 and imalca > 0 then 1 when imagua > 0 and imalca = 0 then 2 when imagua = 0 and imalca > 0 then 3 when imagua = 0 and imalca = 0 then 1 end)";
            string sql1 = "UPDATE tbl_base_fact SET volfact = volagua WHERE codtis = '1' OR codtis = '2' and escone = '1'  AND imalca + imagua > 0 AND volfact = 0;";
            string sql2= "UPDATE tbl_base_fact SET volfact = volalca WHERE codtis = '3' and escone = '1'  AND imalca + imagua > 0 AND volfact = 0;";
            string sql4 = "UPDATE tbl_base_fact SET volfact = volalca WHERE codtis = '1' and escone = '1'  AND imalca + imagua > 0 AND volagua = 0;";

            NpgsqlCommand command = new NpgsqlCommand(sql, Connection);
            NpgsqlCommand command3 = new NpgsqlCommand(sql3, Connection);
            NpgsqlCommand command0 = new NpgsqlCommand(sql0, Connection);
            NpgsqlCommand command1 = new NpgsqlCommand(sql1, Connection);
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, Connection);
            NpgsqlCommand command4 = new NpgsqlCommand(sql4, Connection);

            try
            {
                command0.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LimpiarNotasYVolumen()
        {
            string sql = "UPDATE tbl_base_fact SET nimagua = 0, nimalca = 0;";
            string sql2 = "UPDATE tbl_base_fact SET volfact = 0 WHERE volfact IS NULL;";
            NpgsqlCommand command = new NpgsqlCommand(sql, Connection);
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, Connection);
            try
            {
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CorregirDomestica2ElAlto()
        {
            string sql = "UPDATE tbl_base_fact SET nomcat ='DOMESTICA 1' WHERE nomloc LIKE '%EL ALTO%'";
            NpgsqlCommand command = new NpgsqlCommand(sql, Connection);
            try
            {
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable ObtenerUsuariosConVolumenYSinImportes()
        {
            string query = "select * from tbl_base_fact WHERE escone = '1' and volfact > 0 and imagua + imalca = 0;";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirUsuariosConVolumenYSinImportes()
        {
            string sql1 = "UPDATE tbl_base_fact SET imagua = imagua_nuevo WHERE codtis = '1' OR codtis = '2' and escone = '1' and volfact > 0 and imagua + imalca = 0;";
            string sql2 = "UPDATE tbl_base_fact SET imalca = imalca_nuevo WHERE codtis = '3' and escone = '1' and volfact > 0 and imagua + imalca = 0;";
           
            NpgsqlCommand command = new NpgsqlCommand(sql1, Connection);
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, Connection);
            try
            {
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable ObtenerUsuariosActivosSinVolumenYSinImportes()
        {
            string query = "select * FROM tbl_base_fact WHERE escone = '1' and volfact = 0 and imagua + imalca + imcafi = 0;";
            NpgsqlCommand command = new NpgsqlCommand(query, Connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void CorregirObtenerUsuariosActivosSinVolumenYSinImportes()
        {
            string sql1 = "UPDATE tbl_base_fact SET escone = '2' WHERE escone = '1' and volfact = 0 and imagua + imalca + imcafi = 0;";
            

            NpgsqlCommand command = new NpgsqlCommand(sql1, Connection);
           
            try
            {
                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
