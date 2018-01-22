// Treinamento C# (Microsoft Visual Studio .NET)
// MTM Sistemas Ltda  
// Consultoria em C# e MS SQL Server para Desenvolvimento e Migração de Sistemas
// 041-3232.6416

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjExercicio05
{
    class clsValidacao
    {
        public bool FU_Validacao(string txt_Valor)
        {
            Decimal LDEC_Valor = 0;

            if (txt_Valor.Trim() == "")
            {
                MessageBox.Show("Valor deve ser informado!");
                return false;
            }
            else if (Decimal.TryParse(txt_Valor.Trim(), out LDEC_Valor) == false)
            {
                MessageBox.Show("Valor informado não é um numero!");
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
