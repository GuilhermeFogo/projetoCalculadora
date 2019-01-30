using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.Modal
{
    public class Fatorial
    {
        private Multiplicar multiplicar;

        public int Fatorando(int numero1)
        {
            multiplicar = new Multiplicar();

            int numero = 1;
            for (int i = 1; i <= numero1; i++)
            {
                //numero = multiplicar.Mais(numero,i);
                numero *= i;
            }

            return numero;

        }
    }
}
