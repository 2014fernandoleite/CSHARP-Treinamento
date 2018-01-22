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

namespace PrjExercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IfElse_Click(object sender, EventArgs e)
        {

            if (Chk_Alternativa.Checked == false && Chk_Quando.Checked == false)
            {
                MessageBox.Show("Favor informar pelo menos uma combinação.");
            }            
            else if (Chk_Alternativa.Checked == true && Chk_Quando.Checked == true)
            {
                if (opt_Agora.Checked == true)
                {
                    if (opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString() + " " + opt_Agora.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString() + " " + opt_Agora.Text.ToString());
                    }
                }
                else
                {
                    if (opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString() + " " + opt_Depois.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString() + " " + opt_Depois.Text.ToString());
                    }
                }
            }
            else
            {
                if (Chk_Alternativa.Checked == true)
                {
                    if (opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString());
                    }
                }
                else
                {
                    if (opt_Agora.Checked == true)
                    {
                        MessageBox.Show(opt_Agora.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Depois.Text.ToString());
                    }
                }
            }
        }

        private void btn_IfNot_Click(object sender, EventArgs e)
        {

            if (!Chk_Alternativa.Checked == true && !Chk_Quando.Checked == true)
            {
                MessageBox.Show("Favor informar pelo menos uma combinação.");
            }
            else if (!Chk_Alternativa.Checked == false && !Chk_Quando.Checked == false)
            {
                if (!opt_Agora.Checked == true)
                {

                    if (!opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString() + " " + opt_Depois.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString() + " " + opt_Depois.Text.ToString());
                    }

                }
                else
                {
                    if (!opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString() + " " + opt_Agora.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString() + " " + opt_Agora.Text.ToString());
                    }
                }
            }
            else
            {
                if (!Chk_Alternativa.Checked == true)
                {
                    if (!opt_Agora.Checked == true)
                    {
                        MessageBox.Show(opt_Depois.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Agora.Text.ToString());
                    }
                }
                else
                {
                    if (!opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString());
                    }
                }
            }
        }

        private void btn_Case_Click(object sender, EventArgs e)
        {

            if (Chk_Alternativa.Checked == false && Chk_Quando.Checked == false)
            {
                MessageBox.Show("Favor informar pelo menos uma combinação.");
            }
            else if (Chk_Alternativa.Checked == true && Chk_Quando.Checked == true)
            {
                switch (opt_Agora.Checked)
                {
                    case true:

                        if (opt_Trabalhar.Checked == true)
                        {
                            MessageBox.Show(opt_Trabalhar.Text.ToString() + " " + opt_Agora.Text.ToString());
                        }
                        else
                        {
                            MessageBox.Show(opt_Estudar.Text.ToString() + " " + opt_Agora.Text.ToString());
                        }

                        break;

                    default:

                        if (opt_Trabalhar.Checked == true)
                        {
                            MessageBox.Show(opt_Trabalhar.Text.ToString() + " " + opt_Depois.Text.ToString());
                        }
                        else
                        {
                            MessageBox.Show(opt_Estudar.Text.ToString() + " " + opt_Depois.Text.ToString());
                        }
                        break;

                }
            }
            else
            {
                if (Chk_Alternativa.Checked == true)
                {
                    if (opt_Trabalhar.Checked == true)
                    {
                        MessageBox.Show(opt_Trabalhar.Text.ToString() );
                    }
                    else
                    {
                        MessageBox.Show(opt_Estudar.Text.ToString() );
                    }
                }
                else
                {
                    switch (opt_Agora.Checked)
                    {
                        case true:

                            MessageBox.Show(opt_Agora.Text.ToString());
                            break;

                        default:
                            MessageBox.Show(opt_Depois.Text.ToString());
                            break;

                    }
                }
            }
        }



        private void btn_Igual_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ValorA.Text.Trim() == txt_ValorB.Text.Trim())
                {
                    MessageBox.Show("Valores de A e B são iguais !");
                }
                else
                {
                    MessageBox.Show("Valores de A e B são diferentes !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro testando se campos iguais !  " + ex.Message);
            }

        }

        private void btn_Diferente_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_ValorA.Text.Trim() != txt_ValorB.Text.Trim())
                {
                    MessageBox.Show("Valores de A e B são diferentes !");
                }
                else
                {
                    MessageBox.Show("Valores de A e B são iguais !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro testando se campos diferentes !  " + ex.Message);
            }

        }

        private void btn_Maior_Click(object sender, EventArgs e)
        {
            try
            {

                // Somente funciona para conteúdos numericos
                if (Convert.ToDecimal(txt_ValorA.Text) > Convert.ToDecimal(txt_ValorB.Text))
                {
                    MessageBox.Show("Valor de A é Maior que valor de B !");
                }
                else
                {
                    MessageBox.Show("Valor de A não é maior que valor de B !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro testando operador Maior !  " + ex.Message);
            }

        }

        private void btn_Menor_Click(object sender, EventArgs e)
        {
            try
            {

                // Somente funciona para conteúdos numericos
                if (Convert.ToDecimal(txt_ValorA.Text) < Convert.ToDecimal(txt_ValorB.Text))
                {
                    MessageBox.Show("Valor de A menor é que valor de B !");
                }
                else
                {
                    MessageBox.Show("Valor de A não é menor que valor de B !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro testando operador Menor !  " + ex.Message);
            }

        }

        private void btn_MaiorIgual_Click(object sender, EventArgs e)
        {
            try
            {

                // Somente funciona para conteúdos numericos
                if (Convert.ToDecimal(txt_ValorA.Text) >= Convert.ToDecimal(txt_ValorB.Text))
                {
                    MessageBox.Show("Valor de A Maior ou Igual que valor de B !");
                }
                else
                {
                    MessageBox.Show("Valor de A é menor que valor de B !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro testando operador Maior ou Igual !  " + ex.Message);
            }

        }

        private void btn_MenorIgual_Click(object sender, EventArgs e)
        {
            try
            {

                // Somente funciona para conteúdos numericos
                if (Convert.ToDecimal(txt_ValorA.Text) <= Convert.ToDecimal(txt_ValorB.Text))
                {
                    MessageBox.Show("Valor de A é Menor ou Igual que valor de B !");
                }
                else
                {
                    MessageBox.Show("Valor de A é maior que valor de B !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro testando operador Menor ou Igual !  " + ex.Message);
            }

        }



    }
}
