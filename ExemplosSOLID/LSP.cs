﻿using System.Collections.Generic;

namespace RuimLSP
{
    public class FonteArrecadadora
    {
        public int QIA { get; set; }
    }

    public class Cielo : FonteArrecadadora
    {
        public decimal CalcularTarifaCielo() => QIA * 1.63m;
    }

    public class CPFLPaulista : FonteArrecadadora
    {
        public decimal CalcularTarifaCPFL() => QIA * 0.8m;
    }

    public class ProcessoCalculo
    {
        public static void CalcularValores(List<FonteArrecadadora> fontesArrecadora)
        {
            foreach (var fonte in fontesArrecadora)
            {
                if (fonte is Cielo)
                {
                    (fonte as Cielo).CalcularTarifaCielo();
                }

                if (fonte is CPFLPaulista)
                {
                    (fonte as CPFLPaulista).CalcularTarifaCPFL();
                }
            }
        }
    }
}

namespace BomLSP
{
    public abstract class FonteArrecadadora
    {
        public int QIA { get; set; }

        public abstract decimal CalcularTarifa();
    }

    public class Cielo : FonteArrecadadora
    {
        public override decimal CalcularTarifa() => QIA * 1.63m;
    }

    public class CPFLPaulista : FonteArrecadadora
    {
        public override decimal CalcularTarifa() => QIA * 0.8m;
    }

    public class ProcessoCalculo
    {
        public static void CalcularValores(List<FonteArrecadadora> fontesArrecadora)
        {
            foreach (var fonte in fontesArrecadora)
            {
                fonte.CalcularTarifa();
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            var listaFontes = new List<FonteArrecadadora>
            {
                new Cielo()
                {
                    QIA = 651651
                },
                new CPFLPaulista()
                {
                    QIA = 10000
                }
            };

            ProcessoCalculo.CalcularValores(listaFontes);
        }
    }

}


