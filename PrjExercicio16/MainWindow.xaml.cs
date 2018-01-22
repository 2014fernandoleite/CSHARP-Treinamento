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

namespace PrjExercicio16
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

        private void CBX_CdPais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (CBX_CdPais.SelectedIndex != -1 && CBX_CdPais.SelectedValue != null)
                {
                    CarregaComboEstado(Convert.ToInt32(CBX_CdPais.SelectedValue));
                }
                else
                {
                    CBX_Estado.ItemsSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CarregaComboEstado(int CdPais)
        {
            string strSql;
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
            }
        }

        private void CBX_Estado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (CBX_Estado.SelectedIndex != -1 && CBX_Estado.SelectedValue != null)
                {
                    CarregaComboCidade(Convert.ToInt32(CBX_CdPais.SelectedValue), CBX_Estado.SelectedValue.ToString());
                }
                else
                {
                    CBX_CdCidade.ItemsSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaComboCidade(int INT_CdPais, string STR_Estado)
        {
            string strSQL = null;
            PrjExercicio10.clsDados Dados = null;

            try
            {
                Dados = new PrjExercicio10.clsDados();

                strSQL = " where CdPais = " + INT_CdPais;
                strSQL = strSQL + " and Estado = '" + STR_Estado + "'";

                Dados.Sql = "SELECT * FROM CIDADE " + strSQL + " ORDER BY NmCidade";

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                CBX_CdCidade.DisplayMemberPath = "NmCidade";
                CBX_CdCidade.SelectedValuePath = "CdCidade";
                CBX_CdCidade.ItemsSource = Dados.FU_Pesquisar().DefaultView;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                strSQL = null;
                Dados = null;
            }
        }


        private void BTN_Limpar_Click(object sender, RoutedEventArgs e)
        {
            SU_Limpar_Tela();
        }

        private void SU_Limpar_Tela()
        {

            try
            {
                TXT_NmCliente.Text = "";
                TXT_Endereco.Text = "";
                TXT_Bairro.Text = "";
                TXT_CEP.Text = "";
                TXT_EndEmail.Text = "";
                TXT_DocIdentif.Text = "";
                TXT_GcgCpf.Text = "";
                TXT_CdCliente.Text = "";

                CBX_CdPais.SelectedIndex = -1;
                CBX_Estado.ItemsSource = null;
                CBX_CdCidade.ItemsSource = null;

                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void BTN_Selecionar_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

            try
            {

                Dados = new PrjExercicio10.clsDados();
                strSql = "";

                if (CBX_CdCidade.SelectedIndex != -1)
                {
                    strSql = " where Cliente.CdCidade = " + CBX_CdCidade.SelectedValue;
                }

                if (CBX_CdPais.SelectedIndex != -1)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cidade.CdPais = " + CBX_CdPais.SelectedValue;
                    }
                    else
                    {
                        strSql = " and Cidade.CdPais = " + CBX_CdPais.SelectedValue;
                    }
                }

                if (CBX_Estado.SelectedIndex != -1)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cidade.Estado = '" + CBX_Estado.SelectedValue + "'";
                    }
                    else
                    {
                        strSql = " and Cidade.Estado = '" + CBX_Estado.SelectedValue + "'";
                    }
                }

                if (TXT_NmCliente.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.NmCliente like '" + TXT_NmCliente.Text + "%'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.NmCliente like '" + TXT_NmCliente.Text + "%'";
                    }
                }
                if (TXT_GcgCpf.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.CgcCpf = '" + TXT_GcgCpf.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.CgcCpf = '" + TXT_GcgCpf.Text + "'";
                    }
                }
                if (TXT_Endereco.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.Endereco = '" + TXT_Endereco.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.Endereco = '" + TXT_Endereco.Text + "'";
                    }
                }
                if (TXT_Bairro.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.Bairro = '" + TXT_Bairro.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.Bairro = '" + TXT_Bairro.Text + "'";
                    }
                }
                if (TXT_CEP.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.CEP = '" + TXT_CEP.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.CEP = '" + TXT_CEP.Text + "'";
                    }
                }
                if (TXT_EndEmail.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.EndEmail = '" + TXT_EndEmail.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.EndEmail = '" + TXT_EndEmail.Text + "'";
                    }
                }
                if (TXT_DocIdentif.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where Cliente.DocIdentif = '" + TXT_DocIdentif.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and Cliente.DocIdentif = '" + TXT_DocIdentif.Text + "'";
                    }
                }

                Dados.Sql = "select Cliente.*, CIDADE.CdPais, CIDADE.Estado from Cliente INNER JOIN Cidade ON (Cidade.CdCidade = Cliente.CdCidade) " + strSql;

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                DTG_Cliente.Columns.Clear();
                DTG_Cliente.AutoGenerateColumns = false;
                DTG_Cliente.IsReadOnly = true;

                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

                DataGridTextColumn Aux = null;

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CdCidade");
                Aux.Width = 80;
                Aux.Header = "Código";
                Aux.SortMemberPath = "CdCidade";
                Aux.Visibility = System.Windows.Visibility.Hidden;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CdCliente");
                Aux.Width = 80;
                Aux.Header = "Código";
                Aux.SortMemberPath = "CdCliente";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("NmCliente");
                Aux.Width = 200;
                Aux.Header = "Nome";
                Aux.SortMemberPath = "NmCliente";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CgcCpf");
                Aux.Width = 100;
                Aux.Header = "Cgc/Cpf";
                Aux.SortMemberPath = "CgcCpf";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("DocIdentif");
                Aux.Width = 100;
                Aux.Header = "Identidade";
                Aux.SortMemberPath = "DocIdentif";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("Endereco");
                Aux.Width = 200;
                Aux.Header = "Endereço";
                Aux.SortMemberPath = "Endereco";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("Bairro");
                Aux.Width = 100;
                Aux.Header = "Bairro";
                Aux.SortMemberPath = "Bairro";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("Cep");
                Aux.Width = 80;
                Aux.Header = "Cep";
                Aux.SortMemberPath = "Cep";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("NmCidade");
                Aux.Width = 100;
                Aux.Header = "Cidade";
                Aux.SortMemberPath = "NmCidade";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("EndEmail");
                Aux.Width = 100;
                Aux.Header = "Email";
                Aux.SortMemberPath = "EndEmail";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Cliente.Columns.Add(Aux);

                DTG_Cliente.ItemsSource = Dados.FU_Pesquisar().DefaultView;

                SU_Limpar_Tela();

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

        private void BTN_Incluir_Click(object sender, RoutedEventArgs e)
        {
            string strSql;
            PrjExercicio10.clsDados Dados = null;

            try
            {
                if (CBX_CdCidade.SelectedIndex == -1)
                {
                    throw new Exception("Código da cidade é obrigatório!");
                }

                if (TXT_CdCliente.Text.Length == 0)
                {
                    throw new Exception("Código do cliente é obrigatório!");
                }

                if (TXT_NmCliente.Text.Length == 0)
                {
                    throw new Exception("Nome do cliente é obrigatório!");
                }
                if (TXT_GcgCpf.Text.Length == 0)
                {
                    throw new Exception("Cgc/Cpf do cliente é obrigatório!");
                }
                if (TXT_Endereco.Text.Length == 0)
                {
                    throw new Exception("Endereço do cliente é obrigatório!");
                }
                if (TXT_Bairro.Text.Length == 0)
                {
                    throw new Exception("Bairro do cliente é obrigatório!");
                }
                if (TXT_CEP.Text.Length == 0)
                {
                    throw new Exception("Cep do cliente é obrigatório!");
                }
             
                if (TXT_DocIdentif.Text.Length == 0)
                {
                    throw new Exception("Identidade do cliente é obrigatório!");
                }

                if (TXT_EndEmail.Text.Trim() != "")
                {
                    if (ClsValidacao.Fu_Consistir_Email(TXT_EndEmail.Text) == false)
                    {
                        throw new Exception("Endereço de Email informado é inválido!");
                    }
                }


                Dados = new PrjExercicio10.clsDados();
                strSql = "Insert into Cliente(CdCliente, NmCliente, CgcCpf, Endereco, Bairro, Cep, CdCidade, EndEmail, DocIdentif) Values(";
                strSql = strSql + TXT_CdCliente.Text;
                strSql = strSql + " , '" + TXT_NmCliente.Text + "'";
                strSql = strSql + " , " + TXT_GcgCpf.Text;
                strSql = strSql + " , '" + TXT_Endereco.Text + "'";
                strSql = strSql + " , '" + TXT_Bairro.Text + "'";
                strSql = strSql + " , " + TXT_CEP.Text;
                strSql = strSql + " , " + CBX_CdCidade.SelectedValue;
                strSql = strSql + " , '" + TXT_EndEmail.Text + "'";
                strSql = strSql + " , '" + TXT_DocIdentif.Text + "'";
                strSql = strSql + " )";

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();

                SU_Limpar_Tela();
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
                if (TXT_CdCliente.Text.Length == 0)
                {
                    throw new Exception("Código do cliente é obrigatório!");
                }
                if (TXT_NmCliente.Text.Length == 0)
                {
                    throw new Exception("Nome do cliente é obrigatório!");
                }
                if (TXT_GcgCpf.Text.Length == 0)
                {
                    throw new Exception("Cgc/Cpf do cliente é obrigatório!");
                }
                if (TXT_Endereco.Text.Length == 0)
                {
                    throw new Exception("Endereço do cliente é obrigatório!");
                }
                if (TXT_Bairro.Text.Length == 0)
                {
                    throw new Exception("Bairro do cliente é obrigatório!");
                }
                if (TXT_CEP.Text.Length == 0)
                {
                    throw new Exception("Cep do cliente é obrigatório!");
                }
                if (CBX_CdCidade.SelectedIndex == -1)
                {
                    throw new Exception("Código da cidade é obrigatório!");
                }
                if (TXT_DocIdentif.Text.Length == 0)
                {
                    throw new Exception("Identidade do cliente é obrigatório!");
                }

                if (TXT_EndEmail.Text.Trim() != "")
                {
                    if (ClsValidacao.Fu_Consistir_Email(TXT_EndEmail.Text) == false)
                    {
                        throw new Exception("Endereço de Email informado é inválido!");
                    }
                }

                Dados = new PrjExercicio10.clsDados();
                strSql = "update Cliente set";
                strSql = strSql + " NmCliente = '" + TXT_NmCliente.Text + "'";
                strSql = strSql + " , CgcCpf = " + TXT_GcgCpf.Text;
                strSql = strSql + " , Endereco = '" + TXT_Endereco.Text + "'";
                strSql = strSql + " , Bairro = '" + TXT_Bairro.Text + "'";
                strSql = strSql + " , Cep = " + TXT_CEP.Text;
                strSql = strSql + " , CdCidade = " + CBX_CdCidade.SelectedValue;
                strSql = strSql + " , EndEmail = '" + TXT_EndEmail.Text + "'";
                strSql = strSql + " , DocIdentif = '" + TXT_DocIdentif.Text + "'";
                strSql = strSql + " WHERE CdCliente = " + TXT_CdCliente.Text;

                Dados.Sql = strSql;
                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();

                SU_Limpar_Tela();

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

                if (TXT_CdCliente.Text.Length == 0)
                {
                    throw new Exception("Código do cliente é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();
                Dados.Sql = "delete from Cliente where CdCliente = " + TXT_CdCliente.Text;

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                Dados.FU_Gravar();

                SU_Limpar_Tela();
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

        private void DTG_Cliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            object LOBJ_Retorno = null;
            Decimal DEC_CdCliente = 0;

            try
            {

                if (DTG_Cliente.SelectedIndex != -1)
                {
                    LOBJ_Retorno = ((DataRowView)DTG_Cliente.SelectedItem)["CdCliente"].ToString();
                    DEC_CdCliente = Convert.ToInt32(LOBJ_Retorno.ToString());

                    SU_Montar_Tela(DEC_CdCliente);
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

        private void SU_Montar_Tela(Decimal DEC_CdCliente)
        {
            string strSql;
            DataTable LDTT_Cliente = null;
            PrjExercicio10.clsDados Dados = null;

            try
            {

                if (DEC_CdCliente != 0)
                {
                    Dados = new PrjExercicio10.clsDados();
                    strSql = " where CdCliente = " + DEC_CdCliente.ToString();
                    Dados.Sql = "select CLIENTE.*, CIDADE.CdPais, CIDADE.Estado from CLIENTE INNER JOIN CIDADE ON (CIDADE.CdCidade = CLIENTE.CdCidade) " + strSql;

                    PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                    LDTT_Cliente = Dados.FU_Pesquisar();
                    if (LDTT_Cliente.Rows.Count > 0)
                    {
                        BTN_Incluir.IsEnabled = false;
                        BTN_Alterar.IsEnabled = true;
                        BTN_Excluir.IsEnabled = true;

                        TXT_CdCliente.Text = LDTT_Cliente.Rows[0]["CdCliente"].ToString();
                        TXT_NmCliente.Text = LDTT_Cliente.Rows[0]["NmCliente"].ToString();
                        TXT_Endereco.Text = LDTT_Cliente.Rows[0]["Endereco"].ToString();
                        TXT_Bairro.Text = LDTT_Cliente.Rows[0]["Bairro"].ToString();
                        TXT_CEP.Text = LDTT_Cliente.Rows[0]["CEP"].ToString();
                        TXT_EndEmail.Text = LDTT_Cliente.Rows[0]["EndEmail"].ToString();
                        TXT_DocIdentif.Text = LDTT_Cliente.Rows[0]["DocIdentif"].ToString();
                        TXT_GcgCpf.Text = LDTT_Cliente.Rows[0]["CgcCpf"].ToString();

                        CBX_CdPais.SelectedValue = LDTT_Cliente.Rows[0]["CdPais"].ToString();

                        CarregaComboEstado(Convert.ToInt32(LDTT_Cliente.Rows[0]["CdPais"].ToString()));
                        CBX_Estado.SelectedValue = LDTT_Cliente.Rows[0]["Estado"].ToString();

                        CarregaComboCidade(Convert.ToInt32(LDTT_Cliente.Rows[0]["CdPais"].ToString()), LDTT_Cliente.Rows[0]["Estado"].ToString());
                        CBX_CdCidade.SelectedValue = LDTT_Cliente.Rows[0]["CdCidade"].ToString();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LDTT_Cliente = null;
                Dados = null;

            }
        }

        private void TXT_CdCliente_LostFocus(object sender, RoutedEventArgs e)
        {

            try
            {
                if (TXT_CdCliente.Text.Trim() != "")
                {
                    try
                    {
                        if (Convert.ToDecimal(TXT_CdCliente.Text.Trim()) != 0)
                        {
                            SU_Montar_Tela(Convert.ToDecimal(TXT_CdCliente.Text.Trim()));
                        }
                    }
                    catch
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
