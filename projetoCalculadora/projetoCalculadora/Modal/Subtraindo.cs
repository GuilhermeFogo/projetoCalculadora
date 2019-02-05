using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.Modal
{
    class Subtraindo : Operacao
    {
        // esta classe tem 1 metodo que subtrai 2 valores

        public override int Execute(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
