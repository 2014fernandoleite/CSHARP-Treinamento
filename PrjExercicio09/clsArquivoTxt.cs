// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PrjExercicio09
{
    class clsArquivoTxt
    {

        public void FU_Gravar(string Servidor, string BancoDados, string Usuario, string Senha)
        {
            StreamWriter STW_Arquivo;
            STW_Arquivo = new StreamWriter("C:\\teste.txt");
            STW_Arquivo.WriteLine("Servidor:" + Servidor.Trim());
            STW_Arquivo.WriteLine("BancoDados:" + BancoDados.Trim());
            STW_Arquivo.WriteLine("Usuario:" + Usuario.Trim());
            STW_Arquivo.WriteLine("Senha:" + Senha.Trim());
            STW_Arquivo.Close();
        }

        public string FU_Ler()
        {

            string TextoFinal = "";

            try
            {
                StreamReader STR_Arquivo;
                STR_Arquivo = new StreamReader("C:\\teste.txt");
                string linha;

                while ((linha = STR_Arquivo.ReadLine()) != null)
                {
                    //TextoFinal = TextoFinal + linha + " \r\n";
                    TextoFinal += linha + " \r\n";
                }
                STR_Arquivo.Close();
            }
            catch (Exception ex)
            {
                TextoFinal = ex.Message.ToString();
            }

            return TextoFinal;
        }

    }
}
