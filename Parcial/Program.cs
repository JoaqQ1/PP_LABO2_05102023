using Entidades;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaDecimal num = new SistemaDecimal("10");
            Numeracion numBin = num.CambiarSistemaDeNumeracion(Enum.ESistemas.Binario);

            Console.WriteLine(num.Valor);
            Console.WriteLine(numBin.Valor);
        }
    }
}