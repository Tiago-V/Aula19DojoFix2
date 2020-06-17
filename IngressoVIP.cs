namespace DojoFix2
{
    public class IngressoVIP : Ingresso
    {
        public float ValorAd { get; set; }

        public float Result { get; set; }
        public void ValorAdicional(){

            Result = Valor + ValorAd;

            System.Console.WriteLine("O valor do ingresso VIP é "+Result);

        }
        public void DifPreco(){

            float Dif = Result - Valor;

            System.Console.WriteLine("A diferença de preço entre o ingresso comum e o VIP é de "+Dif);

        }
    }
}