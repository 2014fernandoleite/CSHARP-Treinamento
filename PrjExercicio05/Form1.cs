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

namespace PrjExercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            clsValidacao CLS_Validacao = new clsValidacao();
            if (CLS_Validacao.FU_Validacao(txt_Nr1.Text.ToString()) == false)
            {
                txt_Nr1.Focus();
                return;
            }

            if (CLS_Validacao.FU_Validacao(txt_Nr2.Text.ToString()) == false)
            {
                txt_Nr2.Focus();
                return;
            }

            lbl_Operacao.Text = "+";
            //lbl_Resultado.Text = Convert.ToString(Convert.ToDecimal(txt_Nr1.Text) + Convert.ToDecimal(txt_Nr2.Text));
            lbl_Resultado.Text = (Convert.ToDecimal(txt_Nr1.Text) + Convert.ToDecimal(txt_Nr2.Text)).ToString("##0.00##");
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            clsValidacao CLS_Validacao = new clsValidacao();
            if (CLS_Validacao.FU_Validacao(txt_Nr1.Text.ToString()) == false)
            {
                txt_Nr1.Focus();
                return;
            }

            if (CLS_Validacao.FU_Validacao(txt_Nr2.Text.ToString()) == false)
            {
                txt_Nr2.Focus();
                return;
            }

            lbl_Operacao.Text = "-";
            //lbl_Resultado.Text = Convert.ToString(Convert.ToDecimal(txt_Nr1.Text) - Convert.ToDecimal(txt_Nr2.Text));
            lbl_Resultado.Text = (Convert.ToDecimal(txt_Nr1.Text) - Convert.ToDecimal(txt_Nr2.Text)).ToString("##0.00##");
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            clsValidacao CLS_Validacao = new clsValidacao();
            if (CLS_Validacao.FU_Validacao(txt_Nr1.Text.ToString()) == false)
            {
                txt_Nr1.Focus();
                return;
            }

            if (CLS_Validacao.FU_Validacao(txt_Nr2.Text.ToString()) == false)
            {
                txt_Nr2.Focus();
                return;
            }

            lbl_Operacao.Text = "x";
            //lbl_Resultado.Text = Convert.ToString(Convert.ToDecimal(txt_Nr1.Text) * Convert.ToDecimal(txt_Nr2.Text));
            lbl_Resultado.Text = (Convert.ToDecimal(txt_Nr1.Text) * Convert.ToDecimal(txt_Nr2.Text)).ToString("##0.00##");
        }

        private void btn_Divi_Click(object sender, EventArgs e)
        {
            clsValidacao CLS_Validacao = new clsValidacao();
            if (CLS_Validacao.FU_Validacao(txt_Nr1.Text.ToString()) == false)
            {
                txt_Nr1.Focus();
                return;
            }

            if (CLS_Validacao.FU_Validacao(txt_Nr2.Text.ToString()) == false)
            {
                txt_Nr2.Focus();
                return;
            }

            lbl_Operacao.Text = "/";
            //lbl_Resultado.Text = Convert.ToString(Convert.ToDecimal(txt_Nr1.Text) / Convert.ToDecimal(txt_Nr2.Text));
            lbl_Resultado.Text = (Convert.ToDecimal(txt_Nr1.Text) / Convert.ToDecimal(txt_Nr2.Text)).ToString("##0.00##");
        }

        private void txt_Nr1_Validated(object sender, EventArgs e)
        {

            txt_Nr1.Text = txt_Nr1.Text.Replace(".", ",");

        }

        private void txt_Nr2_Validated(object sender, EventArgs e)
        {

            txt_Nr2.Text = txt_Nr2.Text.Replace(".", ",");
        }


        private void txt_VlrEntrada_Validated(object sender, EventArgs e)
        {

            txt_VlrEntrada.Text = txt_VlrEntrada.Text.Replace(".", ",");
        }

        private void txt_NrDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Se o que foi digitado não é um argumento valido  (setas, enter)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > 0)
            {
                e.Handled = true;
            }

        }

        private void btn_Arredondar_Click(object sender, EventArgs e)
        {
            

            clsValidacao CLS_Validacao = new clsValidacao();
            if (CLS_Validacao.FU_Validacao(txt_VlrEntrada.Text.ToString()) == false)
            {
                txt_VlrEntrada.Focus();
                return;
            }

            if (CLS_Validacao.FU_Validacao(txt_NrDecimais.Text.ToString()) == false)
            {
                txt_NrDecimais.Focus();
                return;
            }

            if (Convert.ToInt32(txt_NrDecimais.Text) > 28)
            {
                txt_NrDecimais.Focus();
                MessageBox.Show("Valor das casas decimais não pode ser maior que 28");
                return;
            }

            lbl_ValorConvertido.Text = Decimal.Round(Convert.ToDecimal(txt_VlrEntrada.Text), Convert.ToInt32(txt_NrDecimais.Text)).ToString("##0.00##########");
        }

        private void Btn_Truncar_Click(object sender, EventArgs e)
        {

            Double LDEC_Valor = 0;      // Ponto Flutuante
            Double LDEC_Multip = 0;

            clsValidacao CLS_Validacao = new clsValidacao();
            if (CLS_Validacao.FU_Validacao(txt_VlrEntrada.Text.ToString()) == false)
            {
                txt_VlrEntrada.Focus();
                return;
            }

            if (CLS_Validacao.FU_Validacao(txt_NrDecimais.Text.ToString()) == false)
            {
                txt_NrDecimais.Focus();
                return;
            }

            // Truncate elimina as casas decimais
            // Para truncar mantendo algumas decimais, é necessário deslocar a virgula, executar o truncate e voltar a virgula para o posição de origem

            // Para truncar com 2 Decimais 
            // Valor ==> 100,123456
            // Deslocar Virgula ==> 10012,3456
            // Truncar ==> 10012
            // Devolver a Virgula para a posição correta ==> 100,12

            // Para truncar com 3 Decimais 
            // Valor ==> 100,123456
            // Deslocar Virgula ==> 100123,456
            // Truncar ==> 100123
            // Devolver a Virgula para a posição correta ==> 100,123

            // ^ ==> Exponenciação
            // 10 ^ 0 == 1
            // 10 ^ 1 == 10
            // 10 ^ 2 == 100
            // 10 ^ 3 == 1000
            // 10 ^ 4 == 10000
            // 10 ^ 5 == 100000

            // 100,123456 * 100 ==> 10012,3456
            // Trunca ==> 10012
            // 10012 / 100 ==> 100,12

            // 100,123456 * 1000 ==> 100123,456
            // Trunca ==> 100123
            // 100123 / 1000 ==> 100,123

            // Eleva 10 ao numero de decimais (será utilizado para deslocar a virgula)
            LDEC_Multip = Math.Pow(Convert.ToDouble(10), Convert.ToDouble(txt_NrDecimais.Text));

            // Desloca a virgula
            LDEC_Valor = Convert.ToDouble(txt_VlrEntrada.Text) * LDEC_Multip;

            // Trunca o numero
            LDEC_Valor = Math.Truncate(LDEC_Valor);

            // Restabelece a posição da Virgula
            LDEC_Valor = LDEC_Valor / LDEC_Multip;

            // Mostra o resultado
            lbl_ValorConvertido.Text = LDEC_Valor.ToString("###0.00###########");

        }


    }
}
