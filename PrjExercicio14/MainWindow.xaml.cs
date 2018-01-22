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

namespace PrjExercicio14
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
                Dados = new PrjExercicio10.clsDados();

                if (CBX_CdPais.SelectedIndex != -1)
                {
                    strSql = " where estado.CdPais = " + CBX_CdPais.SelectedValue;
                }
                if (TXT_Estado.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where estado.Estado = '" + TXT_Estado.Text + "'";
                    }
                    else
                    {
                        strSql = strSql + " and estado.Estado = '" + TXT_Estado.Text + "'";
                    }
                }
                if (TXT_DsEstado.Text.Length > 0)
                {
                    if (strSql.Length == 0)
                    {
                        strSql = " where estado.DsEstado like '" + TXT_DsEstado.Text + "%'";
                    }
                    else
                    {
                        strSql = strSql + " and estado.DsEstado like '" + TXT_DsEstado.Text + "%'";
                    }
                }

                Dados.Sql = "select estado.*, Pais.DsPais from estado INNER JOIN Pais ON Pais.CdPais = estado.CdPais " + strSql;

                PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";

                DTG_Estado.Columns.Clear();
                DTG_Estado.AutoGenerateColumns = false;
                DTG_Estado.IsReadOnly = true;

                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;
                BTN_Incluir.IsEnabled = true;

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("CdPais");
                Aux.Width = 80;
                Aux.Header = "Código";
                Aux.SortMemberPath = "CdPais";
                Aux.Visibility = System.Windows.Visibility.Hidden;
                DTG_Estado.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("DsPais");
                Aux.Width = 100;
                Aux.Header = "Pais";
                Aux.SortMemberPath = "DsPais";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Estado.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("Estado");
                Aux.Width = 100;
                Aux.Header = "Estado";
                Aux.SortMemberPath = "Estado";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Estado.Columns.Add(Aux);

                Aux = new DataGridTextColumn();
                Aux.Binding = new Binding("DsEstado");
                Aux.Width = 200;
                Aux.Header = "Descricão";
                Aux.SortMemberPath = "DsEstado";
                Aux.Visibility = System.Windows.Visibility.Visible;
                DTG_Estado.Columns.Add(Aux);

                DTG_Estado.ItemsSource = Dados.FU_Pesquisar().DefaultView;
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
                    throw new Exception("Código do pais é obrigatório!");
                }
                if (TXT_Estado.Text.Trim().Length == 0)
                {
                    throw new Exception("Sigla do Estado é obrigatório!");
                }
                if (TXT_DsEstado.Text.Trim().Length == 0)
                {
                    throw new Exception("Descrição do estado é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();
                strSql = "Insert into Estado(CdPais, Estado, DsEstado) Values(";
                strSql = strSql + CBX_CdPais.SelectedValue;
                strSql = strSql + " , '" + TXT_Estado.Text + "'";
                strSql = strSql + " , '" + TXT_DsEstado.Text + "'";
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
                    throw new Exception("Código do pais é obrigatório!");
                }
                if (TXT_Estado.Text.Length == 0)
                {
                    throw new Exception("Estado é obrigatório!");
                }
                if (TXT_DsEstado.Text.Length == 0)
                {
                    throw new Exception("Descrição do estado é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();
                strSql = "update Estado set";
                strSql = strSql + " DsEstado = '" + TXT_DsEstado.Text + "'";
                strSql = strSql + " WHERE CdPais = " + CBX_CdPais.SelectedValue;
                strSql = strSql + " AND Estado = '" + TXT_Estado.Text + "'";

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
                if (CBX_CdPais.SelectedIndex == -1)
                {
                    throw new Exception("Código do pais é obrigatório!");
                }
                if (TXT_Estado.Text.Length == 0)
                {
                    throw new Exception("Estado é obrigatório!");
                }

                Dados = new PrjExercicio10.clsDados();

                Dados.Sql = "delete from Estado where CdPais = " + CBX_CdPais.SelectedValue + " AND Estado = '" + TXT_Estado.Text + "'";

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

        private void BTN_Limpar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                TXT_Estado.Text = "";
                TXT_DsEstado.Text = "";
                CBX_CdPais.SelectedIndex = -1;
                BTN_Incluir.IsEnabled = true;
                BTN_Alterar.IsEnabled = false;
                BTN_Excluir.IsEnabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TXT_Estado_LostFocus(object sender, RoutedEventArgs e)
        {

            try
            {
                if (TXT_Estado.Text.Trim() != "")
                {
                    if (TXT_Estado.Text.Trim() != "" && CBX_CdPais.SelectedIndex != -1)
                    {
                        SU_Montar_Tela(Convert.ToInt32(CBX_CdPais.SelectedValue), TXT_Estado.Text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CBX_CdPais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (TXT_Estado.Text.Trim() != "")
                {
                    if (CBX_CdPais.SelectedValue != null && CBX_CdPais.SelectedIndex != -1)
                    {
                        SU_Montar_Tela(Convert.ToInt32(CBX_CdPais.SelectedValue), TXT_Estado.Text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DTG_Estado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            object LOBJ_Retorno = null;
            Int32 INT_CdPais = 0;
            string STR_Estado = "";

            try
            {

                if (DTG_Estado.SelectedIndex != -1)
                {
                    LOBJ_Retorno = ((DataRowView)DTG_Estado.SelectedItem)["CdPais"].ToString();
                    INT_CdPais = Convert.ToInt32(LOBJ_Retorno.ToString());
                    STR_Estado = ((DataRowView)DTG_Estado.SelectedItem)["Estado"].ToString();

                    SU_Montar_Tela(INT_CdPais, STR_Estado);
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


        private void SU_Montar_Tela(Int32 INT_CdPais, string STR_Estado)
        {
            string strSql;
            DataTable LDTT_Estado;

            try
            {

                if (INT_CdPais != 0 && STR_Estado.Trim() != "")
                {
                    PrjExercicio10.clsDados Dados = new PrjExercicio10.clsDados();
                    strSql = " where CdPais = " + INT_CdPais.ToString();
                    strSql += " and Estado = '" + STR_Estado.ToString() + "'";
                    Dados.Sql = "select * from ESTADO " + strSql;
                    PrjExercicio10.clsParametros.EnderecoArquivo = "C:\\";
                    LDTT_Estado = Dados.FU_Pesquisar();
                    if (LDTT_Estado.Rows.Count > 0)
                    {
                        BTN_Incluir.IsEnabled = false;
                        BTN_Alterar.IsEnabled = true;
                        BTN_Excluir.IsEnabled = true;

                        CBX_CdPais.SelectedValue = LDTT_Estado.Rows[0]["CdPais"].ToString();
                        TXT_Estado.Text = LDTT_Estado.Rows[0]["Estado"].ToString();
                        TXT_DsEstado.Text = LDTT_Estado.Rows[0]["DsEstado"].ToString();
                    }
                    else
                    {
                        TXT_DsEstado.Text = "";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LDTT_Estado = null;
            }
        }


    }
}
