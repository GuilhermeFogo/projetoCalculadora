using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora.DTO
{
    public class LeituraTxt
    {

        public List<string> lista;
        public FileStream file;
        public StreamReader reader;

        public List<string> LendoArqFormatado(string caminho)
        {
            
            try
            {
                FileInfo fileInfo = new FileInfo(caminho);
                this.file = new FileStream(caminho, FileMode.Open);
                this. reader = new StreamReader(file);
                this.lista = new List<string>();

                if (fileInfo.Exists)
                {
                    while (!reader.EndOfStream)
                    {
                        string movie = reader.ReadLine();

                        lista.Add(movie);

                    }
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("Arquivo não existe");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }

            return lista;
        }



        public List<string> LerArquivoZip(string caminhoArq)
        {
            this.lista = new List<string>();

            this.file = new FileStream(caminhoArq, FileMode.Open);
            this.reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                string movie = reader.ReadLine();


                this.lista = movie.Split(',').ToList();
            }
            reader.Close();
            
            return lista;
        }
    }
}
