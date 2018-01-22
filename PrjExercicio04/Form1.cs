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

namespace PrjExercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_While_Click(object sender, EventArgs e)
        {
            int INT_Cont = 0;

            while (INT_Cont < this.Controls.Count)
            {
                Control x = this.Controls[INT_Cont];
                if (x is TextBox)
                {

                    if (((TextBox)x).Text.Trim() == "")
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = x.Name.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será limpo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = String.Empty;
                    }

                }
                else if (x is CheckBox)
                {
                    if (((CheckBox)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((CheckBox)x).Checked = !((CheckBox)x).Checked;
                }
                else if (x is RadioButton)
                {

                    if (((RadioButton)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((RadioButton)x).Checked = !((RadioButton)x).Checked;

                }
                else
                {
                    MessageBox.Show("O controle " + x.Name.ToString() + " é um: " + x.GetType().ToString());
                }
                INT_Cont++;
            }
            
        }

        private void btn_doWhile_Click(object sender, EventArgs e)
        {
            int INT_Cont = 0;

            do
            {
                Control x = this.Controls[INT_Cont];
                if (x is TextBox)
                {

                    if (((TextBox)x).Text.Trim() == "")
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = x.Name.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será limpo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = String.Empty;
                    }

                }
                else if (x is CheckBox)
                {
                    if (((CheckBox)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((CheckBox)x).Checked = !((CheckBox)x).Checked;
                }
                else if (x is RadioButton)
                {

                    if (((RadioButton)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((RadioButton)x).Checked = !((RadioButton)x).Checked;

                }
                else
                {
                    MessageBox.Show("O controle " + x.Name.ToString() + " é um: " + x.GetType().ToString());
                }

                INT_Cont++;
            } while (INT_Cont < this.Controls.Count);
        }

        private void btn_For_Click(object sender, EventArgs e)
        {
            for (int INT_Cont = 0; INT_Cont < this.Controls.Count; INT_Cont++)
            {
                Control x = this.Controls[INT_Cont];
                if (x is TextBox)
                {

                    if (((TextBox)x).Text.Trim() == "")
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = x.Name.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será limpo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = String.Empty;
                    }

                }
                else if (x is CheckBox)
                {
                    if (((CheckBox)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((CheckBox)x).Checked = !((CheckBox)x).Checked;
                }
                else if (x is RadioButton)
                {

                    if (((RadioButton)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((RadioButton)x).Checked = !((RadioButton)x).Checked;

                }
                else
                {
                    MessageBox.Show("O controle " + x.Name.ToString() + " é um: " + x.GetType().ToString());
                }

            }
        }

        private void btn_ForEach_Click(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {

                    if (((TextBox)x).Text.Trim() == "")
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = x.Name.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será limpo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ((TextBox)x).Text = String.Empty;
                    }

                }
                else if (x is CheckBox)
                {
                    if (((CheckBox)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((CheckBox)x).Checked = !((CheckBox)x).Checked;
                }
                else if (x is RadioButton)
                {

                    if (((RadioButton)x).Checked == true)
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será desmarcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O controle " + x.Name.ToString() + " será marcado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    ((RadioButton)x).Checked = !((RadioButton)x).Checked;

                }
                else
                {
                    MessageBox.Show("O controle " + x.Name.ToString() + " é um: " + x.GetType().ToString());
                }
            }

        }

    }
}
