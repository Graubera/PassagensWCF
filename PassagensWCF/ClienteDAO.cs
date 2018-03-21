using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagensWCF
{
    public class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente buscar(string nome)
        {
            var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            return (Cliente)resultado;
        }
    }
}
