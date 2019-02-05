using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.ErrosExceptions
{
    class InputException : Exception
    {
        public InputException()
        {
                
        }


        public InputException(String mensagem, Exception exception)
            : base(mensagem, exception)
        {

        }



        public InputException(string menssagem) 
            : base(menssagem)
        {

        }
    }
}
