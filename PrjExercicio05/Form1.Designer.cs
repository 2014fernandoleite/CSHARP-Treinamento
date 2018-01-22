namespace PrjExercicio05
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
            this.txt_Nr1 = new System.Windows.Forms.TextBox();
            this.txt_Nr2 = new System.Windows.Forms.TextBox();
            this.btn_Adicao = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Divi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_Operacao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NrDecimais = new System.Windows.Forms.TextBox();
            this.txt_VlrEntrada = new System.Windows.Forms.TextBox();
            this.lbl_ValorConvertido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ValorEnt = new System.Windows.Forms.Label();
            this.Btn_Truncar = new System.Windows.Forms.Button();
            this.btn_Arredondar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nr1
            // 
            this.txt_Nr1.Location = new System.Drawing.Point(12, 12);
            this.txt_Nr1.Name = "txt_Nr1";
            this.txt_Nr1.Size = new System.Drawing.Size(100, 20);
            this.txt_Nr1.TabIndex = 0;
            this.txt_Nr1.Validated += new System.EventHandler(this.txt_Nr1_Validated);
            // 
            // txt_Nr2
            // 
            this.txt_Nr2.Location = new System.Drawing.Point(162, 12);
            this.txt_Nr2.Name = "txt_Nr2";
            this.txt_Nr2.Size = new System.Drawing.Size(100, 20);
            this.txt_Nr2.TabIndex = 1;
            this.txt_Nr2.Validated += new System.EventHandler(this.txt_Nr2_Validated);
            // 
            // btn_Adicao
            // 
            this.btn_Adicao.Location = new System.Drawing.Point(12, 55);
            this.btn_Adicao.Name = "btn_Adicao";
            this.btn_Adicao.Size = new System.Drawing.Size(30, 23);
            this.btn_Adicao.TabIndex = 2;
            this.btn_Adicao.Text = "+";
            this.btn_Adicao.UseVisualStyleBackColor = true;
            this.btn_Adicao.Click += new System.EventHandler(this.btn_Adicao_Click);
            // 
            // btn_Multi
            // 
            this.btn_Multi.Location = new System.Drawing.Point(84, 55);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(30, 23);
            this.btn_Multi.TabIndex = 4;
            this.btn_Multi.Text = "x";
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Location = new System.Drawing.Point(48, 55);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(30, 23);
            this.btn_Sub.TabIndex = 3;
            this.btn_Sub.Text = "-";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // btn_Divi
            // 
            this.btn_Divi.Location = new System.Drawing.Point(120, 55);
            this.btn_Divi.Name = "btn_Divi";
            this.btn_Divi.Size = new System.Drawing.Size(30, 23);
            this.btn_Divi.TabIndex = 5;
            this.btn_Divi.Text = "/";
            this.btn_Divi.UseVisualStyleBackColor = true;
            this.btn_Divi.Click += new System.EventHandler(this.btn_Divi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(287, 15);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(79, 16);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // lbl_Operacao
            // 
            this.lbl_Operacao.AutoSize = true;
            this.lbl_Operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operacao.Location = new System.Drawing.Point(129, 16);
            this.lbl_Operacao.Name = "lbl_Operacao";
            this.lbl_Operacao.Size = new System.Drawing.Size(16, 16);
            this.lbl_Operacao.TabIndex = 8;
            this.lbl_Operacao.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NrDecimais);
            this.groupBox1.Controls.Add(this.txt_VlrEntrada);
            this.groupBox1.Controls.Add(this.lbl_ValorConvertido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_ValorEnt);
            this.groupBox1.Controls.Add(this.Btn_Truncar);
            this.groupBox1.Controls.Add(this.btn_Arredondar);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truncar / Arredondar";
            // 
            // txt_NrDecimais
            // 
            this.txt_NrDecimais.Location = new System.Drawing.Point(220, 24);
            this.txt_NrDecimais.MaxLength = 2;
            this.txt_NrDecimais.Name = "txt_NrDecimais";
            this.txt_NrDecimais.Size = new System.Drawing.Size(56, 20);
            this.txt_NrDecimais.TabIndex = 1;
            this.txt_NrDecimais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NrDecimais_KeyPress);
            // 
            // txt_VlrEntrada
            // 
            this.txt_VlrEntrada.Location = new System.Drawing.Point(57, 24);
            this.txt_VlrEntrada.Name = "txt_VlrEntrada";
            this.txt_VlrEntrada.Size = new System.Drawing.Size(90, 20);
            this.txt_VlrEntrada.TabIndex = 0;
            this.txt_VlrEntrada.Validated += new System.EventHandler(this.txt_VlrEntrada_Validated);
            // 
            // lbl_ValorConvertido
            // 
            this.lbl_ValorConvertido.AutoSize = true;
            this.lbl_ValorConvertido.Location = new System.Drawing.Point(282, 27);
            this.lbl_ValorConvertido.Name = "lbl_ValorConvertido";
            this.lbl_ValorConvertido.Size = new System.Drawing.Size(55, 13);
            this.lbl_ValorConvertido.TabIndex = 15;
            this.lbl_ValorConvertido.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Decimais";
            // 
            // lbl_ValorEnt
            // 
            this.lbl_ValorEnt.AutoSize = true;
            this.lbl_ValorEnt.Location = new System.Drawing.Point(16, 27);
            this.lbl_ValorEnt.Name = "lbl_ValorEnt";
            this.lbl_ValorEnt.Size = new System.Drawing.Size(31, 13);
            this.lbl_ValorEnt.TabIndex = 13;
            this.lbl_ValorEnt.Text = "Valor";
            // 
            // Btn_Truncar
            // 
            this.Btn_Truncar.Location = new System.Drawing.Point(220, 60);
            this.Btn_Truncar.Name = "Btn_Truncar";
            this.Btn_Truncar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Truncar.TabIndex = 3;
            this.Btn_Truncar.Text = "Truncar";
            this.Btn_Truncar.UseVisualStyleBackColor = true;
            this.Btn_Truncar.Click += new System.EventHandler(this.Btn_Truncar_Click);
            // 
            // btn_Arredondar
            // 
            this.btn_Arredondar.Location = new System.Drawing.Point(36, 60);
            this.btn_Arredondar.Name = "btn_Arredondar";
            this.btn_Arredondar.Size = new System.Drawing.Size(75, 23);
            this.btn_Arredondar.TabIndex = 2;
            this.btn_Arredondar.Text = "Arredondar";
            this.btn_Arredondar.UseVisualStyleBackColor = true;
            this.btn_Arredondar.Click += new System.EventHandler(this.btn_Arredondar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Operacao);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Divi);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Multi);
            this.Controls.Add(this.btn_Adicao);
            this.Controls.Add(this.txt_Nr2);
            this.Controls.Add(this.txt_Nr1);
            this.Name = "Form1";
            this.Text = "Funções Matemáticas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nr1;
        private System.Windows.Forms.TextBox txt_Nr2;
        private System.Windows.Forms.Button btn_Adicao;
        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Divi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_Operacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NrDecimais;
        private System.Windows.Forms.TextBox txt_VlrEntrada;
        private System.Windows.Forms.Label lbl_ValorConvertido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ValorEnt;
        private System.Windows.Forms.Button Btn_Truncar;
        private System.Windows.Forms.Button btn_Arredondar;
    }
}

