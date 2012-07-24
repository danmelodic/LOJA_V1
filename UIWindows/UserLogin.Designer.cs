namespace Loja.UIWindows
{
    partial class UsrLogin
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
            this.tbc_Usrlogin = new System.Windows.Forms.TabControl();
            this.tbp_UsrL_Inserir = new System.Windows.Forms.TabPage();
            this.txtb_Filtro = new System.Windows.Forms.TextBox();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.dtgvr_ListarUsuario = new System.Windows.Forms.DataGridView();
            this.txtb_Senha2 = new System.Windows.Forms.TextBox();
            this.txtb_Senha1 = new System.Windows.Forms.TextBox();
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.lb_Senha2 = new System.Windows.Forms.Label();
            this.lb_Senha1 = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.tbp_UsrL_Update = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FiltroAtButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.salvarAtButton = new System.Windows.Forms.Button();
            this.IDAtTextBox = new System.Windows.Forms.TextBox();
            this.IdLabelAt = new System.Windows.Forms.Label();
            this.senhaAtTextBox = new System.Windows.Forms.TextBox();
            this.NomeAtTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabelAt = new System.Windows.Forms.Label();
            this.NomeLabelAt = new System.Windows.Forms.Label();
            this.tbp_UsrL_Excluir = new System.Windows.Forms.TabPage();
            this.AtualizarExButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IDDelTextBox = new System.Windows.Forms.TextBox();
            this.tbc_Usrlogin.SuspendLayout();
            this.tbp_UsrL_Inserir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvr_ListarUsuario)).BeginInit();
            this.tbp_UsrL_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbp_UsrL_Excluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Usrlogin
            // 
            this.tbc_Usrlogin.Controls.Add(this.tbp_UsrL_Inserir);
            this.tbc_Usrlogin.Controls.Add(this.tbp_UsrL_Update);
            this.tbc_Usrlogin.Controls.Add(this.tbp_UsrL_Excluir);
            this.tbc_Usrlogin.Location = new System.Drawing.Point(12, 12);
            this.tbc_Usrlogin.Multiline = true;
            this.tbc_Usrlogin.Name = "tbc_Usrlogin";
            this.tbc_Usrlogin.SelectedIndex = 0;
            this.tbc_Usrlogin.Size = new System.Drawing.Size(408, 426);
            this.tbc_Usrlogin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbc_Usrlogin.TabIndex = 0;
            // 
            // tbp_UsrL_Inserir
            // 
            this.tbp_UsrL_Inserir.Controls.Add(this.txtb_Filtro);
            this.tbp_UsrL_Inserir.Controls.Add(this.bt_Atualizar);
            this.tbp_UsrL_Inserir.Controls.Add(this.dtgvr_ListarUsuario);
            this.tbp_UsrL_Inserir.Controls.Add(this.txtb_Senha2);
            this.tbp_UsrL_Inserir.Controls.Add(this.txtb_Senha1);
            this.tbp_UsrL_Inserir.Controls.Add(this.txtb_Nome);
            this.tbp_UsrL_Inserir.Controls.Add(this.lb_Senha2);
            this.tbp_UsrL_Inserir.Controls.Add(this.lb_Senha1);
            this.tbp_UsrL_Inserir.Controls.Add(this.lb_Nome);
            this.tbp_UsrL_Inserir.Controls.Add(this.bt_Ok);
            this.tbp_UsrL_Inserir.Location = new System.Drawing.Point(4, 22);
            this.tbp_UsrL_Inserir.Name = "tbp_UsrL_Inserir";
            this.tbp_UsrL_Inserir.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_UsrL_Inserir.Size = new System.Drawing.Size(400, 400);
            this.tbp_UsrL_Inserir.TabIndex = 0;
            this.tbp_UsrL_Inserir.Text = "Inserir";
            this.tbp_UsrL_Inserir.UseVisualStyleBackColor = true;
            // 
            // txtb_Filtro
            // 
            this.txtb_Filtro.Location = new System.Drawing.Point(24, 361);
            this.txtb_Filtro.Name = "txtb_Filtro";
            this.txtb_Filtro.Size = new System.Drawing.Size(212, 20);
            this.txtb_Filtro.TabIndex = 5;
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.Location = new System.Drawing.Point(162, 160);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_Atualizar.TabIndex = 4;
            this.bt_Atualizar.Text = "Atualizar";
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            this.bt_Atualizar.Click += new System.EventHandler(this.bt_Atualizar_Click);
            // 
            // dtgvr_ListarUsuario
            // 
            this.dtgvr_ListarUsuario.AllowUserToAddRows = false;
            this.dtgvr_ListarUsuario.AllowUserToDeleteRows = false;
            this.dtgvr_ListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvr_ListarUsuario.Location = new System.Drawing.Point(24, 189);
            this.dtgvr_ListarUsuario.Name = "dtgvr_ListarUsuario";
            this.dtgvr_ListarUsuario.ReadOnly = true;
            this.dtgvr_ListarUsuario.Size = new System.Drawing.Size(356, 160);
            this.dtgvr_ListarUsuario.TabIndex = 4;
            // 
            // txtb_Senha2
            // 
            this.txtb_Senha2.Location = new System.Drawing.Point(139, 118);
            this.txtb_Senha2.MaxLength = 10;
            this.txtb_Senha2.Name = "txtb_Senha2";
            this.txtb_Senha2.Size = new System.Drawing.Size(241, 20);
            this.txtb_Senha2.TabIndex = 2;
            this.txtb_Senha2.UseSystemPasswordChar = true;
            // 
            // txtb_Senha1
            // 
            this.txtb_Senha1.Location = new System.Drawing.Point(139, 77);
            this.txtb_Senha1.MaxLength = 10;
            this.txtb_Senha1.Name = "txtb_Senha1";
            this.txtb_Senha1.Size = new System.Drawing.Size(241, 20);
            this.txtb_Senha1.TabIndex = 1;
            this.txtb_Senha1.UseSystemPasswordChar = true;
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_Nome.Location = new System.Drawing.Point(139, 42);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(241, 20);
            this.txtb_Nome.TabIndex = 0;
            // 
            // lb_Senha2
            // 
            this.lb_Senha2.AutoSize = true;
            this.lb_Senha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha2.Location = new System.Drawing.Point(24, 118);
            this.lb_Senha2.Name = "lb_Senha2";
            this.lb_Senha2.Size = new System.Drawing.Size(107, 13);
            this.lb_Senha2.TabIndex = 3;
            this.lb_Senha2.Text = "Redigite a senha:";
            // 
            // lb_Senha1
            // 
            this.lb_Senha1.AutoSize = true;
            this.lb_Senha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha1.Location = new System.Drawing.Point(24, 77);
            this.lb_Senha1.Name = "lb_Senha1";
            this.lb_Senha1.Size = new System.Drawing.Size(47, 13);
            this.lb_Senha1.TabIndex = 2;
            this.lb_Senha1.Text = "Senha:";
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(21, 42);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(43, 13);
            this.lb_Nome.TabIndex = 1;
            this.lb_Nome.Text = "Nome:";
            // 
            // bt_Ok
            // 
            this.bt_Ok.Location = new System.Drawing.Point(56, 160);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 3;
            this.bt_Ok.Text = "Salvar";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click_1);
            // 
            // tbp_UsrL_Update
            // 
            this.tbp_UsrL_Update.Controls.Add(this.dataGridView1);
            this.tbp_UsrL_Update.Controls.Add(this.FiltroAtButton);
            this.tbp_UsrL_Update.Controls.Add(this.textBox4);
            this.tbp_UsrL_Update.Controls.Add(this.salvarAtButton);
            this.tbp_UsrL_Update.Controls.Add(this.IDAtTextBox);
            this.tbp_UsrL_Update.Controls.Add(this.IdLabelAt);
            this.tbp_UsrL_Update.Controls.Add(this.senhaAtTextBox);
            this.tbp_UsrL_Update.Controls.Add(this.NomeAtTextBox);
            this.tbp_UsrL_Update.Controls.Add(this.senhaLabelAt);
            this.tbp_UsrL_Update.Controls.Add(this.NomeLabelAt);
            this.tbp_UsrL_Update.Location = new System.Drawing.Point(4, 22);
            this.tbp_UsrL_Update.Name = "tbp_UsrL_Update";
            this.tbp_UsrL_Update.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_UsrL_Update.Size = new System.Drawing.Size(400, 400);
            this.tbp_UsrL_Update.TabIndex = 1;
            this.tbp_UsrL_Update.Text = "Atualizar";
            this.tbp_UsrL_Update.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(356, 160);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FiltroAtButton
            // 
            this.FiltroAtButton.Location = new System.Drawing.Point(283, 187);
            this.FiltroAtButton.Name = "FiltroAtButton";
            this.FiltroAtButton.Size = new System.Drawing.Size(75, 23);
            this.FiltroAtButton.TabIndex = 11;
            this.FiltroAtButton.Text = "Filtro";
            this.FiltroAtButton.UseVisualStyleBackColor = true;
            this.FiltroAtButton.Click += new System.EventHandler(this.FiltroAtButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 190);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // salvarAtButton
            // 
            this.salvarAtButton.Location = new System.Drawing.Point(24, 139);
            this.salvarAtButton.Name = "salvarAtButton";
            this.salvarAtButton.Size = new System.Drawing.Size(356, 23);
            this.salvarAtButton.TabIndex = 9;
            this.salvarAtButton.Text = "Salvar";
            this.salvarAtButton.UseVisualStyleBackColor = true;
            this.salvarAtButton.Click += new System.EventHandler(this.salvarAtButton_Click);
            // 
            // IDAtTextBox
            // 
            this.IDAtTextBox.Location = new System.Drawing.Point(139, 102);
            this.IDAtTextBox.MaxLength = 10;
            this.IDAtTextBox.Name = "IDAtTextBox";
            this.IDAtTextBox.Size = new System.Drawing.Size(241, 20);
            this.IDAtTextBox.TabIndex = 7;
            this.IDAtTextBox.UseSystemPasswordChar = true;
            // 
            // IdLabelAt
            // 
            this.IdLabelAt.AutoSize = true;
            this.IdLabelAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabelAt.Location = new System.Drawing.Point(24, 102);
            this.IdLabelAt.Name = "IdLabelAt";
            this.IdLabelAt.Size = new System.Drawing.Size(24, 13);
            this.IdLabelAt.TabIndex = 8;
            this.IdLabelAt.Text = "ID:";
            // 
            // senhaAtTextBox
            // 
            this.senhaAtTextBox.Location = new System.Drawing.Point(139, 65);
            this.senhaAtTextBox.MaxLength = 10;
            this.senhaAtTextBox.Name = "senhaAtTextBox";
            this.senhaAtTextBox.Size = new System.Drawing.Size(241, 20);
            this.senhaAtTextBox.TabIndex = 5;
            this.senhaAtTextBox.UseSystemPasswordChar = true;
            // 
            // NomeAtTextBox
            // 
            this.NomeAtTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NomeAtTextBox.Location = new System.Drawing.Point(139, 30);
            this.NomeAtTextBox.Name = "NomeAtTextBox";
            this.NomeAtTextBox.Size = new System.Drawing.Size(241, 20);
            this.NomeAtTextBox.TabIndex = 3;
            // 
            // senhaLabelAt
            // 
            this.senhaLabelAt.AutoSize = true;
            this.senhaLabelAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabelAt.Location = new System.Drawing.Point(24, 65);
            this.senhaLabelAt.Name = "senhaLabelAt";
            this.senhaLabelAt.Size = new System.Drawing.Size(47, 13);
            this.senhaLabelAt.TabIndex = 6;
            this.senhaLabelAt.Text = "Senha:";
            // 
            // NomeLabelAt
            // 
            this.NomeLabelAt.AutoSize = true;
            this.NomeLabelAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabelAt.Location = new System.Drawing.Point(21, 30);
            this.NomeLabelAt.Name = "NomeLabelAt";
            this.NomeLabelAt.Size = new System.Drawing.Size(43, 13);
            this.NomeLabelAt.TabIndex = 4;
            this.NomeLabelAt.Text = "Nome:";
            // 
            // tbp_UsrL_Excluir
            // 
            this.tbp_UsrL_Excluir.Controls.Add(this.IDDelTextBox);
            this.tbp_UsrL_Excluir.Controls.Add(this.AtualizarExButton);
            this.tbp_UsrL_Excluir.Controls.Add(this.dataGridView2);
            this.tbp_UsrL_Excluir.Controls.Add(this.ExcluirButton);
            this.tbp_UsrL_Excluir.Controls.Add(this.label1);
            this.tbp_UsrL_Excluir.Location = new System.Drawing.Point(4, 22);
            this.tbp_UsrL_Excluir.Name = "tbp_UsrL_Excluir";
            this.tbp_UsrL_Excluir.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_UsrL_Excluir.Size = new System.Drawing.Size(400, 400);
            this.tbp_UsrL_Excluir.TabIndex = 2;
            this.tbp_UsrL_Excluir.Text = "Excluir";
            this.tbp_UsrL_Excluir.UseVisualStyleBackColor = true;
            // 
            // AtualizarExButton
            // 
            this.AtualizarExButton.Location = new System.Drawing.Point(162, 82);
            this.AtualizarExButton.Name = "AtualizarExButton";
            this.AtualizarExButton.Size = new System.Drawing.Size(75, 23);
            this.AtualizarExButton.TabIndex = 14;
            this.AtualizarExButton.Text = "Atualizar";
            this.AtualizarExButton.UseVisualStyleBackColor = true;
            this.AtualizarExButton.Click += new System.EventHandler(this.AtualizarButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(356, 160);
            this.dataGridView2.TabIndex = 13;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(309, 38);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 12;
            this.ExcluirButton.Text = "Deletar";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IDDelTextBox
            // 
            this.IDDelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IDDelTextBox.Location = new System.Drawing.Point(50, 38);
            this.IDDelTextBox.Name = "IDDelTextBox";
            this.IDDelTextBox.Size = new System.Drawing.Size(241, 20);
            this.IDDelTextBox.TabIndex = 15;
            // 
            // UsrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbc_Usrlogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsrLogin";
            this.Text = "UsrLogin";
            this.tbc_Usrlogin.ResumeLayout(false);
            this.tbp_UsrL_Inserir.ResumeLayout(false);
            this.tbp_UsrL_Inserir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvr_ListarUsuario)).EndInit();
            this.tbp_UsrL_Update.ResumeLayout(false);
            this.tbp_UsrL_Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbp_UsrL_Excluir.ResumeLayout(false);
            this.tbp_UsrL_Excluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Usrlogin;
        private System.Windows.Forms.TabPage tbp_UsrL_Inserir;
        private System.Windows.Forms.TabPage tbp_UsrL_Update;
        private System.Windows.Forms.TabPage tbp_UsrL_Excluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb_Senha2;
        private System.Windows.Forms.TextBox txtb_Senha1;
        private System.Windows.Forms.TextBox txtb_Nome;
        private System.Windows.Forms.Label lb_Senha2;
        private System.Windows.Forms.Label lb_Senha1;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.DataGridView dtgvr_ListarUsuario;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.TextBox txtb_Filtro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FiltroAtButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button salvarAtButton;
        private System.Windows.Forms.TextBox IDAtTextBox;
        private System.Windows.Forms.Label IdLabelAt;
        private System.Windows.Forms.TextBox senhaAtTextBox;
        private System.Windows.Forms.TextBox NomeAtTextBox;
        private System.Windows.Forms.Label senhaLabelAt;
        private System.Windows.Forms.Label NomeLabelAt;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AtualizarExButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox IDDelTextBox;

    }
}