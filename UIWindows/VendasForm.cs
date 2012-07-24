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
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            clienteComboBox.DataSource = obj.ListaDeClientes;
            produtoComboBox.DataSource = obj.ListaDeProdutos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VendaInformation venda = new VendaInformation();
                venda.Quantidade = int.Parse(quantidadeTextBox.Text);
                venda.CodigoCliente = (int)clienteComboBox.SelectedValue;
                venda.CodigoProduto = (int)produtoComboBox.SelectedValue;
                venda.Data = DateTime.Now;
                venda.Faturado = false;

                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);

                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
