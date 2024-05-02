using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class FilaPessoa
    {
        Pessoa? Head;
        Pessoa? Tail;

        public FilaPessoa()
        {
            this.Head = null;
            this.Tail = null;
        }
        public void Push(Pessoa aux)
        {
            if (IsEmpty())
                this.Head = this.Tail = aux;
            else
            {
                this.Tail.SetNext(aux);
                this.Tail = aux;
            }
            Console.WriteLine(Tail.ToString() + " entrou da fila!");
        }
        public void Pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(Head.ToString() + " saiu da fila!");
                if (Tail == Head)
                    this.Head = this.Tail = null;
                else
                    this.Head = Head.GetNext();
            }
            else
                EmptyMessage();
        }
        public void RunOver()
        {
            if (!IsEmpty())
            {
                Pessoa aux = Head;
                while (aux != Tail.GetNext())
                {
                    Console.WriteLine(aux.ToString() + " está na fila!");
                    aux = aux.GetNext();
                }
            }
            else
                EmptyMessage();
        }
        bool IsEmpty()
        {
            return Head == null && Tail == null;
        }
        public void EmptyMessage()
        {
            Console.WriteLine("Fila vazia!");
        }
    }
}
