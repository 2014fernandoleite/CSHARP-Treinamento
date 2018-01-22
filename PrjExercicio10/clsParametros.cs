// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjExercicio10
{
    public static class clsParametros
    {

        private static string PSTR_EnderecoArquivo = "";
        private static string PSTR_Servidor;
        private static string PSTR_Banco;
        private static string PSTR_Usuario;
        private static string PSTR_Senha;
        private static string PSTR_Conexao;

        static public string Conexao
        {
            get { return PSTR_Conexao; }
            set { PSTR_Conexao = value; }
        }

        static public string EnderecoArquivo
        {
            get { return PSTR_EnderecoArquivo; }
            set { PSTR_EnderecoArquivo = value; }
        }

        static public string Servidor
        {
            get { return PSTR_Servidor; }
            set { PSTR_Servidor = value; }
        }

        static public string Banco
        {
            get { return PSTR_Banco; }
            set { PSTR_Banco = value; }
        }

        static public string Usuario
        {
            get { return PSTR_Usuario; }
            set { PSTR_Usuario = value; }
        }

        static public string Senha
        {
            get { return PSTR_Senha; }
            set { PSTR_Senha = value; }
        }

    }

}
