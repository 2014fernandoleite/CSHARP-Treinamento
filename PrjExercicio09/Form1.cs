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


namespace PrjExercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {

            clsArquivoTxt LCLS_ArquivoTxt = new clsArquivoTxt();
            LCLS_ArquivoTxt.FU_Gravar(txt_Servidor.Text.ToString(), txt_Banco.Text.ToString(), txt_Usuario.Text.ToString(), txt_Senha.Text.ToString());

            txt_Servidor.Text = "";
            txt_Banco.Text = "";
            txt_Usuario.Text = "";
            txt_Senha.Text = "";
        }


        private void btn_Ler_Click(object sender, EventArgs e)
        {
            clsArquivoTxt LCLS_ArquivoTxt = new clsArquivoTxt();
            txt_Ler.Text = LCLS_ArquivoTxt.FU_Ler();
        }

        private void btn_GravarXML_Click(object sender, EventArgs e)
        {
            ClsArquivoXML LCLS_ArquivoXML = new ClsArquivoXML();
            LCLS_ArquivoXML.FU_GravarXml(txt_Servidor.Text.ToString(), txt_Banco.Text.ToString(), txt_Usuario.Text.ToString(), txt_Senha.Text.ToString());
            txt_Servidor.Text = "";
            txt_Banco.Text = "";
            txt_Usuario.Text = "";
            txt_Senha.Text = "";
        }

        private void btn_LerXml_Click(object sender, EventArgs e)
        {
            ClsArquivoXML LCLS_ArquivoXML = new ClsArquivoXML();
            txt_Ler.Text = LCLS_ArquivoXML.FU_LerXML();
        }

    }
}
