using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Pessoa
    {
        string Nome;
        Pessoa? Proximo;

        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.Proximo = null;
        }
        public void SetNext(Pessoa aux)
        {
            this.Proximo = aux;
        }
        public Pessoa? GetNext()
        {
            return this.Proximo;
        }
        public string GetName()
        {
            return this.Nome;
        }
        public override string ToString()
        {
            return this.Nome;
        }
    }

}
