namespace PrjExercicio06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Trim = new System.Windows.Forms.Button();
            this.btn_substring = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_indexOf = new System.Windows.Forms.Button();
            this.btn_ToUpper = new System.Windows.Forms.Button();
            this.btn_ToLower = new System.Windows.Forms.Button();
            this.txt_InicioSub = new System.Windows.Forms.TextBox();
            this.txt_TamanhoSub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Novo = new System.Windows.Forms.TextBox();
            this.txt_Antigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PesquisarIndexOF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(12, 11);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(418, 20);
            this.txt_Valor1.TabIndex = 0;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(12, 37);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(418, 20);
            this.txt_Resultado.TabIndex = 1;
            // 
            // btn_Trim
            // 
            this.btn_Trim.Location = new System.Drawing.Point(12, 70);
            this.btn_Trim.Name = "btn_Trim";
            this.btn_Trim.Size = new System.Drawing.Size(95, 23);
            this.btn_Trim.TabIndex = 2;
            this.btn_Trim.Text = "Trim";
            this.btn_Trim.UseVisualStyleBackColor = true;
            this.btn_Trim.Click += new System.EventHandler(this.btn_Trim_Click);
            // 
            // btn_substring
            // 
            this.btn_substring.Location = new System.Drawing.Point(12, 109);
            this.btn_substring.Name = "btn_substring";
            this.btn_substring.Size = new System.Drawing.Size(95, 23);
            this.btn_substring.TabIndex = 3;
            this.btn_substring.Text = "Substring";
            this.btn_substring.UseVisualStyleBackColor = true;
            this.btn_substring.Click += new System.EventHandler(this.btn_substring_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Location = new System.Drawing.Point(12, 149);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(95, 23);
            this.btn_Replace.TabIndex = 6;
            this.btn_Replace.Text = "Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_indexOf
            // 
            this.btn_indexOf.Location = new System.Drawing.Point(12, 191);
            this.btn_indexOf.Name = "btn_indexOf";
            this.btn_indexOf.Size = new System.Drawing.Size(95, 23);
            this.btn_indexOf.TabIndex = 9;
            this.btn_indexOf.Text = "indexOf";
            this.btn_indexOf.UseVisualStyleBackColor = true;
            this.btn_indexOf.Click += new System.EventHandler(this.btn_indexOf_Click);
            // 
            // btn_ToUpper
            // 
            this.btn_ToUpper.Location = new System.Drawing.Point(12, 230);
            this.btn_ToUpper.Name = "btn_ToUpper";
            this.btn_ToUpper.Size = new System.Drawing.Size(95, 23);
            this.btn_ToUpper.TabIndex = 11;
            this.btn_ToUpper.Text = "ToUpper";
            this.btn_ToUpper.UseVisualStyleBackColor = true;
            this.btn_ToUpper.Click += new System.EventHandler(this.btn_ToUpper_Click);
            // 
            // btn_ToLower
            // 
            this.btn_ToLower.Location = new System.Drawing.Point(174, 230);
            this.btn_ToLower.Name = "btn_ToLower";
            this.btn_ToLower.Size = new System.Drawing.Size(95, 23);
            this.btn_ToLower.TabIndex = 12;
            this.btn_ToLower.Text = "ToLower";
            this.btn_ToLower.UseVisualStyleBackColor = true;
            this.btn_ToLower.Click += new System.EventHandler(this.btn_ToLower_Click);
            // 
            // txt_InicioSub
            // 
            this.txt_InicioSub.Location = new System.Drawing.Point(175, 112);
            this.txt_InicioSub.Name = "txt_InicioSub";
            this.txt_InicioSub.Size = new System.Drawing.Size(36, 20);
            this.txt_InicioSub.TabIndex = 4;
            // 
            // txt_TamanhoSub
            // 
            this.txt_TamanhoSub.Location = new System.Drawing.Point(275, 112);
            this.txt_TamanhoSub.Name = "txt_TamanhoSub";
            this.txt_TamanhoSub.Size = new System.Drawing.Size(36, 20);
            this.txt_TamanhoSub.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tamanho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Novo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Antigo";
            // 
            // txt_Novo
            // 
            this.txt_Novo.Location = new System.Drawing.Point(275, 152);
            this.txt_Novo.Name = "txt_Novo";
            this.txt_Novo.Size = new System.Drawing.Size(36, 20);
            this.txt_Novo.TabIndex = 8;
            // 
            // txt_Antigo
            // 
            this.txt_Antigo.Location = new System.Drawing.Point(175, 152);
            this.txt_Antigo.Name = "txt_Antigo";
            this.txt_Antigo.Size = new System.Drawing.Size(36, 20);
            this.txt_Antigo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pesquisar";
            // 
            // txt_PesquisarIndexOF
            // 
            this.txt_PesquisarIndexOF.Location = new System.Drawing.Point(174, 193);
            this.txt_PesquisarIndexOF.Name = "txt_PesquisarIndexOF";
            this.txt_PesquisarIndexOF.Size = new System.Drawing.Size(76, 20);
            this.txt_PesquisarIndexOF.TabIndex = 10;
             // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PesquisarIndexOF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Novo);
            this.Controls.Add(this.txt_Antigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TamanhoSub);
            this.Controls.Add(this.txt_InicioSub);
            this.Controls.Add(this.btn_ToLower);
            this.Controls.Add(this.btn_ToUpper);
            this.Controls.Add(this.btn_indexOf);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.btn_substring);
            this.Controls.Add(this.btn_Trim);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Valor1);
            this.Name = "Form1";
            this.Text = "Funções de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_Trim;
        private System.Windows.Forms.Button btn_substring;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_indexOf;
        private System.Windows.Forms.Button btn_ToUpper;
        private System.Windows.Forms.Button btn_ToLower;
        private System.Windows.Forms.TextBox txt_InicioSub;
        private System.Windows.Forms.TextBox txt_TamanhoSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Novo;
        private System.Windows.Forms.TextBox txt_Antigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PesquisarIndexOF;
    }
}

