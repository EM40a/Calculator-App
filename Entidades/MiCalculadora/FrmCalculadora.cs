namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            InitStyles();
        }

        private void InitStyles()
        {
            Text = "Calculadora de Emanuel";
            MaximizeBox = false;
            MinimizeBox = false;
            ComboBox();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el formulario
        }

        private void ComboBox()
        {
            // Agrega los operadores al ComboBox
            cmbOperacion.Items.Add('+');
            cmbOperacion.Items.Add('-');
            cmbOperacion.Items.Add('*');
            cmbOperacion.Items.Add('/');
            cmbOperacion.SelectedIndex = 0; // Selecciona el primer operador
        }
    }
}
