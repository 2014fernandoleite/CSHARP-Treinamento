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

namespace PrjExercicio08
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Declaração da Classe
        /// </summary>
        class ClsCadastro
        {
            // Campos da Classe
            public string Codigo { get; set; }
            public string Nome { get; set; }

            /// <summary>
            /// Construtor da Classe
            /// </summary>
            public ClsCadastro()
            {
            }

        }

        public Form1()
        {
            InitializeComponent();
        }


        List<ClsCadastro> Cadastro = new List<ClsCadastro>();

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
 
            Cadastro.Add(new ClsCadastro()
            {
                Codigo = txt_Codigo.Text.Trim(),
                Nome = txt_Nome.Text.Trim()
            });
            
            DGV_Dados.DataSource = null;
            DGV_Dados.DataSource = Cadastro;

            cmb_Dados.DataSource = null;
            cmb_Dados.ValueMember = "Codigo";
            cmb_Dados.DisplayMember = "Nome";

            cmb_Dados.DataSource = Cadastro;
            cmb_Dados.Refresh();
            txt_Codigo.Text = "";
            txt_Codigo.Focus();

            txt_Nome.Text = "";

        }


        private void btn_LimparArray_Click(object sender, EventArgs e)
        {
            DGV_Dados.DataSource = null;
            cmb_Dados.DataSource = null;
            Cadastro = new List<ClsCadastro>();
            txt_Codigo.Text = "";
            txt_Codigo.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var itemToRemove = Cadastro.SingleOrDefault(LST_Cadastro => LST_Cadastro.Codigo == txt_Codigo.Text.ToString());
            if (itemToRemove != null)
                Cadastro.Remove(itemToRemove);
            // LST_Cadastro é como se fosse uma imagem da lista utilizada na pesquisa
            // Poderia ser qualquer nome desde que não fosse de um objeto existente também não poderia ser palavra reservada

            DGV_Dados.DataSource = null;
            DGV_Dados.DataSource = Cadastro;

            cmb_Dados.DataSource = null;
            cmb_Dados.ValueMember = "Codigo";
            cmb_Dados.DisplayMember = "Nome";
            cmb_Dados.DataSource = Cadastro;
            cmb_Dados.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
