using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Adapter.Model;
using UOL;
namespace LGroup.Adapter.Business
{
    //Criamos uma classe adaptadora para a partir de agora
    //fazer parte de uma familia interna de pagamentos
    //nesta class adaptadora temos que adaptar os dados
    //para serem evniados para a classe de pagamento via pagseguro
    public sealed class PagSeguroBusiness : PagSeguro, Base.IAdministradora
    {
        //Podemos implementar o padrao aDAPTADOR de 2 formas
        // COMPOSICAO (DAMOS UM NEW) = BOLETOS
        //HERANÇA (HERDAMOS) = ESSA CLASSE AQUI, OPERADORES
        public void Pagar(PagamentoModel pagamento_)
        {
            Debitar(pagamento_.Valor, pagamento_.Senha);
        }
    }
}
