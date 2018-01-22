// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

namespace PrjExercicio12.seguro
{
    public partial class PaisDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Selecionar_Click(object sender, EventArgs e)
        {
            string strSql;

            try
            {

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();
                strSql = "";

                if (TXT_CdPais.Text.Length > 0)
                {
                    strSql = " where CdPais = " + TXT_CdPais.Text;
                }
                if (TXT_DsPais.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where DsPais = '" + TXT_DsPais.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and DsPais = '" + TXT_DsPais.Text + "'";
                    }
                }

                Dados.Sql = "select * from pais" + strSql;

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                GridView1.DataSource = Dados.FU_Pesquisar();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                LBL_Mensagem.Text = ex.Message;
            }
        }

        protected void BTN_Incluir_Click(object sender, EventArgs e)
        {
            string strSql;

            try
            {
                if (TXT_CdPais.Text.Length == 0)
                {
                    throw new Exception("Código do pais é obrigatório!");
                }
                if (TXT_DsPais.Text.Length == 0)
                {
                    throw new Exception("Descrição do pais é obrigatório!");
                }

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();
                strSql = "Insert into Pais(CdPais, DsPais) Values(";
                strSql = strSql + TXT_CdPais.Text;
                strSql = strSql + " , '" + TXT_DsPais.Text + "'";
                strSql = strSql + " )";

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                LBL_Mensagem.Text = ex.Message;
            }
        }

        protected void BTN_Alterar_Click(object sender, EventArgs e)
        {
            string strSql;

            try
            {
                if (TXT_CdPais.Text.Length == 0)
                {
                    throw new Exception("Código do pais é obrigatório!");
                }
                if (TXT_DsPais.Text.Length == 0)
                {
                    throw new Exception("Descrição do pais é obrigatório!");
                }

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();
                strSql = "update Pais set";
                strSql = strSql + " DsPais = '" + TXT_DsPais.Text + "'";
                strSql = strSql + " WHERE CdPais = " + TXT_CdPais.Text;

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                LBL_Mensagem.Text = ex.Message;
            }
        }

        protected void BTN_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_CdPais.Text.Length == 0)
                {
                    throw new Exception("Código do pais é obrigatório!");
                }

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();

                Dados.Sql = "delete from Pais where CdPais = " + TXT_CdPais.Text;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                LBL_Mensagem.Text = ex.Message;
            }
        }

        protected void BTN_LogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("../default.aspx");
        }
    }
}