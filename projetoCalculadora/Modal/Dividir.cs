using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.Modal
{
    class Dividir : Operacao
    {
        /*
         * Feito por Guilherme fogo:
         *  Esta clase possui 2 metodos de Divisão que são feitos de maneiras diferentes.
         *  importante:
         *   o numero1 ou num1 deve ser usado por exemplo: 
         *    Menos(2, numero que deseje multiplicar)
          */
        int cont = -1;

        public override int Execute(int numero1, int numero2)
        {
            int i;
            for ( i = -1; numero2 >= 0; i++)
            {
                numero2 = numero2 - numero1;
            }
                                  
            return i;
        }



        public int DivideEspecial(int num1 ,int num2)
        {
            if (num2>=0)
            {
                num2 -= num1;
                cont++;
                DivideEspecial(num1,num2);
            }
            return cont;
        }
    }
}
