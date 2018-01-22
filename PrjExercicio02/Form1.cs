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

namespace PrjExercicio02
{
    public partial class Form1 : Form
    {

        string LSTR_Texto = "";
        Int16 LINT_Inteiro16Bits = 0;
        Int32 LINT_Inteiro32Bits = 0;
        Int64 LINT_Inteiro64Bits = 0;
        Decimal LDEC_Decimal = 0;
        Double LDBL_Double = 0;
        DateTime LDAT_Data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {

            LSTR_Texto = txt_Entrada.Text.ToString();
            LDBL_Double = Convert.ToDouble(txt_Entrada.Text.ToString());
            LDEC_Decimal = Convert.ToDecimal(txt_Entrada.Text.ToString());
            LINT_Inteiro64Bits = Convert.ToInt64(txt_Entrada.Text.ToString());
            LINT_Inteiro32Bits = Convert.ToInt32(txt_Entrada.Text.ToString());
            LINT_Inteiro16Bits = Convert.ToInt16(txt_Entrada.Text.ToString());
            LDAT_Data = Convert.ToDateTime(txt_Entrada.Text.ToString());

        }

        private void btn_Texto_Click(object sender, EventArgs e)
        {
            try
            {
                LSTR_Texto = txt_Entrada.Text.ToString();
                MessageBox.Show("É um texto valido! " + LSTR_Texto.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é um texto valido!  " + ex.Message );
            }
        }

        private void Btn_Int16_Click(object sender, EventArgs e)
        {

            try
            {
                LINT_Inteiro16Bits = Convert.ToInt16(txt_Entrada.Text.ToString());
                MessageBox.Show("É um numero de 16 bits valido! " + LINT_Inteiro16Bits.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é um numero de 16 bits valido!  " + ex.Message);
            }


        }

        private void Btn_Int32_Click(object sender, EventArgs e)
        {
            try
            {
                LINT_Inteiro32Bits = Convert.ToInt32(txt_Entrada.Text.ToString());
                MessageBox.Show("É um numero de 32 bits valido! " + LINT_Inteiro32Bits.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é um numero de 32 bits valido!  " + ex.Message);
            }


        }

        private void Btn_Int64_Click(object sender, EventArgs e)
        {
            try
            {
                LINT_Inteiro64Bits = Convert.ToInt64(txt_Entrada.Text.ToString());
                MessageBox.Show("É um numero de 64 bits valido! " + LINT_Inteiro64Bits.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é um numero de 64 bits valido!  " + ex.Message);
            }

        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            try
            {
                LDAT_Data = Convert.ToDateTime(txt_Entrada.Text.ToString());
                MessageBox.Show("É uma data valida ! " + LDAT_Data.ToString() );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é uma data valida!  " + ex.Message);
            }
        }

        private void Btn_Decimal_Click(object sender, EventArgs e)
        {
            try
            {
                LDEC_Decimal = Convert.ToDecimal(txt_Entrada.Text.ToString());
                MessageBox.Show("É um numero decimal valido! " + LDEC_Decimal.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é um numero decimal valido!  " + ex.Message);
            }
        }


        private void Btn_Double_Click(object sender, EventArgs e)
        {
            try
            {
                LDBL_Double = Convert.ToDouble(txt_Entrada.Text.ToString());
                MessageBox.Show("É um numero Double valido! " + LDBL_Double.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é um numero Double valido!  " + ex.Message);
            }

        }
        
    }
}
