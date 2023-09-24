using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion.ESistema sistema;
        private Numeracion? primerOperando;
        private Numeracion? segundoOperando;
        private Numeracion? resultado;
        private Operacion? calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        //? El formulario se encuentra en memoria pero invisible
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora de Emanuel";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.cmbOperacion.SelectedIndex = 0;
        }

        //? Comienza el cierre del Form, se puede cancelar
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "¿Desea cerrar la calculadora?", "Cierre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            // ?Si contesta SI se cerrará, si contesta NO debe continuar en ejecución.
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //? Mostrara el resultado de la operación, convertido de acuerdo con el sistema numérico seleccionado
        private void SetResultado()
        {
            if (this.resultado is not null)
            {
                lblResultadoNumerico.Text = this.resultado.ConvertirA(sistema);
            }
        }

        //* Cambia el sistema segun el RadioButton seleccionado
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                this.sistema = Numeracion.ESistema.Decimal;
                this.SetResultado();
            }
        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                this.sistema = Numeracion.ESistema.Binario;
                this.SetResultado();
            }
        }

        //* Instancia los operadores con los valores de los TextBox
        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            primerOperando = new(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
        }
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            segundoOperando = new(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
        }

        /// <summary>
        /// Realiza la operacion y muestra el resultado en el Label de resultado de la pantalla
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            bool operadoresNulos = primerOperando is null || segundoOperando is null;
            bool operadoresVacios = txtPrimerOperador.Text == "" || txtSegundoOperador.Text == "";

            if (operadoresNulos || operadoresVacios)
            {
                MessageBox.Show("Debe ingresar los dos operandos para realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.calculadora = new Operacion(primerOperando, segundoOperando);
            this.resultado = calculadora.Operar(cmbOperacion.Text[0]);
            SetResultado();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Borra los datos de los TextBox, Label de resultado de la pantalla y también asignará null al atributo resultado del formulario
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultadoNumerico.Text = null;
            this.resultado = null;
        }
    }
}
