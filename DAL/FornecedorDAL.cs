using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Modelos;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace Loja.DAL
{
    public class FornecedorDAL
    {

        public void IncluirFornecedor(FornecedorInformation fornecedor)
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
                cmd.CommandText = "insere_fornecedor";

                //parâmetros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.NVarChar, 30);
                pnome.Value = fornecedor.nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pemail = new SqlParameter("@categoria", SqlDbType.NVarChar, 30);
                pemail.Value = fornecedor.categoria;
                cmd.Parameters.Add(pemail);
                SqlParameter ptelefone = new SqlParameter("@cidade", SqlDbType.NVarChar, 30);
                ptelefone.Value = fornecedor.cidade;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                fornecedor.codigo = (Int32)cmd.Parameters["@codigo"].Value;

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
