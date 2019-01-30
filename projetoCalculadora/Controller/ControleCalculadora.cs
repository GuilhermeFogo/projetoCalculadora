using projetoCalculadora.Domen;
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


        public void Principal()
        {
            Console.WriteLine("Digite seu nome :");
            campo = Console.ReadLine();
            bool continuar = true;
            Console.WriteLine("Seja Bem vindo(a) ao Programa Calculadora " + campo + "\n");
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
                        break;

                    case "-":
                        Campos();
                        Subtraindo subtraindo = new Subtraindo();
                        int sub = subtraindo.Execute(int.Parse(campo), int.Parse(campo2));
                        Console.WriteLine("Resultado: " + sub);
                        break;

                    case "*":
                        Campos();
                        Multiplicar multiplicar = new Multiplicar();
                        int multi = multiplicar.mutiplicaEspecial(int.Parse(campo), int.Parse(campo2));
                        Console.WriteLine("Resultado: " + multi);
                        break;

                    case "/":
                        Campos();
                        Dividir dividir = new Dividir();
                        int div = dividir.Execute(int.Parse(campo2), int.Parse(campo));
                        Console.WriteLine("Resultado: " + div);
                        break;

                    case "F":
                        CampoFatorial();
                        Fatorial fatorial = new Fatorial();
                        int fato = fatorial.Fatorando(int.Parse(campo));
                        Console.WriteLine("Resultado: " + fato);
                        break;
                        
                    case "0":
                        continuar = false;
                        Console.WriteLine("Saindo...");
                        break;

                    case "TXT":
                        Caminho();
                        ControlleTxt controle = new ControlleTxt();
                        controle.MostarArquivosTxt(caminho);
                        break;
                    default:
                        Console.WriteLine("Tente novamente. Escolha uma das opçoes adequadas");
                        break;
                }

            }
        }
        
        public  void Campos()
        {
            Console.WriteLine("Digite um numero");
            campo = Console.ReadLine();
            Console.WriteLine("Digite outro numero");
            campo2 = Console.ReadLine();
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
