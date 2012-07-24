using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DAL;
using Loja.Modelos;

namespace Loja.UIWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm obj = new ClienteForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm  obj = new ProdutoForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendasForm obj = new VendasForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuariosDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsrLogin user = new UsrLogin();
            user.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedoresForm forform = new FornecedoresForm();
            forform.Show();
        }
    
    }
}
