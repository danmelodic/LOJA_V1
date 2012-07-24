namespace Loja.UIWindows
{
    partial class ClienteForm
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
            this.codigoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.incluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.btFiltro = new System.Windows.Forms.Button();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(16, 32);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Código";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(16, 64);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(16, 96);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail:";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(16, 128);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 3;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(110, 29);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(70, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(110, 61);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(110, 125);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneTextBox.TabIndex = 6;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(24, 448);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(161, 20);
            this.txtFiltro.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(110, 93);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(110, 159);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 9;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(191, 159);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 10;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(272, 159);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 11;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(353, 159);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 12;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // btFiltro
            // 
            this.btFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFiltro.Location = new System.Drawing.Point(192, 447);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 13;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 208);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.Size = new System.Drawing.Size(408, 233);
            this.clienteDataGridView.TabIndex = 14;
            this.clienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGridView_CellClick);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 473);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.DataGridView clienteDataGridView;
    }
}