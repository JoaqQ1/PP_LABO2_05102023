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
                return double.Parse(Valor);
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
            return base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor);
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
                return new SistemaDecimal(Valor);
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
