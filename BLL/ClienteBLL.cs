using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Modelos;
using Loja.DAL;
using System.Data;

namespace Loja.BLL
{
    public class ClienteBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            //E-mail é sempre em letras minúsculas
            cliente.email = cliente.email.ToLower();

            //Se tudo está Ok, chama a rotina de inserção.
            ClienteDAL obj = new ClienteDAL();
            obj.Incluir(cliente);
        }

        public void Alterar(ClienteInformation cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            //E-mail é sempre em letras minúsculas
            cliente.email = cliente.email.ToLower();

            //Se tudo está Ok, chama a rotina de alteração.
            ClienteDAL obj = new ClienteDAL();
            obj.Alterar(cliente);
        }

        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");
            }
            ClienteDAL obj = new ClienteDAL();
            obj.Excluir(codigo);
        }

        public DataTable Listagem(string filtro)
        {
            ClienteDAL obj = new ClienteDAL();
            return obj.Listagem(filtro);
        }
    }
}
