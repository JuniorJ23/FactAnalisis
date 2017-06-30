using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{

    public class CalculoVolumen
    {
        private static Configuracion config = Configuracion.Instance;

        public static Double calcular_volumen_agua_comercial_industrial(ConexionSQLite conex, int grupo, int categoria, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_50;
            double trf_50_150;
            double trf_150_mas;

            if (grupo == 10) {
                trf_0_50 = conex.ObtenerTarifaAgua(grupo, categoria, 12, periodo);
                vol_agua = importe / trf_0_50;
            } else {
                trf_0_50 = conex.ObtenerTarifaAgua(grupo, categoria, 8, periodo);
                trf_50_150 = conex.ObtenerTarifaAgua(grupo, categoria, 9, periodo);
                trf_150_mas = conex.ObtenerTarifaAgua(grupo, categoria, 10, periodo);
                if (importe <= trf_0_50 * 50) { 
                    vol_agua = importe / trf_0_50;
                } else
                {
                    if(importe <= trf_0_50 * 150)
                    {
                        vol_agua = 50 + (importe - 50 * trf_0_50) / trf_150_mas;
                    } else
                    {
                        vol_agua = 150 + (importe-150*trf_50_150)/trf_150_mas;
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua*100)/100;
            return vol_agua;
        }

        static Double calcular_volumen_alc_comercial_industrial(ConexionSQLite conex, int grupo, int categoria, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_50;
            double trf_50_150;
            double trf_150_mas;

            if (grupo == 10)
            {
                trf_0_50 = conex.ObtenerTarifaDesague(grupo, categoria, 12, periodo);
                vol_agua = importe / trf_0_50;
            }
            else
            {
                trf_0_50 = conex.ObtenerTarifaDesague(grupo, categoria, 8, periodo);
                trf_50_150 = conex.ObtenerTarifaDesague(grupo, categoria, 9, periodo);
                trf_150_mas = conex.ObtenerTarifaDesague(grupo, categoria, 10, periodo);
                if (importe <= trf_0_50 * 50)
                {
                    vol_agua = importe / trf_0_50;
                }
                else
                {
                    if (importe <= trf_0_50 * 150)
                    {
                        vol_agua = 50 + (importe - 50 * trf_0_50) / trf_150_mas;
                    }
                    else
                    {
                        vol_agua = 150 + (importe - 150 * trf_50_150) / trf_150_mas;
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_agua_domestica1(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_8;
            double trf_8_25;
            double trf_25_mas;
            
            if (grupo == 10)
            {
                trf_0_8 = conex.ObtenerTarifaAgua(grupo, 1, 12, periodo);
                vol_agua = importe / trf_0_8;
            }
            else
            {
                trf_0_8 = conex.ObtenerTarifaAgua(grupo, 1, 3, periodo);
                trf_8_25 = conex.ObtenerTarifaAgua(grupo, 1, 4, periodo);
                trf_25_mas = conex.ObtenerTarifaAgua(grupo, 1, 6, periodo);
                if (importe <= trf_0_8 * 8)
                {
                    vol_agua = importe / trf_0_8;
                }
                else
                {
                    if (importe <= trf_0_8 * 8 + trf_8_25 * 17)
                    {
                        vol_agua = 8 + (importe - 8 * trf_0_8) / trf_8_25;
                    }
                    else
                    {
                        vol_agua = 25 + (importe - 8 * trf_0_8 - 17 * trf_25_mas) / trf_25_mas;
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_alc_domestica1(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_8;
            double trf_8_25;
            double trf_25_mas;

            if (grupo == 10)
            {
                trf_0_8 = conex.ObtenerTarifaDesague(grupo, 1, 12, periodo);
                vol_agua = importe / trf_0_8;
            }
            else
            {
                trf_0_8 = conex.ObtenerTarifaDesague(grupo, 1, 3, periodo);
                trf_8_25 = conex.ObtenerTarifaDesague(grupo, 1, 4, periodo);
                trf_25_mas = conex.ObtenerTarifaDesague(grupo, 1, 6, periodo);
                if (importe <= trf_0_8 * 8)
                {
                    vol_agua = importe / trf_0_8;
                }
                else
                {
                    if (importe <= trf_0_8 * 8 + trf_8_25 * 17)
                    {
                        vol_agua = 8 + (importe - 8 * trf_0_8) / trf_8_25;
                    }
                    else
                    {
                        vol_agua = 25 + (importe - 8 * trf_0_8 - 17 * trf_25_mas) / trf_25_mas;
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_agua_domestica2(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_8;
            double trf_8_25;
            double trf_25_100;
            double trf_100_mas;

            if (grupo == 10)
            {
                trf_0_8 = conex.ObtenerTarifaAgua(grupo, 2, 12, periodo);
                vol_agua = importe / trf_0_8;
            }
            else
            {
                trf_0_8 = conex.ObtenerTarifaAgua(grupo, 2, 3, periodo);
                trf_8_25 = conex.ObtenerTarifaAgua(grupo, 2, 4, periodo);
                trf_25_100 = conex.ObtenerTarifaAgua(grupo, 2, 5, periodo);
                trf_100_mas = conex.ObtenerTarifaAgua(grupo, 2, 7, periodo);
                if (importe <= trf_0_8 * 8)
                {
                    vol_agua = importe / trf_0_8;
                }
                else
                {
                    if (importe <= trf_0_8 * 8 + trf_8_25 * 17)
                    {
                        vol_agua = 8 + (importe - 8 * trf_0_8) / trf_8_25;
                    }
                    else
                    {
                        if (importe <= 8 * trf_0_8 + 17 * trf_8_25 + 75 * trf_25_100)
                        {
                            vol_agua = 25 + (importe - 8 * trf_0_8 - 17 * trf_8_25) / trf_25_100;
                        }
                        else
                        {
                            vol_agua = 100 + (importe - 8 * trf_0_8 - 17 * trf_8_25 - 75 * trf_25_100) / trf_100_mas;
                        }
                        
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_alc_domestica2(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_8;
            double trf_8_25;
            double trf_25_100;
            double trf_100_mas;

            if (grupo == 10)
            {
                trf_0_8 = conex.ObtenerTarifaDesague(grupo, 2, 12, periodo);
                vol_agua = importe / trf_0_8;
            }
            else
            {
                trf_0_8 = conex.ObtenerTarifaDesague(grupo, 2, 3, periodo);
                trf_8_25 = conex.ObtenerTarifaDesague(grupo, 2, 4, periodo);
                trf_25_100 = conex.ObtenerTarifaDesague(grupo, 2, 5, periodo);
                trf_100_mas = conex.ObtenerTarifaDesague(grupo, 2, 7, periodo);
                if (importe <= trf_0_8 * 8)
                {
                    vol_agua = importe / trf_0_8;
                }
                else
                {
                    if (importe <= trf_0_8 * 8 + trf_8_25 * 17)
                    {
                        vol_agua = 8 + (importe - 8 * trf_0_8) / trf_8_25;
                    }
                    else
                    {
                        if (importe <= 8 * trf_0_8 + 17 * trf_8_25 + 75 * trf_25_100)
                        {
                            vol_agua = 25 + (importe - 8 * trf_0_8 - 17 * trf_8_25) / trf_25_100;
                        }
                        else
                        {
                            vol_agua = 100 + (importe - 8 * trf_0_8 - 17 * trf_8_25 - 75 * trf_25_100) / trf_100_mas;
                        }

                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_agua_domestica2_morropon(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_8;
            double trf_8_25;
            double trf_25_mas;

            trf_0_8 = conex.ObtenerTarifaAgua(grupo, 1, 3, periodo);
            trf_8_25 = conex.ObtenerTarifaAgua(grupo, 1, 4, periodo);
            trf_25_mas = conex.ObtenerTarifaAgua(grupo, 1, 6, periodo);
            if (importe <= trf_0_8 * 8)
            {
                vol_agua = importe / trf_0_8;
            }
            else
            {
                if (importe <= trf_0_8 * 8 + trf_8_25 * 17)
                {
                    vol_agua = 8 + (importe - 8 * trf_0_8) / trf_8_25;
                }
                else
                {
                    vol_agua = 25 + (importe - 8 * trf_0_8 - 17 * trf_25_mas) / trf_25_mas;
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_alc_domestica2_morropon(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_8;
            double trf_8_25;
            double trf_25_mas;

            trf_0_8 = conex.ObtenerTarifaDesague(grupo, 1, 3, periodo);
            trf_8_25 = conex.ObtenerTarifaDesague(grupo, 1, 4, periodo);
            trf_25_mas = conex.ObtenerTarifaDesague(grupo, 1, 6, periodo);
            if (importe <= trf_0_8 * 8)
            {
                vol_agua = importe / trf_0_8;
            }
            else
            {
                if (importe <= trf_0_8 * 8 + trf_8_25 * 17)
                {
                    vol_agua = 8 + (importe - 8 * trf_0_8) / trf_8_25;
                }
                else
                {
                    vol_agua = 25 + (importe - 8 * trf_0_8 - 17 * trf_25_mas) / trf_25_mas;
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_agua_estatal(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_50;
            double trf_50_150;
            double trf_150_mas;
            if (grupo == 10)
            {
                trf_0_50 = conex.ObtenerTarifaAgua(grupo, 5, 12, periodo);
                vol_agua = importe / trf_0_50;
            }
            else {
                trf_0_50 = conex.ObtenerTarifaAgua(grupo, 5, 8, periodo);
                trf_50_150 = conex.ObtenerTarifaAgua(grupo, 5, 9, periodo);
                trf_150_mas = conex.ObtenerTarifaAgua(grupo, 5, 10, periodo);
                if (importe <= trf_0_50 * 50)
                {
                    vol_agua = importe / trf_0_50;
                }
                else
                {
                    if (importe <= trf_0_50 * 50 + trf_50_150 * 100)
                    {
                        vol_agua = 50 + (importe - 50 * trf_0_50) / trf_50_150;
                    }
                    else
                    {
                        vol_agua = 150 + (importe - 150 * trf_50_150) / trf_150_mas;
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_alc_estatal(ConexionSQLite conex, int grupo, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_50;
            double trf_50_150;
            double trf_150_mas;
            if (grupo == 10)
            {
                trf_0_50 = conex.ObtenerTarifaDesague(grupo, 5, 12, periodo);
                vol_agua = importe / trf_0_50;
            }
            else
            {
                trf_0_50 = conex.ObtenerTarifaDesague(grupo, 5, 8, periodo);
                trf_50_150 = conex.ObtenerTarifaDesague(grupo, 5, 9, periodo);
                trf_150_mas = conex.ObtenerTarifaDesague(grupo, 5, 10, periodo);
                if (importe <= trf_0_50 * 50)
                {
                    vol_agua = importe / trf_0_50;
                }
                else
                {
                    if (importe <= trf_0_50 * 50 + trf_50_150 * 100)
                    {
                        vol_agua = 50 + (importe - 50 * trf_0_50) / trf_50_150;
                    }
                    else
                    {
                        vol_agua = 150 + (importe - 150 * trf_50_150) / trf_150_mas;
                    }
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_agua_no_residencial_morropon(ConexionSQLite conex, int grupo, int categoria, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_50;
            double trf_50_mas;

            trf_0_50 = conex.ObtenerTarifaAgua(grupo, categoria, 8, periodo);
            trf_50_mas = conex.ObtenerTarifaAgua(grupo, categoria, 11, periodo);
            if (importe <= trf_0_50 * 50)
            {
                vol_agua = importe / trf_0_50;
            }
            else
            {
                vol_agua = 50 + (importe - 50 * trf_0_50) / trf_50_mas;
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_alc_no_residencial_morropon(ConexionSQLite conex, int grupo, int categoria, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_50;
            double trf_50_mas;

            trf_0_50 = conex.ObtenerTarifaDesague(grupo, categoria, 8, periodo);
            trf_50_mas = conex.ObtenerTarifaDesague(grupo, categoria, 11, periodo);
            if (importe <= trf_0_50 * 50)
            {
                vol_agua = importe / trf_0_50;
            }
            else
            {
                vol_agua = 50 + (importe - 50 * trf_0_50) / trf_50_mas;
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_agua_social(ConexionSQLite conex, int grupo, int categoria, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_10;
            double trf_10_mas;

            if (grupo == 10)
            {
                trf_0_10 = conex.ObtenerTarifaAgua(grupo, 6, 12, periodo);
                vol_agua = importe / trf_0_10;
            }
            else {
                trf_0_10 = conex.ObtenerTarifaAgua(grupo, 6, 1, periodo);
                trf_10_mas = conex.ObtenerTarifaAgua(grupo, 6, 2, periodo);
                if (importe <= trf_0_10 * 10)
                {
                    vol_agua = importe / trf_0_10;
                }
                else
                {
                    vol_agua = 10 + (importe - 10 * trf_0_10) / trf_10_mas;
                }
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }

        public static Double calcular_volumen_alc_social(ConexionSQLite conex, int grupo, int categoria, int importe, int periodo)
        {
            double vol_agua;
            double trf_0_10;
            double trf_10_mas;

            if (grupo == 10)
            {
                trf_0_10 = conex.ObtenerTarifaDesague(grupo, 6, 12, periodo);
                vol_agua = importe / trf_0_10;
            }
            else
            {
                trf_0_10 = conex.ObtenerTarifaDesague(grupo, 6, 1, periodo);
                trf_10_mas = conex.ObtenerTarifaDesague(grupo, 6, 2, periodo);
                if (importe <= trf_0_10 * 10)
                {
                    vol_agua = importe / trf_0_10;
                }
                else
                {
                    vol_agua = 10 + (importe - 10 * trf_0_10) / trf_10_mas;
                }
                
            }
            vol_agua = Math.Truncate(vol_agua * 100) / 100;
            return vol_agua;
        }
    }
}