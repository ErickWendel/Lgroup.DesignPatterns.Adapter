using LGroup.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Adapter.Business
{
    public sealed class  MastercardBusiness
    {

        public void Pagar(PagamentoModel pagamento_)
        {
            const Decimal VALOR_MINIMO_PAGAMENTO = 10;

            if (String.IsNullOrWhiteSpace(pagamento_.Login))
                throw new ApplicationException("Informe o Login");

            if (String.IsNullOrWhiteSpace(pagamento_.Senha))
                throw new ApplicationException("Informe o Senha");
            
            if (pagamento_.Valor <= VALOR_MINIMO_PAGAMENTO)
                throw new ApplicationException("Valor minimo excedido");
        }
    }
}
