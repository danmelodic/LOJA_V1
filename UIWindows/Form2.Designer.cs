namespace Loja.UIWindows
{
    partial class Form2
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
            this.senhaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.validarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(25, 98);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(41, 13);
            this.senhaLabel.TabIndex = 0;
            this.senhaLabel.Text = "Senha:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(28, 38);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(83, 37);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(83, 91);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 3;
            // 
            // validarButton
            // 
            this.validarButton.Location = new System.Drawing.Point(108, 143);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(75, 23);
            this.validarButton.TabIndex = 4;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 473);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.senhaLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button validarButton;
    }
}