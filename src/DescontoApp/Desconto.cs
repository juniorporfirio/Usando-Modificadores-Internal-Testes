namespace DescontoApp
{
    internal class Desconto
    {
        public decimal porValor(decimal valor)
        {
            if(valor > 1000)
                return valor * 0.1m;
            
            return 0;
        }
        
    }
}