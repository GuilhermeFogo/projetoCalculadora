namespace projetoCalculadora.Modal
{
    public class Multiplicar : Operacao
    {

        /*
         *  Esta clase possui 2 metodos de Mutiplicação que são feitos de maneiras diferentes.
         *  importante:
         *   o numero1 ou num1 deve ser usado por exemplo: 
         *    Menos(2, numero que deseje multiplicar)
          */

        int cont =0;
        int resp = 0;
        public override int Execute(int numero1, int numero2)
        {
                   
            while (cont < numero2)
            {
                resp = resp + numero1;
                cont++;
            }

            return resp;
        }



        public int mutiplicaEspecial(int num1, int num2)
        {
            //if (num1 == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    if (num2 == 0)
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        if (num1 == num2)
            //        {
            //            return 1;
            //        }
            //    }
            //}

            if (cont < num2)
            {

                resp = resp + num1;
                cont++;
                mutiplicaEspecial(num1, num2);

            }

            return resp;
        }
    }
}
