using System;
using System.Collections.Generic;
using System.Text;

namespace RuimOCP
{
    enum TipoPagamento
    {
        CartaoCredito,
        Dinheiro
    }

    class FormaPagamento
    {
        public void Receber(TipoPagamento tipoPagamento, decimal valor)
        {
            if (tipoPagamento == TipoPagamento.CartaoCredito)
            {
                // cobrar cartaoCredito
            }

            if (tipoPagamento == TipoPagamento.Dinheiro)
            {
                // cobrar dinheiro
            }
        }
    }
}

namespace BomOCP
{
    public abstract class FormaPagamento
    {
        public abstract void Receber(decimal valor);
    }

    class ReceberCartaoCredito : FormaPagamento
    {
        public override void Receber(decimal valor)
        {
            // cobrar cartaoCredito
        }
    }

    class ReceberDinheiro : FormaPagamento
    {
        public override void Receber(decimal valor)
        {
            // cobrar dinheiro
        }
    }
}