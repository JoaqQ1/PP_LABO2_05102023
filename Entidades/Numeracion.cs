using Enum;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor = string.Empty;

        public string Valor 
        {
            get 
            {
                if (!EsNumeracionValida(this.valor))
                {
                    return msgError;
                }
                else
                {
                    return this.valor;
                }

            }
        }
        internal abstract double ValorNumerico { get; }
        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.InicializarValores(valor);
        }
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistemas sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return valor is not null && valor.Length >0;
        }
        private void InicializarValores(string value)
        {
            if (EsNumeracionValida(value))
            {
                this.valor = value;
            }
            else
            {
                this.valor = msgError;
            }
        }
        public static bool operator == (Numeracion a, Numeracion b)
        {
            return a is not null && b is not null && a.ToString() == b.ToString();
        }
        public static bool operator !=(Numeracion a, Numeracion b)
        { 
            return !(a == b);
        }
        public override bool Equals(object? obj)
        {
            return obj is not null && this == ((Numeracion)obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static explicit operator double(Numeracion numero)
        {
            return numero.ValorNumerico;
        }
    }
}