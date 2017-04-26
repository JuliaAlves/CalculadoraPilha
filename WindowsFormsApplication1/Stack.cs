using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    interface Stack<Dado> where Dado : IComparable<Dado>
    {
        int Tamanho();
        bool EstaVazia();
        void Empilhar(Dado elemento);
        Dado Desempilhar();
        Dado OTopo();

    }
}
