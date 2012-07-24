using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Loja.Modelos;
using Loja.DAL;


namespace Loja.BLL
{
    public class ProdutosBLL
    {

        public ArrayList ProdutosEmFalta()
        {
            
            ProdutoDAL obj = new ProdutoDAL();
            return obj.ProdutosEmFalta();

        }

        public void Incluir(ProdutoInformation produto)
        {
            // Nome do produto é obrigatório
            if (produto.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            // O preço do produto não pode ser negativo
            if (produto.preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }

            // O estoque do produto não pode ser negativo
            if (produto.estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }

            //Se tudo estiver ok, chama a rotina de gravação
            ProdutoDAL obj = new ProdutoDAL();
            obj.Incluir(produto);

        }

        public void Alterar(ProdutoInformation produto)
        {
            // Nome do produto é obrigatório
            if (produto.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            // O preço do produto não pode ser negativo
            if (produto.preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }

            // O estoque do produto não pode ser negativo
            if (produto.estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }

            //Se tudo estiver ok, chama a rotina de alteração
            ProdutoDAL obj = new ProdutoDAL();
            obj.Alterar(produto);
        }

        public void Excluir(int codigo)
        {
            ProdutoDAL obj = new ProdutoDAL();
            obj.Excluir(codigo);
        }
        public void ExcluircomClasse(ProdutoInformation produto)
        {
            ProdutoDAL obj = new ProdutoDAL();
            obj.ExcluircomClasse(produto);
        }

        public DataTable Listagem(string filtro)
        {
            ProdutoDAL obj = new ProdutoDAL();
            return obj.Listagem(filtro);
        }
    }
}
