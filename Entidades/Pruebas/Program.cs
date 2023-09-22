using Entidades;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion x = new("1010", Numeracion.ESistema.Binario);
            Numeracion y = new("123", Numeracion.ESistema.Decimal);

            Operacion operacion = new(x, y);

            //Numeracion resultado = operacion.Operar('+');

            Console.WriteLine($"La suma es: {y.Valor}");
        }
    }
}