namespace Entidades
{
    public class Operacion
    {
        /// <summary></summary>
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        // Getters y Setters
        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }

            set
            {
                segundoOperando = value;
            }
        }

        /// <summary>
        ///  Realizara una operacion matematica segun el operador recibido. Por defecto, realizara una suma.
        /// </summary>
        /// <param name="operador">Un caracter (+, -, *, /) que determinara la operacion a realizar</param>
        /// <returns>Una numeracion con el resultado de la operacion</returns>
        public Numeracion Operar(char operador)
        {
            switch (operador)
            {
                case '-':
                    return primerOperando - segundoOperando;

                case '*':
                    return primerOperando * segundoOperando;

                case '/':
                    if (Validar(segundoOperando))
                    {
                        return primerOperando / segundoOperando;
                    }
                    return new Numeracion(double.MinValue, Numeracion.ESistema.Decimal);

                default:
                    return primerOperando + segundoOperando;
            }
        }

        /// <summary>
        /// Valida que el divisor sea distinto de 0.
        /// </summary>
        /// <param name="divisor">La numeracion a validar</param>
        /// <returns>True en caso de que sea distinto de 0, False en caso de que sea 0</returns>
        private static bool Validar(Numeracion divisor)
        {
            return divisor.Valor != new Numeracion(0, Numeracion.ESistema.Decimal).Valor;
        }
    }
}