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
            InitStyles();
        }

        //? Comienza el cierre del Form, se puede cancelar
        private void FrmCalculadora_FormClosing(object sender, EventArgs e)
        {
            // TODO
        }

        private void setResultado()
        {
            this.resultado = calculadora.Operar(cmbOperacion.Text[0]);
            lblResultadoNumerico.Text = this.resultado.ConvertirA(sistema);
        }

        private void InitStyles()
        {
            Text = "Calculadora de Emanuel";
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            calculadora = new(primerOperando, segundoOperando);
        }

        //* Si contesta SI se cerrará, si contesta NO debe continuar en ejecución.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "¿Desea cerrar la calculadora?",
                "Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Close(); // Cierra el formulario
            }
        }

        //*  Borra los datos de los TextBox, Label de resultado de la pantalla y también asignará null al atributo resultado del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultadoNumerico.Text = String.Empty;
            resultado = null;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                sistema = Numeracion.ESistema.Decimal;
                setResultado();
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                sistema = Numeracion.ESistema.Binario;
            }
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            primerOperando = new(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            segundoOperando = new(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
        }
    }
}
