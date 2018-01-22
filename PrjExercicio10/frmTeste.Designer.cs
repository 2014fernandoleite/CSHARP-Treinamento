namespace PrjExercicio10
{
    partial class frmTeste
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
            this.btn_Ler = new System.Windows.Forms.Button();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.DGV_Dados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Comando = new System.Windows.Forms.TextBox();
            this.btn_Executar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ler
            // 
            this.btn_Ler.Location = new System.Drawing.Point(206, 10);
            this.btn_Ler.Name = "btn_Ler";
            this.btn_Ler.Size = new System.Drawing.Size(132, 23);
            this.btn_Ler.TabIndex = 0;
            this.btn_Ler.Text = "Pesquisa Estados";
            this.btn_Ler.UseVisualStyleBackColor = true;
            this.btn_Ler.Click += new System.EventHandler(this.btn_Ler_Click);
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(3, 12);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(168, 21);
            this.cbx_Estado.TabIndex = 1;
            this.cbx_Estado.SelectedIndexChanged += new System.EventHandler(this.cbx_Estado_SelectedIndexChanged);
            // 
            // DGV_Dados
            // 
            this.DGV_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Dados.Location = new System.Drawing.Point(3, 39);
            this.DGV_Dados.Name = "DGV_Dados";
            this.DGV_Dados.Size = new System.Drawing.Size(530, 183);
            this.DGV_Dados.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comando";
            // 
            // txt_Comando
            // 
            this.txt_Comando.Location = new System.Drawing.Point(12, 241);
            this.txt_Comando.Multiline = true;
            this.txt_Comando.Name = "txt_Comando";
            this.txt_Comando.Size = new System.Drawing.Size(439, 62);
            this.txt_Comando.TabIndex = 8;
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(457, 269);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(70, 23);
            this.btn_Executar.TabIndex = 9;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 304);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Comando);
            this.Controls.Add(this.DGV_Dados);
            this.Controls.Add(this.cbx_Estado);
            this.Controls.Add(this.btn_Ler);
            this.Name = "frmTeste";
            this.Text = "frmTeste";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ler;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.DataGridView DGV_Dados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Comando;
        private System.Windows.Forms.Button btn_Executar;
    }
}