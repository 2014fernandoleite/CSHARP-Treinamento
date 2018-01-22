// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Linq;
using System.Xml;

namespace PrjExercicio09
{
    class ClsArquivoXML
    {

        public void FU_GravarXml(string Servidor, string BancoDados, string Usuario, string Senha)
        {

            XmlTextWriter xtw = new XmlTextWriter("c:\\Config.xml", Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;
            xtw.WriteStartDocument();

            // Inicia um Registro
            xtw.WriteStartElement("Config");
            xtw.WriteElementString("Servidor", Servidor.ToString());
            xtw.WriteElementString("Banco", BancoDados.ToString());
            xtw.WriteElementString("Usuario", Usuario.ToString());
            xtw.WriteElementString("Senha", Senha.ToString());
            // Finaliza o Registro
            xtw.WriteEndElement();

            // Um novo registro teria novamente ==> xtw.WriteStartElement("Config");
            
            xtw.Close();

        }

        public string FU_LerXML()
        {

            string LSTR_Resultado = "";

            try
            {
                //Define o caminho do arquivo XML 
                string ArquivoXML = "c:\\Config.xml";
                //carrega o arquivo XML
                XElement xml = XElement.Load(ArquivoXML);

                foreach (XElement x in xml.Elements())
                {
                    //LSTR_Resultado = LSTR_Resultado + x.Name + " = " + x.Value + " \r\n";
                    LSTR_Resultado += x.Name + " = " + x.Value + " \r\n";
                }

                xml = null;

            }
            catch (Exception ex)
            {
                LSTR_Resultado = ex.Message.ToString();
            }

            return LSTR_Resultado;

        }

    }


}
