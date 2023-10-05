using Entidades;
using System.Text;
namespace TrabajoIngegrador
{
    public partial class FrmCalculadora : Form
    {
        private StringBuilder sbResult = new StringBuilder();
        //private Numeracion primerOperando;
        //private Numeracion segundoOperando;
        //private Numeracion resultado;
        private ESistemas isSys;

        //private Operacion calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(this.txbPrimerOperando.Text, out double result1) && double.TryParse(this.txbSegundoOperando.Text, out double result2)))
            {
                MessageBox.Show("Debe ingresar un numero en los 2 casilleros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Datos validados.
                //this.primerOperando = new Numeracion(result1, ESistemas.Decimal);
                //this.segundoOperando = new Numeracion(result2, ESistemas.Decimal);
                //this.calculadora = new Operacion(primerOperando, segundoOperando);

                if (!char.TryParse(this.cbOperadores.Text, out char operador))
                {
                    MessageBox.Show("Debe ingresar un operador para hacer la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //this.resultado = this.calculadora.Operar(operador);
                    SetResultado();
                    lsbHistorial.Items.Add(this.txbPrimerOperando.Text + operador + this.txbSegundoOperando.Text);
                }

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
            this.rbDecimal.TabIndex = 0;
            this.rbBinario.TabIndex = 1;
            this.txbPrimerOperando.TabIndex = 2;
            this.cbOperadores.TabIndex = 3;
            this.txbSegundoOperando.TabIndex = 4;
            this.btnOperar.TabIndex = 5;
            this.btnLimpiar.TabIndex = 6;
            this.btnCerrar.TabIndex = 7;

            //Parametros por defecto
            this.txbPrimerOperando.PlaceholderText = "1,2,3..";
            this.txbSegundoOperando.PlaceholderText = "1,2,3..";
            this.rbDecimal.Checked = true;
            this.cbOperadores.DataSource = new object[] { "", '+', '-', '/', '*' };
            this.sbResult.Append("Resultado:");
            this.lblResultado.Text = sbResult.ToString();

        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro de que quiere cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!(respuesta == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }


        private void comboBoxOperadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro de que quieres limpiar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //Restablecer parametros por defecto
                this.txbPrimerOperando.Clear();
                this.txbSegundoOperando.Clear();
                this.sbResult.Clear();
                this.lsbHistorial.Items.Clear();
                //this.resultado = null;
                FormView_Load(sender, e);
            }
        }
        private void SetResultado()
        {
            string resultConvertido;
            //if (this.resultado is not null)
            //{
            resultConvertido = isSys.ToString();
            this.sbResult.Append($" {resultConvertido}");
            this.lblResultado.Text = sbResult.ToString();
            //int sizenum = resultConvertido.Length;
            //this.sbResult.Remove(9, sizenum);
            //}
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecimal.Checked)
            {
                this.isSys = ESistemas.Decimal;
                SetResultado();
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBinario.Checked)
            {
                this.isSys = ESistemas.Binario;
                SetResultado();
            }
        }
    }
}