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
using System.Web.Security;

namespace PrjExercicio12.seguro
{
    public partial class PaisWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                wsPais.wsPaisSoapClient sPais = new wsPais.wsPaisSoapClient();
                wsPais.clsPais cPais = new wsPais.clsPais();

                if (TXT_CdPais.Text.Length > 0)
                {
                    cPais.CdPais = Convert.ToInt32(TXT_CdPais.Text);
                }
                if (TXT_DsPais.Text.Length > 0)
                {
                    cPais.DsPais = TXT_DsPais.Text;
                }

                GridView1.DataSource = sPais.wmSelecionar(cPais).Tables[0];
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                LBL_Mensagem.Text = ex.Message;
            }
        }

        protected void BTN_Incluir_Click(object sender, EventArgs e)
        {
            try
            {
                wsPais.wsPaisSoapClient sPais = new wsPais.wsPaisSoapClient();
                wsPais.clsPais cPais = new wsPais.clsPais();

                cPais.CdPais = Convert.ToInt32(TXT_CdPais.Text);
                cPais.DsPais = TXT_DsPais.Text;

                sPais.wmIncluir(cPais);
            }
            catch (Exception ex)
            {
                LBL_Mensagem.Text = ex.Message;
            }
        }

        protected void BTN_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                wsPais.wsPaisSoapClient sPais = new wsPais.wsPaisSoapClient();
                wsPais.clsPais cPais = new wsPais.clsPais();

                cPais.CdPais = Convert.ToInt32(TXT_CdPais.Text);
                cPais.DsPais = TXT_DsPais.Text;

                sPais.wmAtualizar(cPais);
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

                wsPais.wsPaisSoapClient sPais = new wsPais.wsPaisSoapClient();
                wsPais.clsPais cPais = new wsPais.clsPais();

                cPais.CdPais = Convert.ToInt32(TXT_CdPais.Text);

                sPais.wmExcluir(cPais);
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