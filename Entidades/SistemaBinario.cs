using Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico 
        {
            get
            {                
                return (double)this.CambiarSistemaDeNumeracion(ESistemas.Decimal);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistemas sistema)
        {
            if (sistema == ESistemas.Binario)
                return this;
            return this.BinarioADecimal();
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor);//==> Como hacer para inicializarlo y que sea un decimal? 
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            bool retorno = true;
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }
        private SistemaDecimal BinarioADecimal()
        {

            if(Valor != msgError)
            {
                double decimalResult = 0;
                double binaryBase = 1;

                for (int i = valor.Length - 1; i >= 0; i--)
                {
                    if (valor[i] == '1')
                    {
                        decimalResult += binaryBase;
                    }

                    binaryBase *= 2;
                }                
                return new SistemaDecimal(decimalResult.ToString());
            }
            else
            {
                return new SistemaDecimal(double.MinValue.ToString());
            }
        }
        public static implicit operator SistemaBinario(string valor)
        {
            if(!string.IsNullOrEmpty(valor))
            {
                return new SistemaBinario(valor);
            }
            return new SistemaBinario("");
        }
        public override string ToString()
        {
            return "Binario";
        }
    }
}
