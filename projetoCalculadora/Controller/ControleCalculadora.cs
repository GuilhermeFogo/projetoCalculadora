using projetoCalculadora.Domen;
using projetoCalculadora.ErrosExceptions;
using projetoCalculadora.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.Controller
{
    class ControleCalculadora
    {
        public string campo, campo2, caminho;

        public void Nome()
        {
            Console.WriteLine("Digite seu nome :");
            campo = Console.ReadLine();
            Console.WriteLine("Seja Bem vindo(a) ao Programa Calculadora " + campo + "\n");
        }


        public void Principal()
        {
            
            try
            {
                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("Escolha uma opção:");
                    Console.WriteLine(" + -> somar \n - -> Subtrair \n * -> Multiplicar \n / -> Dividir \n " +
                        "F -> Fatorial \n TXT -> para ler um arquivo externo \n 0 -> Sair");

                    campo = Console.ReadLine();

                    switch (campo.ToUpper())
                    {
                        case "+":
                            Campos();
                            Somando somar = new Somando();
                            int soma = somar.Execute(int.Parse(campo), int.Parse(campo2));
                            Console.WriteLine("Resultado: " + soma);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "-":
                            Campos();
                            Subtraindo subtraindo = new Subtraindo();
                            int sub = subtraindo.Execute(int.Parse(campo), int.Parse(campo2));
                            Console.WriteLine("Resultado: " + sub);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "*":
                            Campos();
                            Multiplicar multiplicar = new Multiplicar();
                            int multi = multiplicar.mutiplicaEspecial(int.Parse(campo), int.Parse(campo2));
                            Console.WriteLine("Resultado: " + multi);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "/":
                            Campos();
                            try
                            {
                                Dividir dividir = new Dividir();
                                int div = dividir.Execute(int.Parse(campo2), int.Parse(campo));
                                Console.WriteLine("Resultado: " + div);
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                                throw;
                                //Console.WriteLine("Impossivel realizar esta operção");
                            }

                            break;

                        case "F":
                            CampoFatorial();
                            Fatorial fatorial = new Fatorial();
                            int fato = fatorial.Fatorando(int.Parse(campo));
                            Console.WriteLine("Resultado: " + fato);
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "0":
                            Environment.Exit(0);
                            break;

                        case "TXT":
                            Caminho();
                            ControlleTxt controle = new ControlleTxt();
                            controle.MostarArquivosTxt(caminho);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Tente novamente. Escolha uma das opçoes adequadas");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }


                }
            }
            catch (TrataCaracterException e)
            {
                Console.WriteLine(e.Message);
              

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Principal();
            }
            
        }




        public  void Campos()
        {
                Console.WriteLine("Digite um numero");
                campo = Console.ReadLine();
                Console.WriteLine("Digite outro numero");
                campo2 = Console.ReadLine();

            int numero;
            int numero2;
            if (int.TryParse(campo,out numero) && int.TryParse(campo2, out numero2))
            {
                return;
            }
            else
            {
                throw new TrataCaracterException("Digite um numero, seu Imbecil");
            }
                
            
        }

        public  void CampoFatorial()
        {
            Console.WriteLine("Digite um numero");
            campo = Console.ReadLine();
        }

        public void Caminho()
        {
            Console.WriteLine("Digite o caminho do arquivo:");
            caminho = Console.ReadLine();
        }

    }
}
