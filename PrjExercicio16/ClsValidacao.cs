using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PrjExercicio16
{
    public class ClsValidacao
    {

        public static bool Fu_Consistir_Email(string STR_EndEmail)
        {

            bool PBOL_Retorno = true;
            int PINT_PosArroba = 0, PINT_IndOcorr = 0;
            Regex LRGX_RegularExpressions = null;
            string[] PSTR_Ocorrencias;
            string PSTR_EndEmail = null;

            try
            {

                PSTR_Ocorrencias = STR_EndEmail.Split(new char[] { ';' });
                for (PINT_IndOcorr = 0; PINT_IndOcorr < PSTR_Ocorrencias.Length; PINT_IndOcorr++)
                {

                    PSTR_EndEmail = PSTR_Ocorrencias[PINT_IndOcorr].Trim();
                    if (PSTR_EndEmail.ToString().Trim() != "")
                    {
                        PINT_PosArroba = PSTR_EndEmail.IndexOf("@");

                        // Se não tiver arroba
                        if (PINT_PosArroba == -1)
                        { PBOL_Retorno = false; }

                        // Se tiver um segundo arroba
                        else if (PSTR_EndEmail.IndexOf("@", PINT_PosArroba + 1) != -1)
                        { PBOL_Retorno = false; }

                        // Se não tiver ponto após arroba
                        else if (PSTR_EndEmail.IndexOf(".", PINT_PosArroba) == -1)
                        { PBOL_Retorno = false; }

                        // Se tiver ponto junto com o arroba
                        else if (PSTR_EndEmail.IndexOf("@.") != -1)
                        { PBOL_Retorno = false; }

                        // Se tiver ponto junto com o arroba
                        else if (PSTR_EndEmail.IndexOf(".@") != -1)
                        { PBOL_Retorno = false; }

                        // Se tiver ponto + ponto
                        else if (PSTR_EndEmail.IndexOf("..") != -1)
                        { PBOL_Retorno = false; }

                        // Se tiver colchetes
                        else if (PSTR_EndEmail.IndexOf("[") != -1)
                        { PBOL_Retorno = false; }

                        // Se tiver colchetes
                        else if (PSTR_EndEmail.IndexOf("]") != -1)
                        { PBOL_Retorno = false; }

                        // Se tiver espaços no meio
                        else if (PSTR_EndEmail.IndexOf(" ") != -1)
                        { PBOL_Retorno = false; }

                        // Se o Arroba for o primeiro caracter
                        else if (PINT_PosArroba == 0)
                        { PBOL_Retorno = false; }

                        // Se o primeiro caracter for .
                        else if (PSTR_EndEmail.Substring(0, 1) == ".")
                        { PBOL_Retorno = false; }

                        // Se o ponto for o último caracter
                        else if (PSTR_EndEmail.Substring(PSTR_EndEmail.Length - 1, 1) == ".")
                        { PBOL_Retorno = false; }

                        else
                        {
                            // se tiver outros caracteres inválidos
                            LRGX_RegularExpressions = new Regex("[^@._0-9A-Za-z-]");
                            PBOL_Retorno = !LRGX_RegularExpressions.IsMatch(PSTR_EndEmail.ToString()) && (PSTR_EndEmail.ToString() != "");
                        }

                        if (PBOL_Retorno == false)
                        { break; }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                LRGX_RegularExpressions = null;
                PSTR_Ocorrencias = null;
                PSTR_EndEmail = null;
            }

            return PBOL_Retorno;

        }
        

    }
}
