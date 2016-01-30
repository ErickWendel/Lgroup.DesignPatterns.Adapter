using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Adapter.Model;
namespace LGroup.Adapter.Business
{
    public sealed class VisaBusiness
    {
        public void Pagar(PagamentoModel pagamento_)
        {
            if (String.IsNullOrWhiteSpace(pagamento_.Login))
                throw new ApplicationException("Informe o Login");

            if (String.IsNullOrWhiteSpace(pagamento_.Senha))
                throw new ApplicationException("Informe o Senha");
        }
    }
}
