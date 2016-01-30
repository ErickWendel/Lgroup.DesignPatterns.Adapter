using LGroup.Adapter.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Adapter.Business
{
    public sealed class BoletoItauBusiness : IBoleto
    {
        //EXISTE um termo chamado CODE SMELLS que significa
        //Sintomas de codigo Fedido (Mal feito)

        //1) Numeros Mágicos
        //Não podemos deixar numeros perdidos no meio do codigo
        //Principalmente dentro de IFS (Numberos CHUMBADOS)
        //Pq fica difícil dar manutenção, quem programou sabe o que
        //São os numeros, qualquer pessoa vai demorar 
        //Para entender o que sao aqueles numeros

        //Solução é criar constantes com nomes legíveis
        //Quando corrigimos um CODE SMELL o nome é REFATORACAO

        public void EmitirBoleto(Model.BoletoModel boleto_)
        {
            const decimal VALOR_MAXIMO_BOLETO = 15000;

            if (String.IsNullOrWhiteSpace(boleto_.Cedente))
                throw new ApplicationException("Informe o cedente");

            if (String.IsNullOrWhiteSpace(boleto_.Sacado))
                throw new ApplicationException("Informe o sacado");


            if (boleto_.Valor >= VALOR_MAXIMO_BOLETO)
                throw new ApplicationException("Valor Maximo Excedido");
        }
    }
}
