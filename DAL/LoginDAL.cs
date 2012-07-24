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
    public class LoginDAL
    {
       
        public string senha { get; set; }


        public void Excluir(int idlogin)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from Login where idlogin = " + idlogin;
                
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: "+ ex.Number);
            }
             catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Incluir(LoginInformation login)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into tb_Login (Senha, NomeLogin) values (@senha, @nome); select @@identity ";

               cmd.Parameters.AddWithValue("@nome", login.NomeLogin);
               cmd.Parameters.AddWithValue("@senha", login.Senha);

               cn.Open();
               cmd.ExecuteNonQuery();
               cn.Close();  

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
                throw new Exception("Servidor SQL erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(LoginInformation login)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update tb_Login set Senha = @senha, NomeLogin = @nomelogin where IdLogin=@idlogin; ";

                cmd.Parameters.AddWithValue("@idlogin", login.IdLogin);
                cmd.Parameters.AddWithValue("@senha", login.Senha);
                cmd.Parameters.AddWithValue("@nomelogin", login.NomeLogin);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
               
            }
                     
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ArrayList AtualizarUsuarioInserir(string filtro)
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            string sqlfiltro;

            if (filtro == "")
            {
                sqlfiltro = "select * from tb_Login";
            }
            else
            {
                sqlfiltro = "select * from tb_Login where nomelogin like '%" + filtro + "%";
            }
            cn.Open();
            SqlCommand cmd = new SqlCommand(sqlfiltro, cn);
            SqlDataReader drlg = cmd.ExecuteReader();

            ArrayList lista = new ArrayList();

            while (drlg.Read())
            {
                LoginInformation lg = new LoginInformation();
                lg.IdLogin = Convert.ToInt32(drlg["IdLogin"]);
                lg.NomeLogin = drlg["NomeLogin"].ToString();
                lg.Senha = drlg["Senha"].ToString();
                lista.Add(lg);
            }
            return lista;
        }
       

        public Boolean verificaLogin(LoginInformation login)
        {
            try
            {
                Console.WriteLine("entrou no dal");

                
                SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                
                cmd.CommandText = "select Senha from tb_Login where NomeLogin=@nome";
                cmd.CommandType = CommandType.Text;
                             
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nome";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Direction = ParameterDirection.Input;
                param.Value = login.NomeLogin.ToString();               
                cmd.Parameters.Add(param);

                
                cn.Open();
                SqlDataReader adoDR = null;
                adoDR = cmd.ExecuteReader();

                int numerodelinha = adoDR.FieldCount;
                Console.WriteLine(numerodelinha);
                Console.WriteLine(login.NomeLogin);
                                                                                                         
                    if (adoDR.Read())
                    {
                        Console.WriteLine("entrou no if");

                        String senhadobanco = null; 
                        senhadobanco = adoDR["Senha"].ToString();
                        Console.WriteLine(senhadobanco);
                        Console.WriteLine(login.Senha);

                        if (senhadobanco == login.Senha)
                        {
                            Console.WriteLine("entrou no if de senha = senha");
                            return true;
                        }
                        
                    }
                
                adoDR.Close();       
                cn.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
            }
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
                               
            return false;
               
        }

        public DataTable Listar(string filtro)
        {
            DataTable tabela = new DataTable();
            string sqlfiltro;
            if (filtro == "")
            {
                sqlfiltro = "select * from tb_Login";
            }
            else
            {
                sqlfiltro = "select * from tb_Login where NomeLogin like '%"+filtro+"%'";
            }
            SqlDataAdapter lgda = new SqlDataAdapter(sqlfiltro, Dados.StringDeConexao);
            lgda.Fill(tabela);
            return tabela;
        }
        public void Deletar(string id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from tb_Login where idLogin=@idlogin; ";

                cmd.Parameters.AddWithValue("@idlogin", id);
               
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
