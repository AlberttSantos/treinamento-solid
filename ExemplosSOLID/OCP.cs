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

    class FormaPagamentoCartaoCredito : FormaPagamento
    {
        public override void Receber(decimal valor)
        {
            // cobrar cartaoCredito
        }
    }

    class FormaPagamentoDinheiro : FormaPagamento
    {
        public override void Receber(decimal valor)
        {
            // cobrar dinheiro
        }
    }
}