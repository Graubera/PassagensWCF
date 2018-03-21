using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagensWCF
{
    class ClienteService : iClienteService
    {
        public void Add(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Add(c);
        }

        public Cliente buscar(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.buscar(nome);
        }
    }
}
