using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCombustivel
{
    public static class Funcoes
    {
        public static bool ValidaEntradaInt(string entrada, out int retorno)
        {
            if (!int.TryParse(entrada, out retorno))
            {
                ExibirErro();
                return false;
            }

            if (retorno < 0)
                return false;

            return true;
        }

        public static bool ValidaEntradaDouble(string entrada, out double retorno)
        {
            if (!double.TryParse(entrada, out retorno))
            {
                ExibirErro();
                return false;
            }

            if (retorno < 0)
                return false;

            return true;
        }

        public static void ExibirErro()
        {
            Console.WriteLine("Opção não é Valida!");
            Task.Delay(1500).Wait();
        }
    }
}
