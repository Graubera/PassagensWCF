using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PassagensWCF
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente buscar(string nome);
        [OperationContract]
        void Add(Cliente c);
    }
}
