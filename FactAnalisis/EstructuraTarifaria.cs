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
        List<Periodo> periodos;
        public EstructuraTarifaria()
        {
            InitializeComponent();

            estructs = new List<EstructuraTarifariaModel>();
            conexion = new ConexionPSQL();

            periodos = conexion.ObtenerTodosPeriodos();

            bindingSource1.DataSource = periodos;
            cmbPeriodos.DataSource = bindingSource1.DataSource;
            cmbPeriodos.DisplayMember = "Desc";
            cmbPeriodos.ValueMember = "ID";

            cmbPeriodos.DropDownStyle = ComboBoxStyle.DropDownList;

            Periodo UltimoPeriodo = conexion.ObtenerUltimoPeriodo();
            Console.WriteLine("Ultimo Periodo: "+  UltimoPeriodo.Desc);
            cmbPeriodos.SelectedValue = UltimoPeriodo.ID;

      
            CargarGrupoA(UltimoPeriodo.ID);
            dICargoFijoEstA.Value = UltimoPeriodo.CargoFijo;
        }

        private void superTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {

            Periodo selectedPeriodo = cmbPeriodos.SelectedItem as Periodo;

            switch (superTabControl1.SelectedTabIndex)
            {
                case 0:
                    CargarGrupoA(selectedPeriodo.ID);
                    break;
                case 1:
                    CargarGrupoB(selectedPeriodo.ID);
                    break;
                case 2:
                    CargarGrupoC(selectedPeriodo.ID);
                    break;
                case 3:
                    CargarGrupoD(selectedPeriodo.ID);
                    break;
                case 4:
                    CargarGrupoE(selectedPeriodo.ID);
                    break;
                case 5:
                    CargarGrupoF(selectedPeriodo.ID);
                    break;
                case 6:
                    CargarGrupoG(selectedPeriodo.ID);
                    break;
                case 7:
                    CargarGrupoH(selectedPeriodo.ID);
                    break;
                default:
                    CargarGrupoA(selectedPeriodo.ID);
                    break;
            }
        }

        

        private void CargarGrupoA(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Primer Grupo (Grupo A)
            estructs = conexion.ObtenerEstructurasTarifarias(1, periodo);
          

            //Social
            dI_A_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_A_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_A_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_A_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_A_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_A_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_A_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_A_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_A_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_A_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_A_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_A_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_A_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_A_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_A_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_A_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_A_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_A_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_A_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_A_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_A_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_A_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_A_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_A_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_A_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_A_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_A_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_A_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_A_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_A_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_A_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_A_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_A_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_A_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_A_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_A_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }

        private void CargarGrupoB(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Segundo Grupo (Grupo B)
            estructs = conexion.ObtenerEstructurasTarifarias(2, periodo);

            //Grupo B

            //Social
            dI_B_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_B_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_B_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_B_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_B_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_B_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_B_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_B_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_B_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_B_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_B_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_B_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_B_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_B_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_B_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_B_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_B_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_B_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_B_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_B_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_B_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_B_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_B_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_B_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_B_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_B_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_B_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_B_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_B_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_B_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_B_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_B_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_B_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_B_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_B_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_B_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }

        private void CargarGrupoC(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Tercer Grupo (Grupo C)
            estructs = conexion.ObtenerEstructurasTarifarias(3, periodo);

            //Grupo C

            //Social
            dI_C_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_C_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_C_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_C_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_C_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_C_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_C_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_C_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_C_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_C_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_C_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_C_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_C_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_C_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_C_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_C_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_C_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_C_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_C_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_C_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_C_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_C_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_C_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_C_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_C_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_C_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_C_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_C_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_C_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_C_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_C_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_C_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_C_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_C_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_C_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_C_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }


        private void CargarGrupoD(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Tercer Grupo (Grupo C)
            estructs = conexion.ObtenerEstructurasTarifarias(4, periodo);

            //Grupo D

            //Social
            dI_D_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_D_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_D_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_D_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_D_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_D_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_D_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_D_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_D_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_D_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_D_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_D_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_D_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_D_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_D_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_D_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_D_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_D_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_D_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_D_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_D_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_D_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_D_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_D_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_D_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_D_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_D_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_D_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_D_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_D_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_D_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_D_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_D_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_D_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_D_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_D_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }


        private void CargarGrupoE(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Quinto Grupo (Grupo E)
            estructs = conexion.ObtenerEstructurasTarifarias(5, periodo);

            //Grupo E

            //Social
            dI_E_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_E_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_E_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_E_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_E_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_E_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_E_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_E_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_E_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_E_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_E_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_E_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_E_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_E_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_E_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_E_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_E_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_E_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_E_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_E_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_E_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_E_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_E_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_E_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_E_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_E_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_E_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_E_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_E_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_E_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_E_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_E_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_E_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_E_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_E_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_E_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }


        private void CargarGrupoF(int periodo)
        {
            throw new NotImplementedException();
        }

        private void CargarGrupoG(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Quinto Grupo (Grupo E)
            estructs = conexion.ObtenerEstructurasTarifarias(7, periodo);

            //Grupo G

            //Social
            dI_G_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_G_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_G_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_G_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_G_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_G_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_G_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_G_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_G_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_G_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_G_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_G_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_G_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_G_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_G_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_G_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_G_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_G_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_G_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_G_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_G_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_G_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_G_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_G_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_G_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_G_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_G_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_G_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_G_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_G_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_G_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_G_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_G_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_G_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_G_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_G_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }

        private void CargarGrupoH(int periodo)
        {
            //Obtener la ultima Estructura Tarifaria del Quinto Grupo (Grupo H)
            estructs = conexion.ObtenerEstructurasTarifarias(8, periodo);

            //Grupo H

            //Social
            dI_H_Social_0_10_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Agua;
            dI_H_Social_0_10_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 1).FirstOrDefault().Alcantarillado;
            dI_H_Social_10_A_Mas_Agua.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Agua;
            dI_H_Social_10_A_Mas_Alc.Value = estructs.Where(est => est.IDCategoria == 6 && est.IDRango == 2).FirstOrDefault().Alcantarillado;

            //Domestica 1
            dI_H_Dom1_0_8_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_H_Dom1_0_8_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_H_Dom1_8_25_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_H_Dom1_8_25_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_H_Dom1_25_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Agua;
            dI_H_Dom1_25_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 1 && est.IDRango == 6).FirstOrDefault().Alcantarillado;

            //Domestica 2
            dI_H_0_8_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Agua;
            dI_H_0_8_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 3).FirstOrDefault().Alcantarillado;

            dI_H_8_25_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Agua;
            dI_H_8_25_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 4).FirstOrDefault().Alcantarillado;

            dI_H_25_100_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Agua;
            dI_H_25_100_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 5).FirstOrDefault().Alcantarillado;

            dI_H_100_mas_Dom2_Agua.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Agua;
            dI_H_100_mas_Dom2_Alc.Value = estructs.Where(est => est.IDCategoria == 2 && est.IDRango == 7).FirstOrDefault().Alcantarillado;

            //Comercial
            dI_H_Com_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_H_Com_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_H_Com_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_H_Com_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_H_Com_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_H_Com_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 3 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Industrial
            dI_H_Ind_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_H_Ind_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_H_Ind_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_H_Ind_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_H_Ind_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_H_Ind_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 4 && est.IDRango == 10).FirstOrDefault().Alcantarillado;


            //Estatal
            dI_H_Est_0_50_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Agua;
            dI_H_Est_0_50_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 8).FirstOrDefault().Alcantarillado;

            dI_H_Est_50_150_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Agua;
            dI_H_Est_50_150_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 9).FirstOrDefault().Alcantarillado;

            dI_H_Est_150_mas_Agua.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Agua;
            dI_H_Est_150_mas_Alc.Value = estructs.Where(est => est.IDCategoria == 5 && est.IDRango == 10).FirstOrDefault().Alcantarillado;
        }

        private void cmbPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Periodo periodoSelected = cmbPeriodos.SelectedItem as Periodo;
            dICargoFijoEstA.Value = periodoSelected.CargoFijo;

            switch (superTabControl1.SelectedTabIndex)
            {
                case 0:
                    CargarGrupoA(periodoSelected.ID);
                    break;
                case 1:
                    CargarGrupoB(periodoSelected.ID);
                    break;
                case 2:
                    CargarGrupoC(periodoSelected.ID);
                    break;
                case 3:
                    CargarGrupoD(periodoSelected.ID);
                    break;
                case 4:
                    CargarGrupoE(periodoSelected.ID);
                    break;
                case 5:
                    CargarGrupoF(periodoSelected.ID);
                    break;
                case 6:
                    CargarGrupoG(periodoSelected.ID);
                    break;
                case 7:
                    CargarGrupoH(periodoSelected.ID);
                    break;
                default:
                    CargarGrupoA(periodoSelected.ID);
                    break;
            }
        }
    }
}
