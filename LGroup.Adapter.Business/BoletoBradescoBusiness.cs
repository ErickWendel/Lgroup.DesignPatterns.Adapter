using LGroup.Adapter.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Adapter.Business
{
   public sealed  class BoletoBradescoBusiness : IBoleto
    {
        public void EmitirBoleto(Model.BoletoModel boleto_)
        {
            if (String.IsNullOrWhiteSpace(boleto_.Cedente))
                throw new ApplicationException("Informe o cedente");

            if (String.IsNullOrWhiteSpace(boleto_.Sacado))
                throw new ApplicationException("Informe o sacado");

            if (boleto_.Valor <= 0)
                throw new ApplicationException("Valor Inválido");

            //Emissao do boleto (ACIONARIA UM WEB SERVER OU INSERTIZAO)

        }
    }
}
