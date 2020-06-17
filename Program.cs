using System;

namespace DojoFix2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso invite = new Ingresso();
            IngressoVIP vip = new IngressoVIP();

            vip.Valor = 10f;
            vip.ValorAd = 5.5f;

            vip.ImprimirValor();
            vip.ValorAdicional();
            vip.DifPreco();

        }
    }
}
