// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PrjExercicio10
{
    public class clsDados
    {
        private string PSTR_Sql = "";
        private SqlConnection CNN_Connection = null;
        private SqlCommand CMD_Comando = null;
        private SqlDataAdapter SDA_Adapter = null;

        public string Sql
        {
            get { return PSTR_Sql; }
            set { PSTR_Sql = value; }
        }

        public bool FU_Gravar()
        {
            try
            {
                clsConfig Config = new clsConfig();
                Config.FU_Ler();
                if (clsParametros.EnderecoArquivo == "")
                {
                    throw new Exception("Erro: Endereco do arquivo com a configuração da conexão com o banco deve ser informado.");
                }
                CNN_Connection = new SqlConnection();
                CNN_Connection.ConnectionString = clsParametros.Conexao;
                CNN_Connection.Open();

                if (CNN_Connection.State != ConnectionState.Open)
                {
                    throw new Exception("Erro: Não foi possivel abrir a conexão.");
                }
                if (Sql.Trim() == "")
                {
                    throw new Exception("Erro: Não foi informado um comando SQL.");
                }
                CMD_Comando = new SqlCommand();
                CMD_Comando.Connection = CNN_Connection;
                CMD_Comando.CommandType = CommandType.Text;
                CMD_Comando.CommandText = Sql;
                CMD_Comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Sql = "";
                CMD_Comando.Dispose();
                CNN_Connection.Close();
            }
        }


        public DataTable FU_Pesquisar()
        {
            DataTable DTT_Resultado = null;
            clsConfig Config = new clsConfig();
            if (clsParametros.EnderecoArquivo == "")
            {
                throw new Exception("Erro: Endereco do arquivo com a configuração da conexão com o banco deve ser informado.");
            }
            
            if (Sql.Trim() == "")
            {
                throw new Exception("Erro: Não foi informado um comando SQL.");
            }
            try
            {
                Config.FU_Ler();
                CNN_Connection = new SqlConnection(clsParametros.Conexao);
                CNN_Connection.Open();
                if (CNN_Connection.State != ConnectionState.Open)
                {
                    throw new Exception("Erro: Não foi possivel abrir a conexão.");
                }
                SDA_Adapter = new System.Data.SqlClient.SqlDataAdapter(Sql, CNN_Connection);
                DTT_Resultado = new DataTable();
                SDA_Adapter.Fill(DTT_Resultado);

                return DTT_Resultado;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Sql = "";
                SDA_Adapter.Dispose();
                CNN_Connection.Close();
            }

        }

    }
}
