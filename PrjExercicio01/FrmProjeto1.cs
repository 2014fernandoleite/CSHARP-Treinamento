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

namespace PrjExercicio01
{
    public partial class FrmProjeto1 : Form
    {

        public FrmProjeto1()
        {
            InitializeComponent();
        }


        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            // fecha a tela
            Close();

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Meu primeiro Programa");

            ClsProjeto1 LCLS_Projeto1;
            LCLS_Projeto1 = new ClsProjeto1();
            MessageBox.Show(LCLS_Projeto1.FU_Mensagem() );

        }

    }
}
