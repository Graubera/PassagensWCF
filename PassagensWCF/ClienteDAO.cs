using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagensWCF
{
    public class ClienteDAO
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            this.clientes.Add(c);
        }

        public Cliente buscar(string nome)
        {
            var resultado = from c in clientes where c.Nome.Equals(nome) select c;
            return (Cliente)resultado;
        }
    }
}
