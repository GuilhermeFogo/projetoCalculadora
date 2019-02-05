using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.ErrosExceptions
{
    class TrataCaracterException : Exception
    {
        public TrataCaracterException()
        {
        }

        public TrataCaracterException(string mensagem)
            :base(mensagem)
        {

        }

        public TrataCaracterException(string mensagem, Exception exception)
            :this("Erro de caracter")
        {

        }
    }
}
