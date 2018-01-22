namespace PrjExercicio02
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.txt_Entrada = new System.Windows.Forms.TextBox();
            this.btn_Texto = new System.Windows.Forms.Button();
            this.Btn_Int16 = new System.Windows.Forms.Button();
            this.Btn_Int32 = new System.Windows.Forms.Button();
            this.Btn_Int64 = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Decimal = new System.Windows.Forms.Button();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.Btn_Double = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(232, 155);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 9;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // txt_Entrada
            // 
            this.txt_Entrada.Location = new System.Drawing.Point(36, 12);
            this.txt_Entrada.Name = "txt_Entrada";
            this.txt_Entrada.Size = new System.Drawing.Size(271, 20);
            this.txt_Entrada.TabIndex = 0;
            // 
            // btn_Texto
            // 
            this.btn_Texto.Location = new System.Drawing.Point(36, 67);
            this.btn_Texto.Name = "btn_Texto";
            this.btn_Texto.Size = new System.Drawing.Size(75, 23);
            this.btn_Texto.TabIndex = 2;
            this.btn_Texto.Text = "Texto ?";
            this.btn_Texto.UseVisualStyleBackColor = true;
            this.btn_Texto.Click += new System.EventHandler(this.btn_Texto_Click);
            // 
            // Btn_Int16
            // 
            this.Btn_Int16.Location = new System.Drawing.Point(36, 97);
            this.Btn_Int16.Name = "Btn_Int16";
            this.Btn_Int16.Size = new System.Drawing.Size(75, 23);
            this.Btn_Int16.TabIndex = 3;
            this.Btn_Int16.Text = "Int16 ?";
            this.Btn_Int16.UseVisualStyleBackColor = true;
            this.Btn_Int16.Click += new System.EventHandler(this.Btn_Int16_Click);
            // 
            // Btn_Int32
            // 
            this.Btn_Int32.Location = new System.Drawing.Point(36, 127);
            this.Btn_Int32.Name = "Btn_Int32";
            this.Btn_Int32.Size = new System.Drawing.Size(75, 23);
            this.Btn_Int32.TabIndex = 4;
            this.Btn_Int32.Text = "Int32 ?";
            this.Btn_Int32.UseVisualStyleBackColor = true;
            this.Btn_Int32.Click += new System.EventHandler(this.Btn_Int32_Click);
            // 
            // Btn_Int64
            // 
            this.Btn_Int64.Location = new System.Drawing.Point(36, 156);
            this.Btn_Int64.Name = "Btn_Int64";
            this.Btn_Int64.Size = new System.Drawing.Size(75, 23);
            this.Btn_Int64.TabIndex = 5;
            this.Btn_Int64.Text = "Int64 ?";
            this.Btn_Int64.UseVisualStyleBackColor = true;
            this.Btn_Int64.Click += new System.EventHandler(this.Btn_Int64_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Location = new System.Drawing.Point(232, 126);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(75, 23);
            this.Btn_Data.TabIndex = 8;
            this.Btn_Data.Text = "Data ?";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Decimal
            // 
            this.Btn_Decimal.Location = new System.Drawing.Point(232, 67);
            this.Btn_Decimal.Name = "Btn_Decimal";
            this.Btn_Decimal.Size = new System.Drawing.Size(75, 23);
            this.Btn_Decimal.TabIndex = 6;
            this.Btn_Decimal.Text = "Decimal ?";
            this.Btn_Decimal.UseVisualStyleBackColor = true;
            this.Btn_Decimal.Click += new System.EventHandler(this.Btn_Decimal_Click);
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.Location = new System.Drawing.Point(36, 38);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(271, 23);
            this.Btn_Convert.TabIndex = 1;
            this.Btn_Convert.Text = "Sem controle Erro";
            this.Btn_Convert.UseVisualStyleBackColor = true;
            this.Btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // Btn_Double
            // 
            this.Btn_Double.Location = new System.Drawing.Point(232, 97);
            this.Btn_Double.Name = "Btn_Double";
            this.Btn_Double.Size = new System.Drawing.Size(75, 23);
            this.Btn_Double.TabIndex = 7;
            this.Btn_Double.Text = "Double ?";
            this.Btn_Double.UseVisualStyleBackColor = true;
            this.Btn_Double.Click += new System.EventHandler(this.Btn_Double_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 186);
            this.Controls.Add(this.Btn_Double);
            this.Controls.Add(this.Btn_Convert);
            this.Controls.Add(this.Btn_Decimal);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Int64);
            this.Controls.Add(this.Btn_Int32);
            this.Controls.Add(this.Btn_Int16);
            this.Controls.Add(this.btn_Texto);
            this.Controls.Add(this.txt_Entrada);
            this.Controls.Add(this.Btn_Sair);
            this.Name = "Form1";
            this.Text = "Tipos de dados e Tratamento Erro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.TextBox txt_Entrada;
        private System.Windows.Forms.Button btn_Texto;
        private System.Windows.Forms.Button Btn_Int16;
        private System.Windows.Forms.Button Btn_Int32;
        private System.Windows.Forms.Button Btn_Int64;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Decimal;
        private System.Windows.Forms.Button Btn_Convert;
        private System.Windows.Forms.Button Btn_Double;
    }
}

