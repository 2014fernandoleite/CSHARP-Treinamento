// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;

namespace PrjExercicio13
{
    /// <summary>
    /// Interaction logic for PaisDB.xaml
    /// </summary>
    public partial class PaisDB : Window
    {
        public PaisDB()
        {
            InitializeComponent();
        }

        private void BTN_Incluir_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

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

                Dados = new PrjExercicio10.clsDados();
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strSql = null;
                Dados = null; 
            }
        }

        private void BTN_Alterar_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

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

                Dados = new PrjExercicio10.clsDados();
                strSql = "update Pais set";
                strSql = strSql + " DsPais = '" + TXT_DsPais.Text + "'";
                strSql = strSql + " WHERE CdPais = " + TXT_CdPais.Text;

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strSql = null;
                Dados = null;
            }
        }

        private void BTN_Excluir_Click(object sender, RoutedEventArgs e)
        {
            PrjExercicio10.clsDados Dados = null;
            try
            {
                if (TXT_CdPais.Text.Length == 0)
                {
                    throw new Exception("Código do pais é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();

                Dados.Sql = "delete from Pais where CdPais = " + TXT_CdPais.Text;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Dados = null;
            }
        }

        private void BTN_Selecionar_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;
            DataGridTextColumn Aux = null;

            try
            {

                Dados = new PrjExercicio10.clsDados();
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

                DTG_Pais.Columns.Clear();
                DTG_Pais.AutoGenerateColumns = false;
                DTG_Pais.IsReadOnly = true;

                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CdPais");
                Aux.Width = 80;
                Aux.Header = "Código";
                Aux.SortMemberPath = "CdPais";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Pais.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("DsPais");
                Aux.Width = 200;
                Aux.Header = "Descricão";
                Aux.SortMemberPath = "DsPais";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Pais.Columns.Add(Aux);

                DTG_Pais.ItemsSource = Dados.FU_Pesquisar().DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strSql = null;
                Dados = null;
                Aux = null;
            }
        }

        private void SU_Montar_Tela(Int32 INT_CdPais)
        {
            string strSql;
            DataTable LDTT_Pais;
            PrjExercicio10.clsDados Dados = null;

            try
            {

                if (INT_CdPais != 0)
                {
                    Dados = new PrjExercicio10.clsDados();
                    strSql = " where CdPais = " + INT_CdPais.ToString();
                    Dados.Sql = "select * from pais" + strSql;
                    PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                    LDTT_Pais = Dados.FU_Pesquisar();
                    if (LDTT_Pais.Rows.Count > 0)
                    {
                        BTN_Incluir.IsEnabled = false;
                        BTN_Alterar.IsEnabled = true;
                        BTN_Excluir.IsEnabled = true;

                        TXT_CdPais.Text = LDTT_Pais.Rows[0]["CdPais"].ToString();
                        TXT_DsPais.Text = LDTT_Pais.Rows[0]["DsPais"].ToString();
                    }
                    else
                    {
                        TXT_DsPais.Text = "";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LDTT_Pais = null;
                strSql = null;
                Dados = null;
            }
        }

        private void TXT_CdPais_LostFocus(object sender, RoutedEventArgs e)
        {

            try
            {
                if (TXT_CdPais.Text.Trim() != "")
                {
                    try
                    {
                        if (Convert.ToInt32(TXT_CdPais.Text.Trim()) != 0)
                        {
                            SU_Montar_Tela(Convert.ToInt32(TXT_CdPais.Text.Trim()));
                        }
                    }
                    catch
                    {
                        throw;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DTG_Pais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            object LOBJ_Retorno = null;
            Int32 INT_CdPais = 0;

            try
            {

                if (DTG_Pais.SelectedIndex != -1)
                {
                    LOBJ_Retorno = ((DataRowView)DTG_Pais.SelectedItem)["CdPais"].ToString();
                    INT_CdPais = Convert.ToInt32(LOBJ_Retorno.ToString());

                    SU_Montar_Tela(INT_CdPais);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
                LOBJ_Retorno = null;
            }
        }

        private void BTN_Limpar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                TXT_CdPais.Text = "";
                TXT_DsPais.Text = "";
                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
