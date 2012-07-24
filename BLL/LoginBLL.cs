using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.DAL;
using Loja.Modelos;
using System.Data;
using System.Collections;

namespace Loja.BLL
{
    public class LoginBLL
    {
        public void Incluir(LoginInformation lg) 
        {
            if (lg.NomeLogin.Trim().Length == 0)
            {
                throw new Exception("O nome do usuario é obrigatorio");             
            }
            if (lg.Senha.Length <= 6)
            {
                throw new Exception("A senha deve ter no minimo 6 caracter");
            }
            if(lg.Rsenha.Trim().Length == 0 || lg.Rsenha.Length <= 6)
            {
                throw new Exception("O nome do usuario é obrigatorio");
            }
            if (lg.Senha.ToString() != lg.Senha.ToString())
            {
                throw new Exception("Senhas digitadas incorretas !!");
            }
            LoginDAL lgdal = new LoginDAL();
            lgdal.Incluir(lg);
        }

        public void Alterar(LoginInformation lg)
        {
            if (lg.NomeLogin.Trim().Length == 0)
            {
                throw new Exception("O nome do usuario é obrigatorio");
            }
            if (lg.Senha.Length <= 6)
            {
                throw new Exception("A senha deve ter no minimo 6 caracter");
            }
            if (lg.Rsenha.Trim().Length == 0 || lg.Rsenha.Length <= 6)
            {
                throw new Exception("O nome do usuario é obrigatorio");
            }
            if (lg.Senha.ToString() != lg.Senha.ToString())
            {
                throw new Exception("Senhas digitadas incorretas !!");
            }
            LoginDAL lgDal = new LoginDAL();
            lgDal.Alterar(lg);
        }
        public void Deletar(string id)
        {            
            LoginDAL lgDal = new LoginDAL();
            lgDal.Deletar(id);
        }       
        public DataTable Listagem(string filtro)
        {
            LoginDAL lgDal = new LoginDAL();
            return lgDal.Listar(filtro);
        
        }

    }
}
