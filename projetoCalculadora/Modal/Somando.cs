using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.Modal
{

    /*
     * Esta classe tem um metodo que  soma 2 valores
     
      */
    public class Somando : Operacao
    {
        public override int Execute(int numero1, int numero2)
        {
            int num = numero1 + numero2;
            return num; 
        }
    }
}
