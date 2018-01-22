// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace PrjExercicio11
{
    /// <summary>
    /// Summary description for wsPais
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPais : System.Web.Services.WebService
    {

        [WebMethod]
        public void wmIncluir(clsPais cPais)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

            try
            {
                if (cPais == null)
                {
                    throw new Exception("Classe pais não foi iniciada!");
                }
                if (cPais.CdPais == 0)
                {
                    throw new Exception("Código do pais não foi Informado!");
                }
                if (cPais.DsPais == null)
                {
                    throw new Exception("Descrição do pais não foi iniciada!");
                }
                
                if (cPais.DsPais.ToString().Length == 0)
                {
                    throw new Exception("Descrição do pais é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();
                strSql = "Insert into Pais(CdPais, DsPais) Values(";
                strSql = strSql + cPais.CdPais;
                strSql = strSql + " , '" + cPais.DsPais + "'";
                strSql = strSql + " )";

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Dados = null;
            }

        }

        [WebMethod]
        public void wmAtualizar(clsPais cPais)
        {
            string strSql;

            try
            {
                if (cPais == null)
                {
                    throw new Exception("Classe pais não foi iniciada!");
                }
                if (cPais.CdPais == 0)
                {
                    throw new Exception("Código do pais não foi iniciado!");
                }
                if (cPais.DsPais == null)
                {
                    throw new Exception("Descrição do pais não foi iniciada!");
                }
               
                if (cPais.DsPais.ToString().Length == 0)
                {
                    throw new Exception("Descrição do pais é obrigatório!");
                }

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();
                strSql = "update Pais set";
                strSql = strSql + " DsPais = '" + cPais.DsPais + "'";
                strSql = strSql + " WHERE CdPais = " + cPais.CdPais;

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [WebMethod]
        public void wmExcluir(clsPais cPais)
        {
            try
            {
                if (cPais == null)
                {
                    throw new Exception("Classe pais não foi iniciada!");
                }
                if (cPais.CdPais == 0)
                {
                    throw new Exception("Código do pais não foi iniciado!");
                }

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();

                Dados.Sql = "delete from Pais where CdPais = " + cPais.CdPais;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [WebMethod]
        public DataSet wmSelecionar(clsPais cPais)
        {
            DataSet dtsRetorno = null;
            string strSql;

            try
            {

                PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();
                strSql = "";

                if (cPais.CdPais > 0)
                {
                    strSql = " where CdPais = " + cPais.CdPais;
                }
                
                if (strSql.Length == 0)
                {
                    if (cPais.DsPais != null)
                    {
                        if (cPais.DsPais.Length > 0)
                        {
                            strSql = " where DsPais like '" + cPais.DsPais + "%'";
                        }
                    }
                }

                Dados.Sql = "select * from pais" + strSql;

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                dtsRetorno = new DataSet();
                dtsRetorno.Tables.Add(Dados.FU_Pesquisar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dtsRetorno;
        }

        private void InitializeComponent()
        {

        }
    }
}
