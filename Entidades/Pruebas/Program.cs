using Entidades;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion x = new (10, ESistema.Decimal);
            Numeracion y = new(12, ESistema.Decimal);

            Operacion operacion = new (x, y);
            Numeracion resultado = operacion.Operar('+');

            Console.WriteLine(resultado.Valor);


            Console.WriteLine(Numeracion.BinarioADecimal("00111111"));
            
        }
    }
}