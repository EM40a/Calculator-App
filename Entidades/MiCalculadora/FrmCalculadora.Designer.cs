﻿namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            grpSistema = new GroupBox();
            cmbOperacion = new ComboBox();
            lblResultado = new Label();
            txtPrimerOperador = new RichTextBox();
            txtSegundoOperador = new RichTextBox();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            labelSegundoOperador = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(62, 545);
            btnOperar.Margin = new Padding(0);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(288, 75);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(367, 545);
            btnLimpiar.Margin = new Padding(0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(288, 75);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(674, 545);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(288, 75);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(39, 40);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 24);
            rdbDecimal.TabIndex = 8;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(166, 40);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 24);
            rdbBinario.TabIndex = 9;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.ForeColor = Color.White;
            grpSistema.Location = new Point(372, 278);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(280, 85);
            grpSistema.TabIndex = 7;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.Cursor = Cursors.Hand;
            cmbOperacion.DropDownHeight = 265;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.IntegralHeight = false;
            cmbOperacion.ItemHeight = 45;
            cmbOperacion.Items.AddRange(new object[] { "" });
            cmbOperacion.Location = new Point(412, 473);
            cmbOperacion.Margin = new Padding(16, 3, 16, 3);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(200, 53);
            cmbOperacion.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoEllipsis = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.FromArgb(125, 226, 209);
            lblResultado.Location = new Point(62, 148);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(900, 67);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(62, 473);
            txtPrimerOperador.Margin = new Padding(0);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(334, 53);
            txtPrimerOperador.TabIndex = 1;
            txtPrimerOperador.Text = "";
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(628, 473);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(334, 53);
            txtSegundoOperador.TabIndex = 3;
            txtSegundoOperador.Text = "";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.ForeColor = Color.FromArgb(215, 215, 215);
            lblPrimerOperador.Location = new Point(62, 442);
            lblPrimerOperador.Margin = new Padding(0);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(164, 28);
            lblPrimerOperador.TabIndex = 10;
            lblPrimerOperador.Text = "Primer operando:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.ForeColor = Color.FromArgb(215, 215, 215);
            lblOperacion.Location = new Point(412, 442);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(97, 28);
            lblOperacion.TabIndex = 11;
            lblOperacion.Text = "Operador";
            // 
            // labelSegundoOperador
            // 
            labelSegundoOperador.AutoSize = true;
            labelSegundoOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSegundoOperador.ForeColor = Color.FromArgb(215, 215, 215);
            labelSegundoOperador.Location = new Point(628, 442);
            labelSegundoOperador.Name = "labelSegundoOperador";
            labelSegundoOperador.Size = new Size(186, 28);
            labelSegundoOperador.TabIndex = 12;
            labelSegundoOperador.Text = "Segundo operando:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 40, 52);
            ClientSize = new Size(1006, 721);
            Controls.Add(labelSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private GroupBox grpSistema;
        private ComboBox cmbOperacion;
        private Label lblResultado;
        private RichTextBox txtPrimerOperador;
        private RichTextBox txtSegundoOperador;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label labelSegundoOperador;
    }
}