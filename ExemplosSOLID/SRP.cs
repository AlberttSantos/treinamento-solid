using System;
using System.Collections.Generic;
using System.Text;

namespace RuimSRP
{
    class CartaoCredito
    {
        public void VerificarLimite() { }    
        public void Cobrar() { }
        public void EnviarNotificacao() { }
    }
}

namespace BomSRP
{
    class LimiteCartaoCredito
    {
        public void VerificarLimite() { }
    }

    class CobrancaCartaoCredito
    {
        public void Cobrar() { }
    }

    class Notificacao
    {
        public void EnviarNotificacao() { }
    }
}