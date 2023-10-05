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
            txbPrimerOperando = new TextBox();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            txbSegundoOperando = new TextBox();
            lblOperar = new Label();
            lblResultado = new Label();
            rbBinario = new RadioButton();
            rbDecimal = new RadioButton();
            gbSistemas = new GroupBox();
            cbOperadores = new ComboBox();
            lsbHistorial = new ListBox();
            lblHistorial = new Label();
            gbSistemas.SuspendLayout();
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
            // txbPrimerOperando
            // 
            txbPrimerOperando.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbPrimerOperando.Location = new Point(12, 417);
            txbPrimerOperando.Name = "txbPrimerOperando";
            txbPrimerOperando.PlaceholderText = "1,2,3...";
            txbPrimerOperando.Size = new Size(238, 43);
            txbPrimerOperando.TabIndex = 5;
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
            // txbSegundoOperando
            // 
            txbSegundoOperando.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txbSegundoOperando.Location = new Point(528, 417);
            txbSegundoOperando.Name = "txbSegundoOperando";
            txbSegundoOperando.PlaceholderText = "1,2,3...";
            txbSegundoOperando.Size = new Size(216, 43);
            txbSegundoOperando.TabIndex = 7;
            txbSegundoOperando.TextChanged += textBox2_TextChanged;
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
            lblResultado.Size = new Size(0, 46);
            lblResultado.TabIndex = 10;
            // 
            // rbBinario
            // 
            rbBinario.AutoSize = true;
            rbBinario.Location = new Point(156, 42);
            rbBinario.Name = "rbBinario";
            rbBinario.Size = new Size(74, 25);
            rbBinario.TabIndex = 11;
            rbBinario.TabStop = true;
            rbBinario.Text = "Binario";
            rbBinario.UseVisualStyleBackColor = true;
            rbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rbDecimal
            // 
            rbDecimal.AutoSize = true;
            rbDecimal.Location = new Point(6, 42);
            rbDecimal.Name = "rbDecimal";
            rbDecimal.Size = new Size(81, 25);
            rbDecimal.TabIndex = 12;
            rbDecimal.TabStop = true;
            rbDecimal.Text = "Decimal";
            rbDecimal.UseVisualStyleBackColor = true;
            rbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // gbSistemas
            // 
            gbSistemas.Controls.Add(rbBinario);
            gbSistemas.Controls.Add(rbDecimal);
            gbSistemas.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbSistemas.Location = new Point(256, 261);
            gbSistemas.Name = "gbSistemas";
            gbSistemas.Size = new Size(245, 88);
            gbSistemas.TabIndex = 13;
            gbSistemas.TabStop = false;
            gbSistemas.Text = "Representar resultado en:";
            // 
            // cbOperadores
            // 
            cbOperadores.BackColor = SystemColors.InactiveBorder;
            cbOperadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperadores.Font = new Font("Segoe UI Light", 19F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperadores.ForeColor = Color.Red;
            cbOperadores.FormattingEnabled = true;
            cbOperadores.Location = new Point(292, 417);
            cbOperadores.Name = "cbOperadores";
            cbOperadores.Size = new Size(194, 43);
            cbOperadores.TabIndex = 14;
            cbOperadores.SelectedIndexChanged += comboBoxOperadores_SelectedIndexChanged;
            // 
            // lsbHistorial
            // 
            lsbHistorial.FormattingEnabled = true;
            lsbHistorial.ItemHeight = 15;
            lsbHistorial.Location = new Point(785, 143);
            lsbHistorial.Name = "lsbHistorial";
            lsbHistorial.Size = new Size(260, 364);
            lsbHistorial.TabIndex = 15;
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
            Controls.Add(lsbHistorial);
            Controls.Add(cbOperadores);
            Controls.Add(gbSistemas);
            Controls.Add(lblResultado);
            Controls.Add(lblOperar);
            Controls.Add(lblSegundoOperando);
            Controls.Add(txbSegundoOperando);
            Controls.Add(lblPrimerOperando);
            Controls.Add(txbPrimerOperando);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Joaquin Quiroga";
            FormClosing += FormView_FormClosing;
            Load += FormView_Load;
            gbSistemas.ResumeLayout(false);
            gbSistemas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnCerrar;
        private Button btnLimpiar;
        private TextBox txbPrimerOperando;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private TextBox txbSegundoOperando;
        private Label lblOperar;
        private Label lblResultado;
        private RadioButton rbBinario;
        private RadioButton rbDecimal;
        private GroupBox gbSistemas;
        private ComboBox cbOperadores;
        private ListBox lsbHistorial;
        private Label lblHistorial;
    }
}