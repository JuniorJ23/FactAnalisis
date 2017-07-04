using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public class CalculoImportes
    {
        private static Configuracion config = Configuracion.Instance;

        public static double CalcularImporteAguaComercialIndustrial(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {

            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaAgua(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_50 * volumen;
            }
            else
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaAgua(grupo, categoria, 8, periodo);
                double tarifa_50_a_150 = conex.ObtenerTarifaAgua(grupo, categoria, 9, periodo);
                double tarifa_150_a_mas = conex.ObtenerTarifaAgua(grupo, categoria, 10, periodo);

                if (volumen <= 50)
                {
                    importe = tarifa_0_a_50 * volumen;
                }
                else
                {
                    if(volumen <= 150)
                    {
                        importe = 50 * tarifa_0_a_50 + (volumen - 50) * tarifa_50_a_150;
                    }
                    else
                    {
                        importe = 150 * tarifa_50_a_150 + (volumen - 150) * tarifa_150_a_mas;
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAlcantarilladoComercialIndustrial(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {

            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaDesague(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_50 * volumen;
            }
            else
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaDesague(grupo, categoria, 8, periodo);
                double tarifa_50_a_150 = conex.ObtenerTarifaDesague(grupo, categoria, 9, periodo);
                double tarifa_150_a_mas = conex.ObtenerTarifaDesague(grupo, categoria, 10, periodo);

                if (volumen <= 50)
                {
                    importe = tarifa_0_a_50 * volumen;
                }
                else
                {
                    if (volumen <= 150)
                    {
                        importe = 50 * tarifa_0_a_50 + (volumen - 50) * tarifa_50_a_150;
                    }
                    else
                    {
                        importe = 150 * tarifa_50_a_150 + (volumen - 150) * tarifa_150_a_mas;
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }


        public static double CalcularImporteAguaDomestica1(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {

            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaAgua(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_8 * volumen;
            }
            else
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaAgua(grupo, categoria, 3, periodo);
                double tarifa_8_a_25 = conex.ObtenerTarifaAgua(grupo, categoria, 4, periodo);
                double tarifa_25_a_mas = conex.ObtenerTarifaAgua(grupo, categoria, 6, periodo);

                if (volumen <= 8)
                {
                    importe = tarifa_0_a_8 * volumen;
                }
                else
                {
                    if (volumen <= 25)
                    {
                        importe = 8 * tarifa_0_a_8 + (volumen - 8) * tarifa_8_a_25;
                    }
                    else
                    {
                        importe = 8 * tarifa_0_a_8 + 17 * tarifa_8_a_25 + (volumen - 25) * tarifa_25_a_mas;
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }


        public static double CalcularImporteAlcantarilladoDomestica1(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {


            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaDesague(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_8 * volumen;
            }
            else
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaDesague(grupo, categoria, 3, periodo);
                double tarifa_8_a_25 = conex.ObtenerTarifaDesague(grupo, categoria, 4, periodo);
                double tarifa_25_a_mas = conex.ObtenerTarifaDesague(grupo, categoria, 6, periodo);

                if (volumen <= 8)
                {
                    importe = tarifa_0_a_8 * volumen;
                }
                else
                {
                    if (volumen <= 25)
                    {
                        importe = 8 * tarifa_0_a_8 + (volumen - 8) * tarifa_8_a_25;
                    }
                    else
                    {
                        importe = 8 * tarifa_0_a_8 + 17 * tarifa_8_a_25 + (volumen - 25) * tarifa_25_a_mas;
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }


        public static double CalcularImporteAguaDomestica2(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {


            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaAgua(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_8 * volumen;
            }
            else
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaAgua(grupo, categoria, 3, periodo);
                double tarifa_8_a_25 = conex.ObtenerTarifaAgua(grupo, categoria, 4, periodo);
                double tarifa_25_a_100 = conex.ObtenerTarifaAgua(grupo, categoria, 5, periodo);
                double tarifa_100_a_mas = conex.ObtenerTarifaAgua(grupo, categoria, 7, periodo);

                if (volumen <= 8)
                {
                    importe = tarifa_0_a_8 * volumen;
                }
                else
                {
                    if (volumen <= 25)
                    {
                        importe = 8 * tarifa_0_a_8 + (volumen - 8) * tarifa_8_a_25;
                    }
                    else
                    {
                        if(volumen <= 100)
                        {
                            importe = 8 * tarifa_0_a_8 + 17 * tarifa_8_a_25 + (volumen - 25) * tarifa_25_a_100;
                        }
                        else
                        {
                            importe = 8 * tarifa_0_a_8 + 17 * tarifa_8_a_25 + 75 * tarifa_25_a_100 + (volumen - 100) * tarifa_100_a_mas;
                        }
                        
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAlcantarilladoDomestica2(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {

            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaDesague(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_8 * volumen;
            }
            else
            {
                double tarifa_0_a_8 = conex.ObtenerTarifaDesague(grupo, categoria, 3, periodo);
                double tarifa_8_a_25 = conex.ObtenerTarifaDesague(grupo, categoria, 4, periodo);
                double tarifa_25_a_100 = conex.ObtenerTarifaDesague(grupo, categoria, 5, periodo);
                double tarifa_100_a_mas = conex.ObtenerTarifaDesague(grupo, categoria, 7, periodo);

                if (volumen <= 8)
                {
                    importe = tarifa_0_a_8 * volumen;
                }
                else
                {
                    if (volumen <= 25)
                    {
                        importe = 8 * tarifa_0_a_8 + (volumen - 8) * tarifa_8_a_25;
                    }
                    else
                    {
                        if (volumen <= 100)
                        {
                            importe = 8 * tarifa_0_a_8 + 17 * tarifa_8_a_25 + (volumen - 25) * tarifa_25_a_100;
                        }
                        else
                        {
                            importe = 8 * tarifa_0_a_8 + 17 * tarifa_8_a_25 + 75 * tarifa_25_a_100 + (volumen - 100) * tarifa_100_a_mas;
                        }

                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAguaEstatal(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {


            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaAgua(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_50 * volumen;
            }
            else
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaAgua(grupo, categoria, 8, periodo);
                double tarifa_50_a_150 = conex.ObtenerTarifaAgua(grupo, categoria, 9, periodo);
                double tarifa_150_a_mas = conex.ObtenerTarifaAgua(grupo, categoria, 10, periodo);

                if (volumen <= 50)
                {
                    importe = tarifa_0_a_50 * volumen;
                }
                else
                {
                    if (volumen <= 150)
                    {
                        importe = 50 * tarifa_0_a_50 + (volumen - 50) * tarifa_50_a_150;
                    }
                    else
                    {
                        importe = 150 * tarifa_50_a_150 + (volumen - 150) * tarifa_150_a_mas;
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAlcantarilladoEstatal(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {


            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaDesague(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_50 * volumen;
            }
            else
            {
                double tarifa_0_a_50 = conex.ObtenerTarifaDesague(grupo, categoria, 8, periodo);
                double tarifa_50_a_150 = conex.ObtenerTarifaDesague(grupo, categoria, 9, periodo);
                double tarifa_150_a_mas = conex.ObtenerTarifaDesague(grupo, categoria, 10, periodo);

                if (volumen <= 50)
                {
                    importe = tarifa_0_a_50 * volumen;
                }
                else
                {
                    if (volumen <= 150)
                    {
                        importe = 50 * tarifa_0_a_50 + (volumen - 50) * tarifa_50_a_150;
                    }
                    else
                    {
                        importe = 150 * tarifa_50_a_150 + (volumen - 150) * tarifa_150_a_mas;
                    }
                }
            }

            return Math.Truncate(100 * importe) / 100;
        }

        
        public static double CalcularImporteAguaNoResidencialMorropon(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {
            double importe = 0;
            double tarifa_0_50 = conex.ObtenerTarifaAgua(grupo, categoria, 8, periodo);
            double tarifa_50_a_mas = conex.ObtenerTarifaAgua(grupo, categoria, 11, periodo);

            if(volumen <= 50)
            {
                importe = tarifa_0_50 * volumen;
            }
            else
            {
                importe = 50 * tarifa_0_50 + (volumen - 50) * tarifa_50_a_mas;
            }
            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAlcantarilladoNoResidencialMorropon(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {
            double importe = 0;
            double tarifa_0_50 = conex.ObtenerTarifaDesague(grupo, categoria, 8, periodo);
            double tarifa_50_a_mas = conex.ObtenerTarifaDesague(grupo, categoria, 11, periodo);

            if (volumen <= 50)
            {
                importe = tarifa_0_50 * volumen;
            }
            else
            {
                importe = 50 * tarifa_0_50 + (volumen - 50) * tarifa_50_a_mas;
            }
            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAguaSocial(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {
            double importe = 0;
            if(grupo == 10)
            {
                double tarifa_0_a_10 = conex.ObtenerTarifaAgua(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_10 * volumen;
            }
            else
            {
                double tarifa_0_a_10 = conex.ObtenerTarifaAgua(grupo, categoria, 1, periodo);
                double tarifa_10_a_mas = conex.ObtenerTarifaAgua(grupo, categoria, 2, periodo);
                if(volumen <= 10)
                {
                    importe = tarifa_0_a_10 * volumen;
                }
                else
                {
                    importe = 10 * tarifa_0_a_10 + (volumen - 10) * tarifa_10_a_mas;
                }
            }
            return Math.Truncate(100 * importe) / 100;
        }

        public static double CalcularImporteAlcantarilladoSocial(ConexionSQLite conex, int grupo, int categoria, double volumen, int periodo)
        {
            double importe = 0;
            if (grupo == 10)
            {
                double tarifa_0_a_10 = conex.ObtenerTarifaDesague(grupo, categoria, 12, periodo);
                importe = tarifa_0_a_10 * volumen;
            }
            else
            {
                double tarifa_0_a_10 = conex.ObtenerTarifaDesague(grupo, categoria, 1, periodo);
                double tarifa_10_a_mas = conex.ObtenerTarifaDesague(grupo, categoria, 2, periodo);
                if (volumen <= 10)
                {
                    importe = tarifa_0_a_10 * volumen;
                }
                else
                {
                    importe = 10 * tarifa_0_a_10 + (volumen - 10) * tarifa_10_a_mas;
                }
            }
            return Math.Truncate(100 * importe) / 100;
        }
    }
}
