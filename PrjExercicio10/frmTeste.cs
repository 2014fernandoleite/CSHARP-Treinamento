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

namespace PrjExercicio10
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void btn_Ler_Click(object sender, EventArgs e)
        {

            try
            {

                clsDados Dados = new clsDados();
                Dados.Sql = "select * from PAIS ";
                cbx_Estado.DisplayMember = "DsPais";
                cbx_Estado.ValueMember = "CdPais";
                clsParametros.EnderecoArquivo = "C:\\";
                cbx_Estado.DataSource = Dados.FU_Pesquisar();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }


        private void cbx_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbx_Estado.SelectedValue != null)
                {
                    if (cbx_Estado.SelectedValue.ToString().Trim() != "")
                    {
                        clsDados Dados = new clsDados();
                        Dados.Sql = "select ESTADO.CdPais, ESTADO.Estado, ESTADO.DsEstado, PAIS.DsPais " +
                                        "  from ESTADO, PAIS " +
                                        " where ESTADO.CdPais = PAIS.CdPais  " +
                                        "   and ESTADO.CdPais =  " + cbx_Estado.SelectedValue.ToString();
                        clsParametros.EnderecoArquivo = "C:\\";
                        DGV_Dados.DataSource = Dados.FU_Pesquisar();
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }


        private void btn_Executar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Comando.Text.Trim() != "")
                {
                    clsParametros.EnderecoArquivo = "C:\\";
                    clsDados Dados = new clsDados();
                    Dados.Sql = txt_Comando.Text.Trim();
                    Dados.FU_Gravar();

                    MessageBox.Show("Comando executado com Sucesso!");
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }


    }

}
