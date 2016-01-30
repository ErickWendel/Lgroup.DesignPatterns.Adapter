using LGroup.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Adapter.Business.Base
{
    public interface IAdministradora
    {
        void Pagar(PagamentoModel pagamento_);
    }
}
