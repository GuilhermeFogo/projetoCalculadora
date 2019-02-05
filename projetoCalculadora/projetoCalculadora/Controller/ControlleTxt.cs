
namespace projetoCalculadora.Domen
{
    using projetoCalculadora.DTO;
    using projetoCalculadora.Modal;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class ControlleTxt
    {
        public List<string> lista;
        private Dividir dividir;
        private Multiplicar multiplicar;
        private OperacaoExterna opercao;
        private Somando somando;
        private Subtraindo subtraindo;
        private LeituraTxt leitura;

        public ControlleTxt()
        {
            this.lista = new List<string>();
            dividir = new Dividir();
            multiplicar = new Multiplicar();
            somando = new Somando();
            subtraindo = new Subtraindo();
            leitura = new LeituraTxt();
            opercao = new OperacaoExterna();
            Operacao operacao = new Somando();

        }

        public void MostarArquivosTxt(String caminho)
        {
            try
            {
                Console.WriteLine("Seu Arquivo txt está Formatado?");
                string resp = Console.ReadLine();
                if (resp.Equals("Sim") || resp.Equals("s") || resp.Equals("S") || resp.Equals("sim"))
                {
                    this.lista = leitura.LendoArqFormatado(caminho);
                }
                else
                {
                    this.lista = leitura.LerArquivoZip(caminho);
                }

                foreach (string valor in lista)
                {
                    int cont = 0;
                    opercao.numero1 = valor[cont].ToString();
                    cont++;
                    opercao.operador = valor[cont];
                    cont++;
                    opercao.numero2 = valor[cont].ToString();
                    cont++;

                    switch (opercao.operador)
                    {
                        case '+':
                            Console.WriteLine(somando.Execute(int.Parse(opercao.numero1), int.Parse(opercao.numero2)));
                            break;

                        case '-':
                            Console.WriteLine(subtraindo.Execute(int.Parse(opercao.numero1), int.Parse(opercao.numero2)));
                            break;

                        case '*':
                            Console.WriteLine(multiplicar.Execute(int.Parse(opercao.numero1), int.Parse(opercao.numero2)));
                            break;

                        case '/':
                            Console.WriteLine(dividir.Execute(int.Parse(opercao.numero1), int.Parse(opercao.numero2)));
                            break;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}

