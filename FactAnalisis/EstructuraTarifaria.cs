using DevComponents.DotNetBar;
using FactAnalisis.Model;
using FactAnalisis.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactAnalisis
{
    public partial class EstructuraTarifaria : Office2007Form
    {

        ConexionPSQL conexion;
        List<EstructuraTarifariaModel> estructs;
        public EstructuraTarifaria()
        {
            InitializeComponent();

            conexion = new ConexionPSQL();
            CargarGrupoA();
           
        }

        private void superTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            switch (superTabControl1.SelectedTab.Text)
            {
                case "A) PIURA Y CASTILLA":
                    CargarGrupoA();
                    break;
                case "B) PAITA, CATACAOS...":
                    CargarGrupoB();
                    break;
                default:
                    CargarGrupoA();
                    break;
            }
        }

        private void CargarGrupoA()
        {
            //Obtener por defecto la ultima Estructura Tarifaria
            estructs = conexion.ObtenerEstructurasTarifarias(1, 3);

            //Grupo A
            dICargoFijoEstA.Value = estructs.First().CargoFijo;

            //Social
            dI_A_Social_0_10_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Social_0_10_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;
            dI_A_Social_10_A_Mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Social_10_A_Mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            //Domestica 1
            dI_A_Dom1_0_8_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Dom1_0_8_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Dom1_8_25_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Dom1_8_25_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Dom1_25_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            //Domestica 2
            dI_A_0_8_Dom2_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_0_8_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_8_25_Dom2_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_8_25_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_25_100_Dom2_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_25_100_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_A_100_mas_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            //Comercial
            dI_A_Com_0_50_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Com_0_50_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Com_50_150_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Com_50_150_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Com_150_mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Com_150_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;


            //Industrial
            dI_A_Ind_0_50_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Ind_0_50_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Ind_50_150_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Ind_50_150_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Ind_150_mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Ind_150_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;


            //Estatal
            dI_A_Est_0_50_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Est_0_50_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Est_50_150_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Est_50_150_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_A_Est_150_mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_A_Est_150_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;
        }

        private void CargarGrupoB()
        {
            //Obtener por defecto la ultima Estructura Tarifaria
            estructs = conexion.ObtenerEstructurasTarifarias(2, 3);

            //Grupo A

            //Social
            dI_B_Social_0_10_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Social_0_10_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;
            dI_B_Social_10_A_Mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Social_10_A_Mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            //Domestica 1
            dI_B_Dom1_0_8_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Dom1_0_8_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Dom1_8_25_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Dom1_8_25_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Dom1_25_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            //Domestica 2
            dI_B_0_8_Dom2_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_0_8_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_8_25_Dom2_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_8_25_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_25_100_Dom2_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_25_100_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_B_100_mas_Dom2_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            //Comercial
            dI_B_Com_0_50_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Com_0_50_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Com_50_150_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Com_50_150_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Com_150_mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Com_150_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;


            //Industrial
            dI_B_Ind_0_50_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Ind_0_50_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Ind_50_150_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Ind_50_150_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Ind_150_mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Ind_150_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;


            //Estatal
            dI_B_Est_0_50_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Est_0_50_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Est_50_150_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Est_50_150_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;

            dI_B_Est_150_mas_Agua.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Agua;
            dI_B_Est_150_mas_Alc.Value = estructs.Where<EstructuraTarifariaModel>(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault<EstructuraTarifariaModel>().Alcantarillado;
        }
    }
}
