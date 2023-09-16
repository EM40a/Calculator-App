namespace Entidades
{
    public enum ESistema
    {
        Binario,
        Decimal
    }

    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public string Valor
        {
            get => this.valorNumerico.ToString();
        }
        public ESistema Sistema
        {
            get => this.sistema;
        }

        public Numeracion(double valor, ESistema sistema)
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }
        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        private void InicializarValores(string valor, ESistema sistema)
        {
            // Si el valor es un binario, lo convertirá a decimal antes de guardarlo, de lo contrario verificará que sea un numero decimal. En caso de que no se cumplan ninguna de las condiciones antes dadas, internamente se almacenara el MinValue de un double

            if (EsBinario(valor))
            {
                double valorDecimal = BinarioADecimal(valor);
                this.valorNumerico = valorDecimal;
                this.sistema = ESistema.Decimal;
            }
            else if (!double.TryParse(valor, out valorNumerico))
            {
                this.valorNumerico = double.MinValue;
            }

            this.sistema = sistema;
        }
        
        /// <summary>
        /// Convierte un string que representa un numero Binaro a un numero Decimal
        /// </summary>
        /// <param name="valor">Es la cadena con el numero binario a convertir</param>
        /// <returns>El numero convertido a decimal</returns>
        public static double BinarioADecimal(string valor)
        {
            if (!EsBinario(valor))
            {
                return 0;
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
            if (sistema == ESistema.Binario)
            {
                double retornoDecimal = BinarioADecimal(Valor);
                return retornoDecimal.ToString();
            }
            else if (sistema == ESistema.Decimal)
            {
                double retornoBinario = DecimalABinario(Valor);
                return retornoBinario.ToString();
            }
            return "Sistema inválido";
        }

        /// <summary>
        /// Convierte un string que representa un numero Decimal a un numero Binario
        /// </summary>
        /// <param name="valor">Es la cadena con el numero decimal a convertir</param>
        /// <returns>El numero convertido a binario</returns>
        public double DecimalABinario(string valor)
        {
            if (EsBinario(valor))
            {
                return 0;
            }
            double valorBinario = 0;
            int resto = 0;
            // 134

            if (int.TryParse(valor, out int valorDecimal))
            {
                while (resto < 2)
                {
                    resto = valorDecimal % 2;
                    valorDecimal = resto + valorDecimal;
                }

            }

            for (int i = 0; i < 2; i++)
            {
                valorBinario += resto;
            }

            return valorBinario;
        }

        public double DecimalABinario(int valor)
        {
            // TODO
            if (!EsBinario(valor.ToString()))
            {
                return 0;
            }
            double valorDecimal = 0;
            int potencia = 0;
            return valorDecimal;
        }

        /// <summary>
        /// Verifica que el valor recibido sea un numero binario
        /// </summary>
        /// <param name="valor">Una cadena que es un posible numero binario</param>
        /// <returns>True en caso de que el valor sea binario, False en caso de que no lo sea</returns>
        private static bool EsBinario(string valor)
        {
            foreach (char i in valor)
            {
                if (i != '0' && i != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(Numeracion num1, Numeracion num2)
        {
            return num1.Valor == num2.Valor;
        }
        public static bool operator !=(Numeracion num1, Numeracion num2)
        {
            return !(num1 == num2);
        }

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
            return !(sistema == numeracion.sistema);
        }

        public static Numeracion operator +(Numeracion num1, Numeracion num2)
        {
            return new Numeracion(num1.valorNumerico + num2.valorNumerico, num1.Sistema);
        }

        public static Numeracion operator -(Numeracion num1, Numeracion num2)
        {
            return new Numeracion(num1.valorNumerico - num2.valorNumerico, num1.Sistema);
        }

        public static Numeracion operator *(Numeracion num1, Numeracion num2)
        {
            return new Numeracion(num1.valorNumerico * num2.valorNumerico, num1.Sistema);
        }

        public static Numeracion operator /(Numeracion num1, Numeracion num2)
        {
            return new Numeracion(num1.valorNumerico / num2.valorNumerico, num1.Sistema);
        }
    }
}
