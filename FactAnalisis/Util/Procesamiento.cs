using FactAnalisis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAnalisis.Util
{
    public class Procesamiento
    {

        public static List<BaseBD> Analisis(ConexionSQLite conex, int periodo, List<BaseBD> bases)
        {
            foreach(BaseBD baseBD in bases)
            {
                switch (baseBD.codamb)
                {
                    case 1:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 1, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 1, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 1, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 1, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 1, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 1, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 1, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 1, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 1, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 1, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 1, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 1, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;
                    case 2:
                        switch(baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 2, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 2, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex,2, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 2, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex,2, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 2, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 2, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 2, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 2, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 2, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 2, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 2, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;
                    case 3:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 3, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 3, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 3, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 3, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 3, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 3, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 3, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 3, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 3, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 3, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 3, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 3, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;

                    case 4:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 4, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 4, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 4, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 4, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 4, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 4, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 4, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 4, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 4, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 4, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 4, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 4, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;

                    case 5:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex,5, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 5, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 5, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 5, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 5, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 5, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex,5, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 5, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 5, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 5, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 5, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 5, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;

                    case 6:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 6, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 6, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 6, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex,6, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 6, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 6, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 6, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 6, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 6, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 6, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 6, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 6, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;

                    case 7:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 7, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 7, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 7, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 7, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 7, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 7, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 7, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 7, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 7, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 7, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 7, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex,7, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;

                    case 8:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 8, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex,8, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 8, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 8, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 8, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 8, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 8, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 8, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 8, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 8, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex, 8, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 8, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;

                    case 10:
                        switch (baseBD.nomcat)
                        {
                            case "DOMESTICA 1":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica1(conex, 10, 1, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica1(conex, 10, 1, baseBD.volfac, periodo);
                                break;
                            case "DOMESTICA 2":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaDomestica2(conex, 10, 2, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoDomestica2(conex, 10, 2, baseBD.volfac, periodo);
                                break;
                            case "COMERCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex,10, 3, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 10, 3, baseBD.volfac, periodo);
                                break;
                            case "INDUSTRIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaComercialIndustrial(conex, 10, 4, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoComercialIndustrial(conex, 10, 4, baseBD.volfac, periodo);
                                break;
                            case "ESTATAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaEstatal(conex, 10, 5, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoEstatal(conex, 10, 5, baseBD.volfac, periodo);
                                break;
                            case "SOCIAL":
                                baseBD.imagua_nuevo = CalculoImportes.CalcularImporteAguaSocial(conex,10, 6, baseBD.volfac, periodo);
                                baseBD.imalca_nuevo = CalculoImportes.CalcularImporteAlcantarilladoSocial(conex, 10, 6, baseBD.volfac, periodo);
                                break;
                        }
                        break;
                }
                
            }
            return bases;
        }


    }
}
