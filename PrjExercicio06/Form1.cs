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

namespace PrjExercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Trim_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Valor1.Text.Trim();
        }

        private void btn_substring_Click(object sender, EventArgs e)
        {
            int LINT_Inicio;
            int LINT_Tamanho;

            LINT_Tamanho = Convert.ToInt32(txt_TamanhoSub.Text);
            LINT_Inicio = Convert.ToInt32(txt_InicioSub.Text);

            if (txt_Valor1.Text.Length >= (LINT_Tamanho + LINT_Inicio))
            {
                txt_Resultado.Text = txt_Valor1.Text.Substring(LINT_Inicio, LINT_Tamanho);
            }
            else
            {
                MessageBox.Show("Tamanho incompativel");
            }
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Valor1.Text.Replace(txt_Antigo.Text.ToString(), txt_Novo.Text.ToString());
        }

        private void btn_indexOf_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text =  txt_Valor1.Text.IndexOf(txt_PesquisarIndexOF.Text.ToString()).ToString();
        }

        private void btn_ToUpper_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Valor1.Text.ToUpper();
        }

        private void btn_ToLower_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Valor1.Text.ToLower();
        }

    }
}
