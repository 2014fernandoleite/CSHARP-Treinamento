// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjExercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DataHora_Click(object sender, EventArgs e)
        {
            //lbl_Atual.Text = DateTime.Now.ToString();
            lbl_Atual.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
        }

        private void btn_Data_Click(object sender, EventArgs e)
        {
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_Hora_Click(object sender, EventArgs e)
        {
            lbl_Hota.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btn_Diferenca_Click(object sender, EventArgs e)
        {

            string dataInicial = dtp_DtInicio.Text;
            string dataFinal = dtp_DFinal.Text;

            TimeSpan TSP_date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);

            int totalDias = TSP_date.Days;

            txt_Resultado.Text = totalDias.ToString();

        }

        private void btn_SomarDias_Click(object sender, EventArgs e)
        {
            txt_ResultSoma.Text = DateTime.Today.AddDays(Convert.ToDouble(txt_NrDias.Text)).ToString("yyyy-MM-dd");
        }


    }
}
