namespace TrabajoIngegrador
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
            btnCerrar = new Button();
            btnLimpiar = new Button();
            txtPrimerOperando = new TextBox();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            txtSegundoOperando = new TextBox();
            lblOperar = new Label();
            lblResultado = new Label();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            grpSistema = new GroupBox();
            cmbOperacion = new ComboBox();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnOperar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(12, 464);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(238, 43);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnCerrar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(528, 464);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(219, 43);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(256, 464);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(266, 43);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(12, 417);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.PlaceholderText = "1,2,3...";
            txtPrimerOperando.Size = new Size(238, 43);
            txtPrimerOperando.TabIndex = 5;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.FlatStyle = FlatStyle.Popup;
            lblPrimerOperando.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(38, 376);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(176, 31);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer operador:";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.FlatStyle = FlatStyle.Popup;
            lblSegundoOperando.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(545, 376);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(199, 31);
            lblSegundoOperando.TabIndex = 8;
            lblSegundoOperando.Text = "Segundo operador:";
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(528, 417);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.PlaceholderText = "1,2,3...";
            txtSegundoOperando.Size = new Size(216, 43);
            txtSegundoOperando.TabIndex = 7;
            txtSegundoOperando.TextChanged += textBox2_TextChanged;
            // 
            // lblOperar
            // 
            lblOperar.AutoSize = true;
            lblOperar.FlatStyle = FlatStyle.Popup;
            lblOperar.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperar.Location = new Point(321, 376);
            lblOperar.Name = "lblOperar";
            lblOperar.Size = new Size(120, 31);
            lblOperar.TabIndex = 9;
            lblOperar.Text = "Operacion:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.FlatStyle = FlatStyle.Popup;
            lblResultado.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = SystemColors.ActiveCaptionText;
            lblResultado.Location = new Point(38, 63);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(175, 46);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(156, 42);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(74, 25);
            rdbBinario.TabIndex = 11;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(6, 42);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(81, 25);
            rdbDecimal.TabIndex = 12;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(256, 261);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(245, 88);
            grpSistema.TabIndex = 13;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.BackColor = SystemColors.InactiveBorder;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI Light", 19F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.ForeColor = Color.Red;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(292, 417);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(194, 43);
            cmbOperacion.TabIndex = 14;
            cmbOperacion.SelectedIndexChanged += comboBoxOperadores_SelectedIndexChanged;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(785, 143);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(260, 364);
            lstHistorial.TabIndex = 15;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.FlatStyle = FlatStyle.Popup;
            lblHistorial.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(785, 92);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(99, 31);
            lblHistorial.TabIndex = 16;
            lblHistorial.Text = "Historial:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 519);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            Controls.Add(lblOperar);
            Controls.Add(lblSegundoOperando);
            Controls.Add(txtSegundoOperando);
            Controls.Add(lblPrimerOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Joaquin Quiroga";
            FormClosing += FormView_FormClosing;
            Load += FormView_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnCerrar;
        private Button btnLimpiar;
        private TextBox txtPrimerOperando;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private TextBox txtSegundoOperando;
        private Label lblOperar;
        private Label lblResultado;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private GroupBox grpSistema;
        private ComboBox cmbOperacion;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}