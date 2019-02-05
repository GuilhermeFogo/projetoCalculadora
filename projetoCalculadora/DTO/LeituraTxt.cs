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
        public FileInfo fileInfo;

        public List<string> LendoArqFormatado(string caminho)
        {

            this.fileInfo = new FileInfo(caminho);
            this.file = new FileStream(caminho, FileMode.Open);
            this.reader = new StreamReader(file);
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
                throw new FileNotFoundException("Seu arquivo não existe");
            }

            return lista;
        }



        public List<string> LerArquivoZip(string caminhoArq)
        {

            this.fileInfo = new FileInfo(caminhoArq);
            this.lista = new List<string>();

            this.file = new FileStream(caminhoArq, FileMode.Open);
            this.reader = new StreamReader(file);

            if (this.fileInfo.Exists)
            {
                while (!reader.EndOfStream)
                {
                    string movie = reader.ReadLine();


                    this.lista = movie.Split(',').ToList();
                }
                reader.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }

            return lista;
        }
    }
}
