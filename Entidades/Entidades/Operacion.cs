namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        // Getters y Setters
        public Numeracion PrimerOperando
        {
            get => primerOperando;
            set => primerOperando = value;
        }
        public Numeracion SegundoOperando
        {
            get => segundoOperando;
            set => segundoOperando = value;
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
                    return primerOperando / segundoOperando;

                default:
                    return primerOperando + segundoOperando;
            }
        }
    }
}