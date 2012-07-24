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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ClienteBLL obj = new ClienteBLL();
            clienteDataGridView.DataSource = obj.Listagem(txtFiltro.Text);

            // Atualizando os objetos TextBox
            try
            {
                codigoTextBox.Text = clienteDataGridView[0, clienteDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = clienteDataGridView[1, clienteDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = clienteDataGridView[2, clienteDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = clienteDataGridView[3, clienteDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            codigoTextBox.Text = "";
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInformation cliente = new ClienteInformation();
                cliente.nome = nomeTextBox.Text;
                cliente.email = emailTextBox.Text;
                cliente.telefone = telefoneTextBox.Text;


                ClienteBLL obj = new ClienteBLL();
                obj.Incluir(cliente);
                MessageBox.Show("O cliente foi incluído com sucesso!");
                codigoTextBox.Text = Convert.ToString(cliente.codigo);
                AtualizaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
            }
            else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.codigo = int.Parse(codigoTextBox.Text);
                    cliente.nome = nomeTextBox.Text;
                    cliente.email = emailTextBox.Text;
                    cliente.telefone = telefoneTextBox.Text;


                    ClienteBLL obj = new ClienteBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    AtualizaGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(codigoTextBox.Text);
                    ClienteBLL obj = new ClienteBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("O cliente foi excluído com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
        }


        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Atualizando os objetos TextBox
            codigoTextBox.Text = clienteDataGridView[0, clienteDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = clienteDataGridView[1, clienteDataGridView.CurrentRow.Index].Value.ToString();
            emailTextBox.Text = clienteDataGridView[2, clienteDataGridView.CurrentRow.Index].Value.ToString();
            telefoneTextBox.Text = clienteDataGridView[3, clienteDataGridView.CurrentRow.Index].Value.ToString();


        }

        private void btFiltro_Click(object sender, EventArgs e)
        {

            // Comunicação com a Camada BLL
            ClienteBLL obj = new ClienteBLL();
            clienteDataGridView.DataSource = obj.Listagem(txtFiltro.Text);

            // Atualizando os objetos TextBox
            try
            {
                codigoTextBox.Text = clienteDataGridView[0, clienteDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = clienteDataGridView[1, clienteDataGridView.CurrentRow.Index].Value.ToString(); 
                emailTextBox.Text = clienteDataGridView[2, clienteDataGridView.CurrentRow.Index].Value.ToString(); 
                telefoneTextBox.Text = clienteDataGridView[3, clienteDataGridView.CurrentRow.Index].Value.ToString(); 
            }
            catch
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
