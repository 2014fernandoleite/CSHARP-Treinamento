using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// “Add Reference” ==>  na aba COM  ==> Microsoft Speech Object Library
using SpeechLib;

namespace PrjProjeto17
{
    public partial class Form1 : Form
    {

        private SpVoice voz = new SpVoice();

        /// <summary>
        /// Declaração da Classe
        /// </summary>
        class ClsVozes
        {
            // Campos da Classe
            public string Codigo { get; set; }
            public string Nome { get; set; }

            /// <summary>
            /// Construtor da Classe
            /// </summary>
            public ClsVozes()
            {
            }
        }

        List<ClsVozes> Vozes = new List<ClsVozes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (ISpeechObjectToken Token in voz.GetVoices(string.Empty, string.Empty))
                {
                    Vozes.Add(new ClsVozes()
                    {
                        Codigo = Token.GetAttribute("Language").Trim(),
                        Nome = Token.GetAttribute("Name").Trim()
                    });
                }

                cmb_Voz.DataSource = null;
                cmb_Voz.ValueMember = "Codigo";
                cmb_Voz.DisplayMember = "Nome";
                cmb_Voz.DataSource = Vozes;
                cmb_Voz.Refresh();

                cmb_Voz.SelectedIndex = 0;
                txt_Texto.Text = "Bem Vindo " + Environment.UserName.ToString();
                btn_iniciar_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

            voz.Voice = voz.GetVoices("Name=" + cmb_Voz.Text.ToString(), "Language=" + cmb_Voz.SelectedValue.ToString()).Item(0);
            voz.Rate = Convert.ToInt16(tkb_Volocidade.Value.ToString());
            voz.Speak(txt_Texto.Text.ToString(), SpeechVoiceSpeakFlags.SVSFlagsAsync);
            txt_Texto.Text = "";
        }
    }
}
