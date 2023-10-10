using Entidades;
using Enum;
using System.Text;
namespace TrabajoIngegrador
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Joaquin Quiroga");
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperador(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado:{this.calculadora.Resultado?.Valor}";
            this.MostrarHistorial();

        }
        private Numeracion GetOperador(string valor)
         {
            SistemaDecimal aux = valor;
            if (Calculadora.Sistema == ESistemas.Binario)
            {
                Numeracion auxiBin = aux.CambiarSistemaDeNumeracion(ESistemas.Binario);
                return new SistemaBinario(auxiBin.Valor);
            }
            else
            {
                return new SistemaDecimal(valor);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void FormView_Load(object sender, EventArgs e)
        {
            //Ordenar al altabear
            this.rdbDecimal.TabIndex = 0;
            this.rdbBinario.TabIndex = 1;
            this.txtPrimerOperando.TabIndex = 2;
            this.cmbOperacion.TabIndex = 3;
            this.txtSegundoOperando.TabIndex = 4;
            this.btnOperar.TabIndex = 5;
            this.btnLimpiar.TabIndex = 6;
            this.btnCerrar.TabIndex = 7;
            this.lstHistorial.TabIndex = 8;


            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };

        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora ? ", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void comboBoxOperadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }
        public void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource =
            this.calculadora.Operaciones;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistemas.Decimal;
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistemas.Binario;
        }
    }
}