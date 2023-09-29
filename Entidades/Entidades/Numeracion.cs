using System.Net;

namespace Entidades
{
    public class Numeracion
    {
        public enum ESistema
        {
            Decimal,
            Binario
        }

        private double valorNumerico;
        private ESistema sistema;

        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }
        public string Valor
        {
            get
            {
                return ConvertirA(this.sistema);
            }
        }

        public Numeracion(double valor, ESistema sistema)
            :this(valor.ToString(), sistema)
        {
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        // Metodos
        /// <summary>
        /// Inicializa los valores de la numeracion, internamente se trabajara con numeros
        /// </summary>
        /// <param name="valor">Es el numero decimal o binario</param>
        /// <param name="sistema">El sistema de numeracion del numero (decimal o binario)</param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            //* Si el valor es binario, lo convierte a decimal antes de guardarlo, de lo contrario verificará que sea un numero decimal.

            if (Sistema == ESistema.Binario && EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (!double.TryParse(valor, out valorNumerico)) 
            {
                //* Si no es un numero decimal, se inicializa con el valor minimo
                this.valorNumerico = double.MinValue;
            }

            this.sistema = sistema;
        }
        
        /// <summary>
        /// Convierte un string que representa un numero Binaro a un numero Decimal
        /// </summary>
        /// <param name="valor">Es la cadena con el numero binario a convertir</param>
        /// <returns>El numero convertido a decimal</returns>
        private static double BinarioADecimal(string valor)
        {
            if (!EsBinario(valor) && double.TryParse(valor, out double valorNumerico))
            {
                return valorNumerico;
            }

            double valorDecimal = 0;
            int potencia = 0;

            for (int i = valor.Length - 1; i >= 0; i--)
            {
                if (valor[i] == '1')
                {
                    valorDecimal += Math.Pow(2, potencia); // 2 ^ x
                }

                potencia++;
            }

            return valorDecimal;
        }

        /// <summary>
        /// Convierte un numero segun el sistema de numeracion
        /// </summary>
        /// <param name="sistema">Es el sistema al que se va a convertir el numero</param>
        /// <returns>Una cadena representada en un sistema de numeración basado en el parámetro recibido</returns>
        public string ConvertirA(ESistema sistema)
        {
            if (sistema == this.sistema)
            {
                return valorNumerico.ToString();
            }

            return (sistema == ESistema.Binario) ? DecimalABinario(Valor) : BinarioADecimal(Valor).ToString();
        }

        /// <summary>
        /// Convierte un string que representa un numero decimal a un numero binario
        /// </summary>
        /// <param name="valor">Es la cadena con el numero decimal a convertir</param>
        /// <returns>El numero convertido a binario o un mensaje de error en caso de que la cadena no represente un numero</returns>
        private static string DecimalABinario(string valor)
        {
            if (!int.TryParse(valor, out int valorDecimal) || valor.StartsWith('-'))
            {
                return "Valor inválido";
            }
            
            return DecimalABinario(valorDecimal); ;
        }

        /// <summary>
        /// Convierte un entero positivo a un numero binario
        /// </summary>
        /// <param name="valor">Es el numero decimal a convertir en binario</param>
        /// <returns>El numero convertido a binario</returns>
        private static string DecimalABinario(int valor)
        {
            string valorBinario = "";
            
            do
            {
                valorBinario = (valor % 2) + valorBinario;
                valor /= 2;
            }
            while (valor >= 2);
            valorBinario = valor + valorBinario;


            return valorBinario.PadLeft(4, '0');
        }

        /// <summary>
        /// Verifica que el valor recibido sea un numero binario
        /// </summary>
        /// <param name="valor">Una cadena que es un posible numero binario</param>
        /// <returns>True en caso de que el valor sea binario, False en caso de que no lo sea</returns>
        private static bool EsBinario(string valor)
        {
            if (valor.Length == 0)
            {
                return false;
            }

            foreach (char i in valor)
            {
                if (i != '0' && i != '1')
                {
                    return false;
                }   
            }

            return true;
        }

        // <Sobrecargas>
        //* Dos numeraciones serán iguales si pertenecen al mismo sistema.
        /// <summary>
        /// Determina si los sistemas de ambas numeraciones son iguales
        /// </summary>
        /// <param name="numeracion1"></param>
        /// <param name="numeracion2"></param>
        /// <returns></returns>
        public static bool operator ==(Numeracion numeracion1, Numeracion numeracion2)
        {
            return numeracion1.sistema == numeracion2.sistema;
        }
        /// <summary>
        /// Determina si los sistemas de ambas numeraciones son distintas
        /// </summary>
        /// <param name="numeracion1"></param>
        /// <param name="numeracion2"></param>
        /// <returns></returns>
        public static bool operator !=(Numeracion numeracion1, Numeracion numeracion2)
        {
            return !(numeracion1 == numeracion2);
        }

        //* Un Sistema y una Numeración serán iguales, si el sistema es igual a sistema de la numeración;
        /// <summary>
        /// Determina si el sistema de la numeracion y el sistema recibido son iguales
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns>True en caso de ser iguales, False en caso contrario</returns>
        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }
        /// <summary>
        /// Determina si el sistema de la numeracion y el sistema recibido son distintos
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns>True en caso de ser iguales, False en caso contrario</returns>
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        //* Los operadores realizarán las operaciones correspondientes entre dos números.
        public static Numeracion operator +(Numeracion numeracion1, Numeracion numeracion2)
        {
            return new Numeracion(numeracion1.valorNumerico + numeracion2.valorNumerico, ESistema.Decimal);
        }

        public static Numeracion operator -(Numeracion numeracion1, Numeracion numeracion2)
        {
            return new Numeracion(numeracion1.valorNumerico - numeracion2.valorNumerico, ESistema.Decimal);
        }
        
        public static Numeracion operator *(Numeracion numeracion1, Numeracion numeracion2)
        {
            return new Numeracion(numeracion1.valorNumerico * numeracion2.valorNumerico, ESistema.Decimal);
        }

        public static Numeracion operator /(Numeracion numeracion1, Numeracion numeracion2)
        {
            return new Numeracion(numeracion1.valorNumerico / numeracion2.valorNumerico, ESistema.Decimal);
        }
    }
}
