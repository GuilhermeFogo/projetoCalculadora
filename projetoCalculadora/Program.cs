using projetoCalculadora.Controller;
using projetoCalculadora.Domen;
using projetoCalculadora.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora
{
     public class Program
    {
         public static void Main(string[] args)
        {
            ControleCalculadora cal = new ControleCalculadora();
            cal.Principal();
        }

     }
}
