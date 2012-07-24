using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DAL;
using Loja.Modelos;

namespace Loja.UIWindows
{
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtoDataGridView.DataSource = obj.Listagem("");

            // Atualizando os objetos TextBox
            codigoTextBox.Text = produtoDataGridView[0, produtoDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = produtoDataGridView[1, produtoDataGridView.CurrentRow.Index].Value.ToString();
            precoTextBox.Text = produtoDataGridView[2, produtoDataGridView.CurrentRow.Index].Value.ToString();
            estoqueTextBox.Text = produtoDataGridView[3, produtoDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            codigoTextBox.Text = "";
            nomeTextBox.Text = "";
            precoTextBox.Text = "";
            estoqueTextBox.Text = "";
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInformation produto = new ProdutoInformation();

                produto.nome = nomeTextBox.Text;
                produto.preco = Convert.ToDecimal(precoTextBox.Text);
                produto.estoque = Convert.ToInt32(estoqueTextBox.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Incluir(produto);
                MessageBox.Show("O produto foi incluído com sucesso!");
                codigoTextBox.Text = Convert.ToString(produto.codigo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            AtualizaGrid();

        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text == "")
            {
                MessageBox.Show("Um produto precisa ser selecionado para alteração.");
            }
            else
                try
                {
                    ProdutoInformation produto = new ProdutoInformation();

                    produto.codigo = int.Parse(codigoTextBox.Text);
                    produto.nome = nomeTextBox.Text;
                    produto.preco = Convert.ToDecimal(precoTextBox.Text);
                    produto.estoque = Convert.ToInt32(estoqueTextBox.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Alterar(produto);
                    MessageBox.Show("O produto foi atualizado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            AtualizaGrid();

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(codigoTextBox.Text);
                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("O produto foi excluído com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
        }


        private void produtosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Atualizando os objetos TextBox
            codigoTextBox.Text = produtoDataGridView[0, produtoDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = produtoDataGridView[1, produtoDataGridView.CurrentRow.Index].Value.ToString();
            precoTextBox.Text = produtoDataGridView[2, produtoDataGridView.CurrentRow.Index].Value.ToString();
            estoqueTextBox.Text = produtoDataGridView[3, produtoDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            // Comunicação com a Camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtoDataGridView.DataSource = obj.Listagem(txtFiltro.Text);

            // Atualizando os objetos TextBox
            try
            {
                codigoTextBox.Text = produtoDataGridView[0, produtoDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = produtoDataGridView[1, produtoDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = produtoDataGridView[2, produtoDataGridView.CurrentRow.Index].Value.ToString();
                estoqueTextBox.Text = produtoDataGridView[3, produtoDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
            }


        }
    }
}