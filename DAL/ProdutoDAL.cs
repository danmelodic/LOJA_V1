using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Modelos;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Loja.DAL
{
    public class ProdutoDAL
    {
        public ArrayList ProdutosEmFalta()
        {

            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            SqlCommand cmd = new SqlCommand("Select * from Produtos Where Estoque < 10", cn);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista = new ArrayList();
            while (dr.Read())
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.codigo = Convert.ToInt32(dr["codigo"]);
                produto.nome = dr["nome"].ToString();
                produto.estoque = Convert.ToInt32(dr["estoque"]);
                produto.preco = Convert.ToDecimal(dr["preco"]);
                lista.Add(produto);

            }

            dr.Close();
            cn.Close();

            return lista;
        }

        public void Incluir(ProdutoInformation produto)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Produtos(nome,preco,estoque) values (@nome,@preco,@estoque); select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@nome", produto.nome);
                cmd.Parameters.AddWithValue("@preco", produto.preco);
                cmd.Parameters.AddWithValue("@estoque", produto.estoque);

                cn.Open();
                produto.codigo = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public void Alterar(ProdutoInformation produto)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Produtos set nome = @nome, preco = @preco, estoque = @estoque where codigo = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", produto.codigo);
                cmd.Parameters.AddWithValue("@nome", produto.nome);
                cmd.Parameters.AddWithValue("@preco", produto.preco);
                cmd.Parameters.AddWithValue("@estoque", produto.estoque);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public void Excluir(int codigo)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from Produtos where codigo = " + codigo;

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto " + codigo);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void ExcluircomClasse(ProdutoInformation produto)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from Produtos where codigo = @codigo ";
                cmd.Parameters.AddWithValue("@codigo", produto.codigo);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto " + produto.codigo);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Listagem(string filtro)
        {
            DataTable tabela = new DataTable();
            string strSql;
            if (filtro == "")
            {
                strSql = "select * from produtos";
            }
            else
            {
                strSql = "select * from produtos where nome like '%" + filtro + "%'";
            }
            SqlDataAdapter da = new SqlDataAdapter(strSql, Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
