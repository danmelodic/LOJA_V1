namespace Loja.UIWindows
{
    partial class ProdutoForm
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
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.btFiltro = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.incluirButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.estoqueLabel = new System.Windows.Forms.Label();
            this.precoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AllowUserToAddRows = false;
            this.produtoDataGridView.AllowUserToDeleteRows = false;
            this.produtoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Location = new System.Drawing.Point(10, 185);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.ReadOnly = true;
            this.produtoDataGridView.Size = new System.Drawing.Size(408, 233);
            this.produtoDataGridView.TabIndex = 29;
            this.produtoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosDataGridView_CellClick);
            // 
            // btFiltro
            // 
            this.btFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFiltro.Location = new System.Drawing.Point(190, 424);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 28;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(351, 136);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 27;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(270, 136);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 26;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(189, 136);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 25;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(108, 136);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 24;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(108, 70);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(200, 20);
            this.precoTextBox.TabIndex = 23;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(22, 425);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(161, 20);
            this.txtFiltro.TabIndex = 22;
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Location = new System.Drawing.Point(108, 102);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.estoqueTextBox.TabIndex = 21;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(108, 38);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 20;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(108, 6);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(70, 20);
            this.codigoTextBox.TabIndex = 19;
            // 
            // estoqueLabel
            // 
            this.estoqueLabel.AutoSize = true;
            this.estoqueLabel.Location = new System.Drawing.Point(14, 105);
            this.estoqueLabel.Name = "estoqueLabel";
            this.estoqueLabel.Size = new System.Drawing.Size(49, 13);
            this.estoqueLabel.TabIndex = 18;
            this.estoqueLabel.Text = "Estoque:";
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(14, 73);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(38, 13);
            this.precoLabel.TabIndex = 17;
            this.precoLabel.Text = "Preço:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(14, 41);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 16;
            this.nomeLabel.Text = "Nome:";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(14, 9);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 15;
            this.codigoLabel.Text = "Código";
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 452);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.estoqueLabel);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "ProdutoForm";
            this.Text = "ProdutoForm";
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label estoqueLabel;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label codigoLabel;
    }
}