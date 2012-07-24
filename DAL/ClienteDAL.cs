using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Loja.DAL
{
    //Classe pública sendo criada.
    public class ClienteDAL 
    {
        //Um método é uma sequência nomeada de instruções. Neste caso é público e não solicita retorno de valor (void).
        //A lista de parâmetros é opcional e descreve os tipos e nomes das informações que você pode passar para o
        //método proceessar.
        public void Incluir(ClienteInformation cliente) 
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "insere_cliente";

                //parâmetros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 100);
                pnome.Value = cliente.nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pemail = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                pemail.Value = cliente.email;
                cmd.Parameters.Add(pemail);
                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.NVarChar, 80);
                ptelefone.Value = cliente.telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.codigo = (Int32)cmd.Parameters["@codigo"].Value;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
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

        public void Alterar(ClienteInformation cliente)
        {
            // conexao
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "altera_cliente";

                //parâmetros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = cliente.codigo;
                cmd.Parameters.Add(pcodigo);
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 100);
                pnome.Value = cliente.nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pemail = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                pemail.Value = cliente.email;
                cmd.Parameters.Add(pemail);
                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.NVarChar, 80);
                ptelefone.Value = cliente.telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
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

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "exclui_cliente";

                //parâmetros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente " + codigo);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
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
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "seleciona_cliente";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parâmetros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
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
    }
}
