namespace PrjExercicio09
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
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.txt_Ler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_GravarXML = new System.Windows.Forms.Button();
            this.btn_LerXml = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Banco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Servidor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(6, 19);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 0;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // txt_Ler
            // 
            this.txt_Ler.Location = new System.Drawing.Point(229, 22);
            this.txt_Ler.Multiline = true;
            this.txt_Ler.Name = "txt_Ler";
            this.txt_Ler.Size = new System.Drawing.Size(224, 184);
            this.txt_Ler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conteúdo do Arquivo";
            // 
            // btn_Ler
            // 
            this.btn_Ler.Location = new System.Drawing.Point(99, 19);
            this.btn_Ler.Name = "btn_Ler";
            this.btn_Ler.Size = new System.Drawing.Size(75, 23);
            this.btn_Ler.TabIndex = 2;
            this.btn_Ler.Text = "Ler";
            this.btn_Ler.UseVisualStyleBackColor = true;
            this.btn_Ler.Click += new System.EventHandler(this.btn_Ler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Gravar);
            this.groupBox1.Controls.Add(this.btn_Ler);
            this.groupBox1.Location = new System.Drawing.Point(30, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TXT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_GravarXML);
            this.groupBox2.Controls.Add(this.btn_LerXml);
            this.groupBox2.Location = new System.Drawing.Point(30, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML";
            // 
            // btn_GravarXML
            // 
            this.btn_GravarXML.Location = new System.Drawing.Point(6, 19);
            this.btn_GravarXML.Name = "btn_GravarXML";
            this.btn_GravarXML.Size = new System.Drawing.Size(75, 23);
            this.btn_GravarXML.TabIndex = 0;
            this.btn_GravarXML.Text = "Gravar";
            this.btn_GravarXML.UseVisualStyleBackColor = true;
            this.btn_GravarXML.Click += new System.EventHandler(this.btn_GravarXML_Click);
            // 
            // btn_LerXml
            // 
            this.btn_LerXml.Location = new System.Drawing.Point(99, 19);
            this.btn_LerXml.Name = "btn_LerXml";
            this.btn_LerXml.Size = new System.Drawing.Size(75, 23);
            this.btn_LerXml.TabIndex = 2;
            this.btn_LerXml.Text = "Ler";
            this.btn_LerXml.UseVisualStyleBackColor = true;
            this.btn_LerXml.Click += new System.EventHandler(this.btn_LerXml_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(77, 84);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(100, 20);
            this.txt_Senha.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuário";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(77, 58);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Banco";
            // 
            // txt_Banco
            // 
            this.txt_Banco.Location = new System.Drawing.Point(77, 32);
            this.txt_Banco.Name = "txt_Banco";
            this.txt_Banco.Size = new System.Drawing.Size(100, 20);
            this.txt_Banco.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Servidor";
            // 
            // txt_Servidor
            // 
            this.txt_Servidor.Location = new System.Drawing.Point(77, 6);
            this.txt_Servidor.Name = "txt_Servidor";
            this.txt_Servidor.Size = new System.Drawing.Size(100, 20);
            this.txt_Servidor.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Banco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Servidor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ler);
            this.Name = "Form1";
            this.Text = "Gravando TXT e XML";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox txt_Ler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_GravarXML;
        private System.Windows.Forms.Button btn_LerXml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Banco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Servidor;
    }
}

