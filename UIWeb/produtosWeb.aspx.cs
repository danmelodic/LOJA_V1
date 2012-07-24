using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loja.Modelos;
using Loja.DAL;
using Loja.BLL;

namespace UIWeb
{
    public partial class produtosWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.nome = nomeTexteBox.Text;
                produto.preco = Convert.ToDecimal(precoTextBox.Text);
                produto.estoque = Convert.ToInt32(estoqueTextBox.Text);
                ProdutosBLL produtosbll = new ProdutosBLL();
                produtosbll.Incluir(produto);
                nomeTexteBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
            }
            catch (Exception ex)
            {
                Mensagem.Text = "Erro: " + ex.Message;
            }
        }
    }
}