using Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno = String.Empty;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistemas sistema;

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        public Numeracion Resultado { get => resultado; }
        public List<string> Operaciones { get => operaciones; }
        public static ESistemas Sistema { get => sistema; set => sistema = value; }

        static Calculadora()
        {
            Sistema = ESistemas.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }
        public Calculadora(string nombreAlumno) : this()
        {
            NombreAlumno = nombreAlumno;
        }
        public void Calcular()
        {
            double result = double.MinValue;
            if (PrimerOperando == SegundoOperando)
                result = PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico;
            
            this.resultado = MapeaResultado(result);

        }
        public void Calcular(char operador)
        {
            double result = double.MinValue;
            if (PrimerOperando == SegundoOperando)
            {
                switch (operador)
                {
                    case '+':
                        result = PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico;

                        break;
                    case '-':
                        result = PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico;
                        break;
                    case '*':
                        result = PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico;
                        break;
                    case '/':
                        if(SegundoOperando.ValorNumerico != 0)
                            result = PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico;
                        break;
                }
            }
            this.resultado = MapeaResultado(result);
        }
        private Numeracion MapeaResultado(double valor)
        {
            return new SistemaDecimal(valor.ToString()).CambiarSistemaDeNumeracion(Sistema);
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistemas {Sistema.ToString()}");
            sb.Append($"{PrimerOperando.ValorNumerico}{operador}{SegundoOperando.ValorNumerico}={Resultado.ValorNumerico}");
            Operaciones.Add(sb.ToString());
        }
        public void EliminarHistorialDeOperaciones()
        {
            Operaciones.Clear();
        }
    }
}
