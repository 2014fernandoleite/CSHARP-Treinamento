namespace PrjExercicio03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_Depois = new System.Windows.Forms.RadioButton();
            this.opt_Agora = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Chk_Quando = new System.Windows.Forms.CheckBox();
            this.Chk_Alternativa = new System.Windows.Forms.CheckBox();
            this.btn_IfElse = new System.Windows.Forms.Button();
            this.btn_Case = new System.Windows.Forms.Button();
            this.btn_IfNot = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Menor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MenorIgual = new System.Windows.Forms.Button();
            this.btn_MaiorIgual = new System.Windows.Forms.Button();
            this.btn_Diferente = new System.Windows.Forms.Button();
            this.btn_Maior = new System.Windows.Forms.Button();
            this.btn_Igual = new System.Windows.Forms.Button();
            this.txt_ValorB = new System.Windows.Forms.TextBox();
            this.txt_ValorA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.opt_Estudar = new System.Windows.Forms.RadioButton();
            this.opt_Trabalhar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_Depois);
            this.groupBox1.Controls.Add(this.opt_Agora);
            this.groupBox1.Location = new System.Drawing.Point(136, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quando";
            // 
            // opt_Depois
            // 
            this.opt_Depois.AutoSize = true;
            this.opt_Depois.Location = new System.Drawing.Point(7, 37);
            this.opt_Depois.Name = "opt_Depois";
            this.opt_Depois.Size = new System.Drawing.Size(58, 17);
            this.opt_Depois.TabIndex = 1;
            this.opt_Depois.TabStop = true;
            this.opt_Depois.Text = "Depois";
            this.opt_Depois.UseVisualStyleBackColor = true;
            // 
            // opt_Agora
            // 
            this.opt_Agora.AutoSize = true;
            this.opt_Agora.Checked = true;
            this.opt_Agora.Location = new System.Drawing.Point(7, 14);
            this.opt_Agora.Name = "opt_Agora";
            this.opt_Agora.Size = new System.Drawing.Size(53, 17);
            this.opt_Agora.TabIndex = 0;
            this.opt_Agora.TabStop = true;
            this.opt_Agora.Text = "Agora";
            this.opt_Agora.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Chk_Quando);
            this.groupBox3.Controls.Add(this.Chk_Alternativa);
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Combinações";
            // 
            // Chk_Quando
            // 
            this.Chk_Quando.AutoSize = true;
            this.Chk_Quando.Location = new System.Drawing.Point(147, 19);
            this.Chk_Quando.Name = "Chk_Quando";
            this.Chk_Quando.Size = new System.Drawing.Size(64, 17);
            this.Chk_Quando.TabIndex = 1;
            this.Chk_Quando.Text = "Quando";
            this.Chk_Quando.UseVisualStyleBackColor = true;
            // 
            // Chk_Alternativa
            // 
            this.Chk_Alternativa.AutoSize = true;
            this.Chk_Alternativa.Location = new System.Drawing.Point(7, 20);
            this.Chk_Alternativa.Name = "Chk_Alternativa";
            this.Chk_Alternativa.Size = new System.Drawing.Size(76, 17);
            this.Chk_Alternativa.TabIndex = 0;
            this.Chk_Alternativa.Text = "Alternativa";
            this.Chk_Alternativa.UseVisualStyleBackColor = true;
            // 
            // btn_IfElse
            // 
            this.btn_IfElse.Location = new System.Drawing.Point(303, 12);
            this.btn_IfElse.Name = "btn_IfElse";
            this.btn_IfElse.Size = new System.Drawing.Size(174, 38);
            this.btn_IfElse.TabIndex = 3;
            this.btn_IfElse.Text = "If / Else";
            this.btn_IfElse.UseVisualStyleBackColor = true;
            this.btn_IfElse.Click += new System.EventHandler(this.btn_IfElse_Click);
            // 
            // btn_Case
            // 
            this.btn_Case.Location = new System.Drawing.Point(303, 100);
            this.btn_Case.Name = "btn_Case";
            this.btn_Case.Size = new System.Drawing.Size(174, 38);
            this.btn_Case.TabIndex = 5;
            this.btn_Case.Text = "switch / case";
            this.btn_Case.UseVisualStyleBackColor = true;
            this.btn_Case.Click += new System.EventHandler(this.btn_Case_Click);
            // 
            // btn_IfNot
            // 
            this.btn_IfNot.Location = new System.Drawing.Point(303, 56);
            this.btn_IfNot.Name = "btn_IfNot";
            this.btn_IfNot.Size = new System.Drawing.Size(174, 38);
            this.btn_IfNot.TabIndex = 4;
            this.btn_IfNot.Text = "If Not";
            this.btn_IfNot.UseVisualStyleBackColor = true;
            this.btn_IfNot.Click += new System.EventHandler(this.btn_IfNot_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Menor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_MenorIgual);
            this.groupBox2.Controls.Add(this.btn_MaiorIgual);
            this.groupBox2.Controls.Add(this.btn_Diferente);
            this.groupBox2.Controls.Add(this.btn_Maior);
            this.groupBox2.Controls.Add(this.btn_Igual);
            this.groupBox2.Controls.Add(this.txt_ValorB);
            this.groupBox2.Controls.Add(this.txt_ValorA);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores Relacionais";
            // 
            // btn_Menor
            // 
            this.btn_Menor.Location = new System.Drawing.Point(14, 75);
            this.btn_Menor.Name = "btn_Menor";
            this.btn_Menor.Size = new System.Drawing.Size(100, 23);
            this.btn_Menor.TabIndex = 4;
            this.btn_Menor.Text = "A é < B ?";
            this.btn_Menor.UseVisualStyleBackColor = true;
            this.btn_Menor.Click += new System.EventHandler(this.btn_Menor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor A";
            // 
            // btn_MenorIgual
            // 
            this.btn_MenorIgual.Location = new System.Drawing.Point(287, 75);
            this.btn_MenorIgual.Name = "btn_MenorIgual";
            this.btn_MenorIgual.Size = new System.Drawing.Size(100, 23);
            this.btn_MenorIgual.TabIndex = 6;
            this.btn_MenorIgual.Text = "A é <= B ?";
            this.btn_MenorIgual.UseVisualStyleBackColor = true;
            this.btn_MenorIgual.Click += new System.EventHandler(this.btn_MenorIgual_Click);
            // 
            // btn_MaiorIgual
            // 
            this.btn_MaiorIgual.Location = new System.Drawing.Point(147, 75);
            this.btn_MaiorIgual.Name = "btn_MaiorIgual";
            this.btn_MaiorIgual.Size = new System.Drawing.Size(100, 23);
            this.btn_MaiorIgual.TabIndex = 5;
            this.btn_MaiorIgual.Text = "A é >= B ?";
            this.btn_MaiorIgual.UseVisualStyleBackColor = true;
            this.btn_MaiorIgual.Click += new System.EventHandler(this.btn_MaiorIgual_Click);
            // 
            // btn_Diferente
            // 
            this.btn_Diferente.Location = new System.Drawing.Point(147, 46);
            this.btn_Diferente.Name = "btn_Diferente";
            this.btn_Diferente.Size = new System.Drawing.Size(100, 23);
            this.btn_Diferente.TabIndex = 4;
            this.btn_Diferente.Text = "A é != B ?";
            this.btn_Diferente.UseVisualStyleBackColor = true;
            this.btn_Diferente.Click += new System.EventHandler(this.btn_Diferente_Click);
            // 
            // btn_Maior
            // 
            this.btn_Maior.Location = new System.Drawing.Point(287, 45);
            this.btn_Maior.Name = "btn_Maior";
            this.btn_Maior.Size = new System.Drawing.Size(100, 23);
            this.btn_Maior.TabIndex = 3;
            this.btn_Maior.Text = "A é > B ?";
            this.btn_Maior.UseVisualStyleBackColor = true;
            this.btn_Maior.Click += new System.EventHandler(this.btn_Maior_Click);
            // 
            // btn_Igual
            // 
            this.btn_Igual.Location = new System.Drawing.Point(14, 45);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(100, 23);
            this.btn_Igual.TabIndex = 2;
            this.btn_Igual.Text = "A é = B ?";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // txt_ValorB
            // 
            this.txt_ValorB.Location = new System.Drawing.Point(258, 19);
            this.txt_ValorB.Name = "txt_ValorB";
            this.txt_ValorB.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorB.TabIndex = 1;
            // 
            // txt_ValorA
            // 
            this.txt_ValorA.Location = new System.Drawing.Point(65, 20);
            this.txt_ValorA.Name = "txt_ValorA";
            this.txt_ValorA.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorA.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.opt_Estudar);
            this.groupBox4.Controls.Add(this.opt_Trabalhar);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 60);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alternativas";
            // 
            // opt_Estudar
            // 
            this.opt_Estudar.AutoSize = true;
            this.opt_Estudar.Location = new System.Drawing.Point(7, 37);
            this.opt_Estudar.Name = "opt_Estudar";
            this.opt_Estudar.Size = new System.Drawing.Size(61, 17);
            this.opt_Estudar.TabIndex = 1;
            this.opt_Estudar.TabStop = true;
            this.opt_Estudar.Text = "Estudar";
            this.opt_Estudar.UseVisualStyleBackColor = true;
            // 
            // opt_Trabalhar
            // 
            this.opt_Trabalhar.AutoSize = true;
            this.opt_Trabalhar.Checked = true;
            this.opt_Trabalhar.Location = new System.Drawing.Point(7, 14);
            this.opt_Trabalhar.Name = "opt_Trabalhar";
            this.opt_Trabalhar.Size = new System.Drawing.Size(70, 17);
            this.opt_Trabalhar.TabIndex = 0;
            this.opt_Trabalhar.TabStop = true;
            this.opt_Trabalhar.Text = "Trabalhar";
            this.opt_Trabalhar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 263);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_IfNot);
            this.Controls.Add(this.btn_Case);
            this.Controls.Add(this.btn_IfElse);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Decisão, Operadores Logicos e Relacionais";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton opt_Depois;
        private System.Windows.Forms.RadioButton opt_Agora;
        private System.Windows.Forms.Button btn_IfElse;
        private System.Windows.Forms.CheckBox Chk_Quando;
        private System.Windows.Forms.CheckBox Chk_Alternativa;
        private System.Windows.Forms.Button btn_Case;
        private System.Windows.Forms.Button btn_IfNot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_MenorIgual;
        private System.Windows.Forms.Button btn_MaiorIgual;
        private System.Windows.Forms.Button btn_Diferente;
        private System.Windows.Forms.Button btn_Maior;
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.TextBox txt_ValorB;
        private System.Windows.Forms.TextBox txt_ValorA;
        private System.Windows.Forms.Button btn_Menor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton opt_Estudar;
        private System.Windows.Forms.RadioButton opt_Trabalhar;
    }
}