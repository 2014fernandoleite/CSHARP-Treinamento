// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace PrjExercicio10
{
    class clsConfig
    {
        
        public void FU_Ler()
        {
            XmlDocument oXML = new XmlDocument();

            //Define o caminho do arquivo XML 
            string ArquivoXML = clsParametros.EnderecoArquivo + "\\Config.xml";

            oXML.Load(ArquivoXML);

            clsParametros.Servidor = oXML.SelectSingleNode("Config").ChildNodes[0].InnerText.ToString();
            clsParametros.Banco = oXML.SelectSingleNode("Config").ChildNodes[1].InnerText.ToString();
            clsParametros.Usuario = oXML.SelectSingleNode("Config").ChildNodes[2].InnerText.ToString();
            clsParametros.Senha = oXML.SelectSingleNode("Config").ChildNodes[3].InnerText.ToString();

            clsParametros.Conexao = "Data Source=" + clsParametros.Servidor + ";Initial Catalog=" + clsParametros.Banco + ";User Id=" + clsParametros.Usuario + ";Password=" + clsParametros.Senha + ";";
        }

        public bool FU_TestaConexao()
        {
            try
            {
                clsParametros.Conexao = "Data Source=" + clsParametros.Servidor + ";Initial Catalog=" + clsParametros.Banco + ";User Id=" + clsParametros.Usuario + ";Password=" + clsParametros.Senha + ";";

                SqlCommand SQL_CMD = new SqlCommand();
                SqlConnection SQL_Conection = new SqlConnection();


                SQL_Conection.ConnectionString = clsParametros.Conexao;
                SQL_Conection.Open();

                if (SQL_Conection.State == ConnectionState.Closed)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //public void FU_Gravar()
        //{
        //    //PSTR_EnderecoArquivo = Directory.GetCurrentDirectory().ToString();
        //    XmlTextWriter xtw = new XmlTextWriter(clsParametros.EnderecoArquivo + "\\Config.xml", Encoding.UTF8);
        //    xtw.Formatting = Formatting.Indented;
        //    xtw.WriteStartDocument();

        //    xtw.WriteStartElement("Config");
        //    xtw.WriteElementString("Servidor", clsParametros.Servidor.ToString());
        //    xtw.WriteElementString("Banco", clsParametros.Banco.ToString());
        //    xtw.WriteElementString("Usuario", clsParametros.Usuario.ToString());
        //    xtw.WriteElementString("Senha", clsParametros.Senha.ToString());
        //    xtw.WriteEndElement();
        //    xtw.Close();


        //}

    }
}
