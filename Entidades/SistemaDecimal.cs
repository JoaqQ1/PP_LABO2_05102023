using Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico 
        {
            get
            {
                
                return double.Parse(Valor);
                
            }  
                
        }


        public override Numeracion CambiarSistemaDeNumeracion(ESistemas sistema)
        {
            if (sistema == ESistemas.Decimal)
            {
                return this;
            }
            else
            {
                return this.DecimalABinario();
            }
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor,out double valorNum);
        }
        private SistemaBinario DecimalABinario()
        {
            string binary = "";
            if (double.TryParse(valor, out double valorNum) && valorNum > 0)
            {
                int valorEntero = (int)valorNum;
                
                while (valorEntero > 0)
                {
                    double remainder = valorEntero % 2;
                    binary = remainder + binary;
                    valorEntero /= 2;
                }                
            }

            return new SistemaBinario(binary);
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            if (double.TryParse(valor, out double valorNum))
            {
                return new SistemaDecimal(valor);
            }
            return new SistemaDecimal("");

        }
        public static implicit operator SistemaDecimal(double valor)
        {
            return valor.ToString();
        }
        public override string ToString()
        {
            return "Decimal";
        }
    }
}
