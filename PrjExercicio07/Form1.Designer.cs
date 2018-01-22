namespace PrjExercicio07
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
            this.btn_Diferenca = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn_DataHora = new System.Windows.Forms.Button();
            this.btn_Data = new System.Windows.Forms.Button();
            this.btn_Hora = new System.Windows.Forms.Button();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Hota = new System.Windows.Forms.Label();
            this.lbl_Atual = new System.Windows.Forms.Label();
            this.dtp_DtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_DFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SomarDias = new System.Windows.Forms.Button();
            this.txt_NrDias = new System.Windows.Forms.TextBox();
            this.txt_ResultSoma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Diferenca
            // 
            this.btn_Diferenca.Location = new System.Drawing.Point(254, 136);
            this.btn_Diferenca.Name = "btn_Diferenca";
            this.btn_Diferenca.Size = new System.Drawing.Size(75, 23);
            this.btn_Diferenca.TabIndex = 5;
            this.btn_Diferenca.Text = "Diferença Dias";
            this.btn_Diferenca.UseVisualStyleBackColor = true;
            this.btn_Diferenca.Click += new System.EventHandler(this.btn_Diferenca_Click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(351, 136);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(60, 20);
            this.txt_Resultado.TabIndex = 6;
            // 
            // btn_DataHora
            // 
            this.btn_DataHora.Location = new System.Drawing.Point(12, 12);
            this.btn_DataHora.Name = "btn_DataHora";
            this.btn_DataHora.Size = new System.Drawing.Size(75, 23);
            this.btn_DataHora.TabIndex = 0;
            this.btn_DataHora.Text = "Data Hora";
            this.btn_DataHora.UseVisualStyleBackColor = true;
            this.btn_DataHora.Click += new System.EventHandler(this.btn_DataHora_Click);
            // 
            // btn_Data
            // 
            this.btn_Data.Location = new System.Drawing.Point(12, 41);
            this.btn_Data.Name = "btn_Data";
            this.btn_Data.Size = new System.Drawing.Size(75, 23);
            this.btn_Data.TabIndex = 1;
            this.btn_Data.Text = "Data";
            this.btn_Data.UseVisualStyleBackColor = true;
            this.btn_Data.Click += new System.EventHandler(this.btn_Data_Click);
            // 
            // btn_Hora
            // 
            this.btn_Hora.Location = new System.Drawing.Point(12, 70);
            this.btn_Hora.Name = "btn_Hora";
            this.btn_Hora.Size = new System.Drawing.Size(75, 23);
            this.btn_Hora.TabIndex = 2;
            this.btn_Hora.Text = "Hora";
            this.btn_Hora.UseVisualStyleBackColor = true;
            this.btn_Hora.Click += new System.EventHandler(this.btn_Hora_Click);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(93, 46);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(35, 13);
            this.lbl_Data.TabIndex = 7;
            this.lbl_Data.Text = "label2";
            // 
            // lbl_Hota
            // 
            this.lbl_Hota.AutoSize = true;
            this.lbl_Hota.Location = new System.Drawing.Point(93, 75);
            this.lbl_Hota.Name = "lbl_Hota";
            this.lbl_Hota.Size = new System.Drawing.Size(35, 13);
            this.lbl_Hota.TabIndex = 8;
            this.lbl_Hota.Text = "label3";
            // 
            // lbl_Atual
            // 
            this.lbl_Atual.AutoSize = true;
            this.lbl_Atual.Location = new System.Drawing.Point(93, 17);
            this.lbl_Atual.Name = "lbl_Atual";
            this.lbl_Atual.Size = new System.Drawing.Size(35, 13);
            this.lbl_Atual.TabIndex = 9;
            this.lbl_Atual.Text = "label2";
            // 
            // dtp_DtInicio
            // 
            this.dtp_DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DtInicio.Location = new System.Drawing.Point(15, 139);
            this.dtp_DtInicio.Name = "dtp_DtInicio";
            this.dtp_DtInicio.Size = new System.Drawing.Size(96, 20);
            this.dtp_DtInicio.TabIndex = 3;
            // 
            // dtp_DFinal
            // 
            this.dtp_DFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DFinal.Location = new System.Drawing.Point(135, 139);
            this.dtp_DFinal.Name = "dtp_DFinal";
            this.dtp_DFinal.Size = new System.Drawing.Size(96, 20);
            this.dtp_DFinal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Final";
            // 
            // btn_SomarDias
            // 
            this.btn_SomarDias.Location = new System.Drawing.Point(254, 178);
            this.btn_SomarDias.Name = "btn_SomarDias";
            this.btn_SomarDias.Size = new System.Drawing.Size(75, 23);
            this.btn_SomarDias.TabIndex = 14;
            this.btn_SomarDias.Text = "Somar Dias";
            this.btn_SomarDias.UseVisualStyleBackColor = true;
            this.btn_SomarDias.Click += new System.EventHandler(this.btn_SomarDias_Click);
            // 
            // txt_NrDias
            // 
            this.txt_NrDias.Location = new System.Drawing.Point(184, 181);
            this.txt_NrDias.Name = "txt_NrDias";
            this.txt_NrDias.Size = new System.Drawing.Size(47, 20);
            this.txt_NrDias.TabIndex = 15;
            // 
            // txt_ResultSoma
            // 
            this.txt_ResultSoma.Location = new System.Drawing.Point(351, 180);
            this.txt_ResultSoma.Name = "txt_ResultSoma";
            this.txt_ResultSoma.Size = new System.Drawing.Size(95, 20);
            this.txt_ResultSoma.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 222);
            this.Controls.Add(this.txt_ResultSoma);
            this.Controls.Add(this.txt_NrDias);
            this.Controls.Add(this.btn_SomarDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_DFinal);
            this.Controls.Add(this.dtp_DtInicio);
            this.Controls.Add(this.lbl_Atual);
            this.Controls.Add(this.lbl_Hota);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.btn_Hora);
            this.Controls.Add(this.btn_Data);
            this.Controls.Add(this.btn_DataHora);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.btn_Diferenca);
            this.Name = "Form1";
            this.Text = "Funções de Data/Hora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Diferenca;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_DataHora;
        private System.Windows.Forms.Button btn_Data;
        private System.Windows.Forms.Button btn_Hora;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Hota;
        private System.Windows.Forms.Label lbl_Atual;
        private System.Windows.Forms.DateTimePicker dtp_DtInicio;
        private System.Windows.Forms.DateTimePicker dtp_DFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SomarDias;
        private System.Windows.Forms.TextBox txt_NrDias;
        private System.Windows.Forms.TextBox txt_ResultSoma;
    }
}

