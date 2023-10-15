namespace FrmView
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            btnOperar = new Button();
            btnHistorial = new Button();
            btnLimpiar = new Button();
            lblSegundoOperador = new Label();
            lblOperacion = new Label();
            lblPrimerOperando = new Label();
            cmbOperacion = new ComboBox();
            txtSegundoOperando = new TextBox();
            txtPrimerOperando = new TextBox();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            rdbOctal = new RadioButton();
            lstHistorial = new ListBox();
            lblResultado = new Label();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Location = new Point(31, 356);
            btnOperar.Margin = new Padding(3, 4, 3, 4);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(186, 51);
            btnOperar.TabIndex = 12;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.Location = new Point(225, 356);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(186, 51);
            btnHistorial.TabIndex = 13;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(419, 356);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 51);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.ForeColor = Color.Gray;
            lblSegundoOperador.Location = new Point(419, 282);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(140, 20);
            lblSegundoOperador.TabIndex = 8;
            lblSegundoOperador.Text = "Segundo operando:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.ForeColor = Color.Gray;
            lblOperacion.Location = new Point(225, 284);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(73, 20);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "Operador";
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.ForeColor = Color.Gray;
            lblPrimerOperando.Location = new Point(31, 282);
            lblPrimerOperando.Margin = new Padding(0);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(124, 20);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer operando:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(225, 306);
            cmbOperacion.Margin = new Padding(3, 4, 3, 4);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(186, 44);
            cmbOperacion.TabIndex = 10;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(419, 306);
            txtSegundoOperando.Margin = new Padding(3, 4, 3, 4);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(186, 42);
            txtSegundoOperando.TabIndex = 11;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(31, 306);
            txtPrimerOperando.Margin = new Padding(3, 4, 3, 4);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(186, 42);
            txtPrimerOperando.TabIndex = 9;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbOctal);
            grpSistema.Location = new Point(166, 146);
            grpSistema.Margin = new Padding(3, 4, 3, 4);
            grpSistema.Name = "grpSistema";
            grpSistema.Padding = new Padding(3, 4, 3, 4);
            grpSistema.Size = new Size(287, 88);
            grpSistema.TabIndex = 2;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Cursor = Cursors.Hand;
            rdbBinario.Location = new Point(108, 44);
            rdbBinario.Margin = new Padding(3, 4, 3, 4);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 24);
            rdbBinario.TabIndex = 4;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Cursor = Cursors.Hand;
            rdbDecimal.Location = new Point(17, 44);
            rdbDecimal.Margin = new Padding(3, 4, 3, 4);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 24);
            rdbDecimal.TabIndex = 3;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbOctal
            // 
            rdbOctal.AutoSize = true;
            rdbOctal.Cursor = Cursors.Hand;
            rdbOctal.Enabled = false;
            rdbOctal.Location = new Point(191, 44);
            rdbOctal.Margin = new Padding(3, 4, 3, 4);
            rdbOctal.Name = "rdbOctal";
            rdbOctal.Size = new Size(65, 24);
            rdbOctal.TabIndex = 5;
            rdbOctal.Text = "Octal";
            rdbOctal.UseVisualStyleBackColor = true;
            rdbOctal.CheckedChanged += rdbOctal_CheckedChanged;
            // 
            // lstHistorial
            // 
            lstHistorial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 25;
            lstHistorial.Location = new Point(31, 146);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(574, 204);
            lstHistorial.TabIndex = 16;
            lstHistorial.Visible = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoEllipsis = true;
            lblResultado.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(31, 48);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(574, 67);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "0";
            lblResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.ForeColor = Color.Gray;
            lblHistorial.Location = new Point(27, 115);
            lblHistorial.Margin = new Padding(0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(85, 28);
            lblHistorial.TabIndex = 34;
            lblHistorial.Text = "Historial";
            lblHistorial.Visible = false;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 441);
            Controls.Add(lstHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(grpSistema);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblResultado);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperando);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(btnOperar);
            Controls.Add(btnHistorial);
            Controls.Add(btnLimpiar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora - ";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnHistorial;
        private Button btnLimpiar;
        private Label lblSegundoOperador;
        private Label lblOperacion;
        private Label lblPrimerOperando;
        private ComboBox cmbOperacion;
        private TextBox txtSegundoOperando;
        private TextBox txtPrimerOperando;
        private GroupBox grpSistema;
        private RadioButton rdbOctal;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private ListBox lstHistorial;
        private Label lblResultado;
        private Label lblHistorial;
    }
}