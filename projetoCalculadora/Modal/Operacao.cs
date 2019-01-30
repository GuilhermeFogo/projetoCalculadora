using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.Modal
{
    public abstract class Operacao
    {
        public abstract int Execute(int numero1, int numero2);
    }
}
