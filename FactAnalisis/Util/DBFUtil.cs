using Spire.DataExport.DBF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public class DBFUtil
    {


       public static void DataSetIntoDBF(string Path, string fileName, DataSet dataSet)
       //public static void DataSetIntoDBF(string Path, string fileName, DataTable dataTable)
        {
            OleDbConnection con = new OleDbConnection(GetConnection(Path));

            con.Open();

            //Se crea el archivo DBF
            CrearTabla(fileName, Path, con);

            OleDbCommand cmd = new OleDbCommand()
            {
                Connection = con
            };

           // using (var transaction = con.BeginTransaction())
            //{
                string insertSql = "INSERT INTO [" + fileName + "]([codreg],[nuanio],[nummes],[codeps],[codamb],[codloc],[nomloc],[nomusu],[codcon],[codudu],[escone],[codmed],[codcat],[nomcat],[codtis],[codmof],[fleact],[fleant],[lectact],[lecant],[diflec],[volfac],[imcafi],[imagua],[imalca])" +
                " VALUES(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24)";
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = @insertSql;

                    
                    cmd.Parameters.AddWithValue("@p0", row[0].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p1", row[1].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p2", row[2].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p3", row[3].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p4", row[4].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p5", row[5].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p6", row[6].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p7", row[7].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p8", row[8].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p9", row[9].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p10", row[10].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p11", row[11].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p12", row[12].ToString().TrimEnd());
                    cmd.Parameters.AddWithValue("@p13", row[13].ToString().TrimEnd());

                    if (!string.IsNullOrEmpty(row[14].ToString()))
                    {
                        cmd.Parameters.AddWithValue("@p14", row[14].ToString().TrimEnd());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p14", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(row[15].ToString()))
                    {
                        cmd.Parameters.AddWithValue("@p15", row[15].ToString().TrimEnd());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p15", DBNull.Value);
                    }

    
                    if (!string.IsNullOrEmpty(row[16].ToString()))
                    {
                        cmd.Parameters.AddWithValue("@p16", DateTime.Parse(row[16].ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p16", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(row[17].ToString()))
                    {
                        cmd.Parameters.AddWithValue("@p17", DateTime.Parse(row[17].ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@p17", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@p18", row[18]);
                    cmd.Parameters.AddWithValue("@p19", row[19]);
                    cmd.Parameters.AddWithValue("@p20", row[20]);
                    cmd.Parameters.AddWithValue("@p21", row[21]);
                    cmd.Parameters.AddWithValue("@p22", row[22]);
                    cmd.Parameters.AddWithValue("@p23", row[23]);
                    cmd.Parameters.AddWithValue("@p24", row[24]);
                    cmd.ExecuteNonQuery();
                }
                //transaction.Commit();
            //}

               

            con.Close();
        }


        private static void CrearTabla(string fileName, string path, OleDbConnection con)
        {
            ArrayList list = new ArrayList();

            if (File.Exists(Path.Combine(path,fileName.ToUpper() + ".dbf")))
            {
                File.Delete(Path.Combine(path, fileName.ToUpper() + ".dbf"));
            }

            string createSql = "CREATE TABLE [" + fileName + "] (";

            createSql = createSql + "[codreg]" + " Numeric(7,0),";
            createSql = createSql + "[nuanio]" + " Numeric(4,0),";
            createSql = createSql + "[nummes]" + " Numeric(2,0),";
            createSql = createSql + "[codeps]" + " VarChar(3),";
            createSql = createSql + "[codamb]" + " Numeric(2,0),";
            createSql = createSql + "[codloc]" + " VarChar(4),";
            createSql = createSql + "[nomloc]" + " VarChar(20),";
            createSql = createSql + "[nomusu]" + " VarChar(50),";
            createSql = createSql + "[codcon]" + " VarChar(15),";
            createSql = createSql + "[codudu]" + " VarChar(15),";
            createSql = createSql + "[escone]" + " Numeric(1,0),";
            createSql = createSql + "[codmed]" + " VarChar(15),";
            createSql = createSql + "[codcat]" + " VarChar(3),";
            createSql = createSql + "[nomcat]" + " VarChar(15),";
            createSql = createSql + "[codtis]" + " Numeric(1,0),";
            createSql = createSql + "[codmof]" + " VarChar(2),";
            createSql = createSql + "[fleact]" + " DateTime,";
            createSql = createSql + "[fleant]" + " DateTime,";
            createSql = createSql + "[lectact]" + " Numeric(12,2),";
            createSql = createSql + "[lecant]" + " Numeric(12,2),";
            createSql = createSql + "[diflec]" + " Numeric(12,2),";
            createSql = createSql + "[volfac]" + " Numeric(12,2),";
            createSql = createSql + "[imcafi]" + " Numeric(5,2),";
            createSql = createSql + "[imagua]" + " Numeric(12,2),";
            createSql = createSql + "[imalca]" + " Numeric(12,2))";

            //createSql = createSql.Substring(0, createSql.Length - 1) + ")";

           

            OleDbCommand cmd1 = new OleDbCommand()
            {
                Connection = con
            };
          

            cmd1.CommandText = createSql;

            cmd1.ExecuteNonQuery();
        }


        public static void ExportarADBF(string path, string fileName, DataTable dataTable)
        {
            DBFExport DBFExport = new DBFExport();
            DBFExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable;
            DBFExport.DataTable = dataTable;
            DBFExport.ActionAfterExport = Spire.DataExport.Common.ActionType.None;
            DBFExport.FileName = Path.Combine(path, fileName);
            DBFExport.SaveToFile();
        }



        private static string GetConnection(string path)
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;";
        }

        public static string ReplaceEscape(string str)
        {
            str = str.Replace("'", "");
            return str;
        }
    }
}
