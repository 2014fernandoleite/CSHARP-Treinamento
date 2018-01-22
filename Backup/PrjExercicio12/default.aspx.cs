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

namespace PrjExercicio12
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginDB_Click(object sender, EventArgs e)
        {
            LBL_Mensagem.Text = "";

            if (TXT_Login.Text == "Visitante" && TXT_Senha.Text == "1234")
            {
                FormsAuthentication.RedirectFromLoginPage(TXT_Login.Text, false);
                Response.Redirect("seguro/PaisDB.aspx");
            }
            else
            {
                LBL_Mensagem.Text = "Login inválido!";
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            LBL_Mensagem.Text = "";

            if (TXT_Login.Text == "Visitante" && TXT_Senha.Text == "1234")
            {
                FormsAuthentication.RedirectFromLoginPage(TXT_Login.Text, false);
                Response.Redirect("seguro/PaisWS.aspx");
            }
            else
            {
                LBL_Mensagem.Text = "Login inválido!";
            }
        }
    }
}