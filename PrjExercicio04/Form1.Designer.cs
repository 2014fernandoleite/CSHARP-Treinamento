namespace PrjExercicio04
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
            this.btn_While = new System.Windows.Forms.Button();
            this.btn_doWhile = new System.Windows.Forms.Button();
            this.btn_For = new System.Windows.Forms.Button();
            this.btn_ForEach = new System.Windows.Forms.Button();
            this.txt_Texto1 = new System.Windows.Forms.TextBox();
            this.txt_Texto2 = new System.Windows.Forms.TextBox();
            this.chk_CheckBox = new System.Windows.Forms.CheckBox();
            this.opt_RadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_While
            // 
            this.btn_While.Location = new System.Drawing.Point(25, 122);
            this.btn_While.Name = "btn_While";
            this.btn_While.Size = new System.Drawing.Size(75, 23);
            this.btn_While.TabIndex = 6;
            this.btn_While.Text = "While";
            this.btn_While.UseVisualStyleBackColor = true;
            this.btn_While.Click += new System.EventHandler(this.btn_While_Click);
            // 
            // btn_doWhile
            // 
            this.btn_doWhile.Location = new System.Drawing.Point(185, 122);
            this.btn_doWhile.Name = "btn_doWhile";
            this.btn_doWhile.Size = new System.Drawing.Size(75, 23);
            this.btn_doWhile.TabIndex = 7;
            this.btn_doWhile.Text = "Do While";
            this.btn_doWhile.UseVisualStyleBackColor = true;
            this.btn_doWhile.Click += new System.EventHandler(this.btn_doWhile_Click);
            // 
            // btn_For
            // 
            this.btn_For.Location = new System.Drawing.Point(25, 81);
            this.btn_For.Name = "btn_For";
            this.btn_For.Size = new System.Drawing.Size(75, 23);
            this.btn_For.TabIndex = 4;
            this.btn_For.Text = "For";
            this.btn_For.UseVisualStyleBackColor = true;
            this.btn_For.Click += new System.EventHandler(this.btn_For_Click);
            // 
            // btn_ForEach
            // 
            this.btn_ForEach.Location = new System.Drawing.Point(185, 81);
            this.btn_ForEach.Name = "btn_ForEach";
            this.btn_ForEach.Size = new System.Drawing.Size(75, 23);
            this.btn_ForEach.TabIndex = 5;
            this.btn_ForEach.Text = "For Each";
            this.btn_ForEach.UseVisualStyleBackColor = true;
            this.btn_ForEach.Click += new System.EventHandler(this.btn_ForEach_Click);
            // 
            // txt_Texto1
            // 
            this.txt_Texto1.Location = new System.Drawing.Point(12, 12);
            this.txt_Texto1.Name = "txt_Texto1";
            this.txt_Texto1.Size = new System.Drawing.Size(100, 20);
            this.txt_Texto1.TabIndex = 0;
            // 
            // txt_Texto2
            // 
            this.txt_Texto2.Location = new System.Drawing.Point(169, 12);
            this.txt_Texto2.Name = "txt_Texto2";
            this.txt_Texto2.Size = new System.Drawing.Size(100, 20);
            this.txt_Texto2.TabIndex = 1;
            // 
            // chk_CheckBox
            // 
            this.chk_CheckBox.AutoSize = true;
            this.chk_CheckBox.Location = new System.Drawing.Point(25, 50);
            this.chk_CheckBox.Name = "chk_CheckBox";
            this.chk_CheckBox.Size = new System.Drawing.Size(75, 17);
            this.chk_CheckBox.TabIndex = 2;
            this.chk_CheckBox.Text = "CheckBox";
            this.chk_CheckBox.UseVisualStyleBackColor = true;
            // 
            // opt_RadioButton
            // 
            this.opt_RadioButton.AutoSize = true;
            this.opt_RadioButton.Location = new System.Drawing.Point(185, 50);
            this.opt_RadioButton.Name = "opt_RadioButton";
            this.opt_RadioButton.Size = new System.Drawing.Size(84, 17);
            this.opt_RadioButton.TabIndex = 3;
            this.opt_RadioButton.TabStop = true;
            this.opt_RadioButton.Text = "RadioButton";
            this.opt_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 168);
            this.Controls.Add(this.opt_RadioButton);
            this.Controls.Add(this.chk_CheckBox);
            this.Controls.Add(this.txt_Texto2);
            this.Controls.Add(this.txt_Texto1);
            this.Controls.Add(this.btn_ForEach);
            this.Controls.Add(this.btn_For);
            this.Controls.Add(this.btn_doWhile);
            this.Controls.Add(this.btn_While);
            this.Name = "Form1";
            this.Text = "Estruturas de Repetição e Controles da tela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_While;
        private System.Windows.Forms.Button btn_doWhile;
        private System.Windows.Forms.Button btn_For;
        private System.Windows.Forms.Button btn_ForEach;
        private System.Windows.Forms.TextBox txt_Texto1;
        private System.Windows.Forms.TextBox txt_Texto2;
        private System.Windows.Forms.CheckBox chk_CheckBox;
        private System.Windows.Forms.RadioButton opt_RadioButton;
    }
}

