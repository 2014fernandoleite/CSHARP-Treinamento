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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace PrjExercicio15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Selecionar_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;
            DataGridTextColumn Aux = null;

            try
            {

                strSql = "";

                if (CBX_CdPais.SelectedIndex != -1)
                {
                    strSql = " where Cidade.CdPais = " + CBX_CdPais.SelectedValue;
                }
                if (CBX_Estado.SelectedIndex != -1)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cidade.Estado = '" + CBX_Estado.SelectedValue + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cidade.Estado = '" + CBX_Estado.SelectedValue + "'";
                    }
                }
                if (TXT_CdCidade.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cidade.CdCidade = '" + TXT_CdCidade.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cidade.CdCidade = '" + TXT_CdCidade.Text + "'";
                    }
                }
                if (TXT_NmCidade.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cidade.NmCidade like '" + TXT_NmCidade.Text + "%'";
                    }
                    else
                    {
                        strSql = strSql + " and Cidade.NmCidade like '" + TXT_NmCidade.Text + "%'";
                    }
                }


                Dados = new PrjExercicio10.clsDados();

                this.Cursor = Cursors.Wait;

                Dados.Sql = "select Cidade.*, Estado.DsEstado, Pais.DsPais from Cidade";
                Dados.Sql = Dados.Sql + " INNER JOIN Estado ON (Estado.CdPais = Cidade.CdPais and  Estado.Estado = Cidade.Estado)";
                Dados.Sql = Dados.Sql + " INNER JOIN Pais ON (Pais.CdPais = Cidade.CdPais)" + strSql;

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                DTG_Cidade.Columns.Clear();
                DTG_Cidade.AutoGenerateColumns = false;
                DTG_Cidade.IsReadOnly = true;

                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CdPais");
                Aux.Width = 80;
                Aux.Header = "Código";
                Aux.SortMemberPath = "CdPais";
                Aux.Visibility = System.Windows.Visibility.Hidden;
                DTG_Cidade.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("Estado");
                Aux.Width = 80;
                Aux.Header = "Estado";
                Aux.SortMemberPath = "Estado";
                Aux.Visibility = System.Windows.Visibility.Hidden;
                DTG_Cidade.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("DsPais");
                Aux.Width = 100;
                Aux.Header = "Pais";
                Aux.SortMemberPath = "DsPais";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cidade.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("DsEstado");
                Aux.Width = 100;
                Aux.Header = "Estado";
                Aux.SortMemberPath = "DsEstado";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cidade.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CdCidade");
                Aux.Width = 80;
                Aux.Header = "Código";
                Aux.SortMemberPath = "CdCidade";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cidade.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("NmCidade");
                Aux.Width = 200;
                Aux.Header = "Descricão";
                Aux.SortMemberPath = "NmCidade";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cidade.Columns.Add(Aux);

                DTG_Cidade.ItemsSource = Dados.FU_Pesquisar().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Dados = null;
                strSql = null;
                Aux = null;
                this.Cursor = Cursors.Arrow;

            }
        }

        private void BTN_Incluir_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

            try
            {
                if (CBX_CdPais.SelectedIndex == -1)
                {
                    CBX_CdPais.Focus();
                    MessageBox.Show("Código do pais é obrigatório!");
                    return;
                }
                if (CBX_Estado.SelectedIndex == -1)
                {
                    CBX_Estado.Focus();
                    throw new Exception("Estado é obrigatório!");
                }
                if (TXT_CdCidade.Text.Length == 0)
                {
                    TXT_CdCidade.Focus();
                    throw new Exception("Código da cidade é obrigatório!");
                }
                if (TXT_NmCidade.Text.Length == 0)
                {
                    TXT_NmCidade.Focus();
                    throw new Exception("Nome da cidade é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();
                strSql = "Insert into Cidade(CdCidade, NmCidade, CdPais, Estado) Values(";
                strSql = strSql + TXT_CdCidade.Text;
                strSql = strSql + " , '" + TXT_NmCidade.Text + "'";
                strSql = strSql + " , " + CBX_CdPais.SelectedValue;
                strSql = strSql + " , '" + CBX_Estado.SelectedValue + "'";
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
                Dados = null;
            }
        }

        private void BTN_Alterar_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

            try
            {
                if (CBX_CdPais.SelectedIndex == -1)
                {
                    CBX_CdPais.Focus();
                    throw new Exception("Código do pais é obrigatório!");
                }
                if (CBX_Estado.SelectedIndex == -1)
                {
                    CBX_Estado.Focus();
                    throw new Exception("Estado é obrigatório!");
                }
                if (TXT_CdCidade.Text.Length == 0)
                {
                    TXT_CdCidade.Focus();
                    throw new Exception("Código da cidade é obrigatório!");
                }
                if (TXT_NmCidade.Text.Length == 0)
                {
                    TXT_NmCidade.Focus();
                    throw new Exception("Nome da cidade é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();
                strSql = "update Cidade set";
                strSql = strSql + " NmCidade = '" + TXT_NmCidade.Text + "'";
                strSql = strSql + " , CdPais = '" + CBX_CdPais.SelectedValue + "'";
                strSql = strSql + " , Estado = '" + CBX_Estado.SelectedValue + "'";
                strSql = strSql + " WHERE CdCidade = " + TXT_CdCidade.Text;

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
                Dados = null;
            }
        }

        private void BTN_Excluir_Click(object sender, RoutedEventArgs e)
        {
            PrjExercicio10.clsDados Dados = null;

            try
            {
                if (TXT_CdCidade.Text.Length == 0)
                {
                    TXT_CdCidade.Focus();
                    throw new Exception("Código da cidade é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();

                Dados.Sql = "delete from Cidade where CdCidade = " + TXT_CdCidade.Text;

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CarregaComboPais();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaComboPais()
        {
            PrjExercicio10.clsDados Dados = null;
            try
            {
                Dados = new PrjExercicio10.clsDados();
                Dados.Sql = "SELECT * FROM PAIS ORDER BY DsPais";
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                CBX_CdPais.DisplayMemberPath = "DsPais";
                CBX_CdPais.SelectedValuePath = "CdPais";
                CBX_CdPais.ItemsSource = Dados.FU_Pesquisar().DefaultView;
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

        private void CarregaComboEstado(int CdPais)
        {
            string strSql = null;
            PrjExercicio10.clsDados Dados = null;

            try
            {
                Dados = new PrjExercicio10.clsDados();

                strSql = "SELECT * FROM ESTADO";
                if (CdPais > 0)
                {
                    strSql = strSql + " WHERE CdPais = " + CdPais;
                }
                strSql = strSql + " ORDER BY DsEstado";

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                CBX_Estado.DisplayMemberPath = "DsEstado";
                CBX_Estado.SelectedValuePath = "Estado";
                CBX_Estado.ItemsSource = Dados.FU_Pesquisar().DefaultView;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Dados = null;
                strSql = null;
            }
        }

        private void CBX_CdPais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (CBX_CdPais.SelectedIndex != -1 && CBX_CdPais.SelectedValue != null)
                {
                    CarregaComboEstado(Convert.ToInt32(CBX_CdPais.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SU_Montar_Tela(Int32 INT_CdCidade)
        {
            string strSql;
            DataTable LDTT_Cidade;
            PrjExercicio10.clsDados Dados = null;

            try
            {

                if (INT_CdCidade != 0)
                {
                    Dados = new PrjExercicio10.clsDados();
                    strSql = " where CdCidade = " + INT_CdCidade.ToString();
                    Dados.Sql = "select * from CIDADE " + strSql;
                    PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                    LDTT_Cidade = Dados.FU_Pesquisar();
                    if (LDTT_Cidade.Rows.Count > 0)
                    {
                        BTN_Incluir.IsEnabled = false;
                        BTN_Alterar.IsEnabled = true;
                        BTN_Excluir.IsEnabled = true;

                        CBX_CdPais.SelectedValue = LDTT_Cidade.Rows[0]["CdPais"].ToString();

                        // remonta o combo de estados porque pode ter mudado o pais e estar com os estados do outro pais
                        CarregaComboEstado(Convert.ToInt32(LDTT_Cidade.Rows[0]["CdPais"].ToString()));

                        CBX_Estado.SelectedValue = LDTT_Cidade.Rows[0]["Estado"].ToString();
                        TXT_CdCidade.Text = LDTT_Cidade.Rows[0]["CdCidade"].ToString();
                        TXT_NmCidade.Text = LDTT_Cidade.Rows[0]["NmCidade"].ToString();
                    }
                    else
                    {
                        TXT_NmCidade.Text = "";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LDTT_Cidade = null;
                Dados = null;
                strSql = null;
            }
        }


        private void TXT_CdCidade_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TXT_CdCidade.Text.Trim() != "")
                {
                    SU_Montar_Tela(Convert.ToInt32(TXT_CdCidade.Text.Trim()));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DTG_Cidade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            object LOBJ_Retorno = null;
            Int32 INT_CdCidade = 0;

            try
            {

                if (DTG_Cidade.SelectedIndex != -1)
                {
                    LOBJ_Retorno = ((DataRowView)DTG_Cidade.SelectedItem)["CdCidade"].ToString();
                    INT_CdCidade = Convert.ToInt32(LOBJ_Retorno.ToString());

                    SU_Montar_Tela(INT_CdCidade);
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
                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

                CBX_CdPais.SelectedIndex = -1;
                CBX_Estado.SelectedIndex = -1;
                TXT_CdCidade.Text = "";
                TXT_NmCidade.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
