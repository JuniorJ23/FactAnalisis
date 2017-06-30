using Devart.Data.SQLite;
using DevComponents.DotNetBar;
using FactAnalisis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public class ConexionSQLite
    {
        private SQLiteConnection Connection;

        public ConexionSQLite(string ruta)
        {
            ConnectToDatabase(ruta);
        }

        private void ConnectToDatabase(string ruta)
        {
            try { 
                Connection = new SQLiteConnection("Data Source=" + ruta + ";Version=3;");
                Connection.Open();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Pongase en contacto con el ADMINISTRADOR");
            }
        }


        public void InsertarRegistrosBase(BaseCSV[] basesCSV)
        {
            SQLiteCommand command = new SQLiteCommand("", Connection);

            using (var transaction = Connection.BeginTransaction())
            {
                string SQL = "INSERT INTO tbl_base_facturacion(id, nuanio, nummes, codpeps, codamb, codloc, nomloc, nomusu, codcon, codudu, escone, codmed, codcat, nomcat, codtis, codmof, fleact, fleant, lecact, lecant, diflec, volfact, imcafi, imagua, imalca)" +
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
                    command.Parameters.AddWithValue("@p17", baseCSV.fleact);
                    command.Parameters.AddWithValue("@p18", baseCSV.fleant);
                    command.Parameters.AddWithValue("@p19", baseCSV.lecact);
                    command.Parameters.AddWithValue("@p20", baseCSV.lecant);
                    command.Parameters.AddWithValue("@p21", baseCSV.diflec);
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

            SQLiteCommand command = new SQLiteCommand("", Connection);

            using (var transaction = Connection.BeginTransaction())
            {
                string SQL = "INSERT INTO tbl_notas(codsum, volagua, volalca, nvolagua, nvolalca, imagua, imalca, nimagua, nimalca, ncargo)" +
                   "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
                foreach (NotasCSV notaCSV in notasCSV) { 
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
            string SQL1 = "DELETE FROM tbl_base_facturacion";
            string SQL2 = "DELETE FROM tbl_notas";
            SQLiteCommand command1 = new SQLiteCommand(SQL1, Connection);
            SQLiteCommand command2 = new SQLiteCommand(SQL2, Connection);
            try { 
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public double ObtenerTarifaAgua(int grupo,int categoria, int rango, int periodo)
        {
            double Result = 0;
            string SQL = "SELECT agua FROM tbl_est_tarif WHERE id_grupo = @p1, id_categoria = @p2, id_rang = @p3, id_periodo = @p4";
            SQLiteCommand command = new SQLiteCommand(SQL, Connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                Result = 0;
            }
            else
            {
                try
                {
                    while (reader.Read())
                    {
                        Result = reader.GetDouble("agua");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            reader.Close();
            return Result;
        }

        public double ObtenerTarifaDesague(int grupo, int categoria, int rango, int periodo)
        {
            double Result = 0;
            string SQL = "SELECT alcantarillado FROM tbl_est_tarif WHERE id_grupo = @p1, id_categoria = @p2, id_rang = @p3, id_periodo = @p4";
            SQLiteCommand command = new SQLiteCommand(SQL, Connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                Result = 0;
            }
            else
            {
                try
                {
                    while (reader.Read())
                    {
                        Result = reader.GetDouble("alcantarillado");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            reader.Close();
            return Result;
        }


    }
}
