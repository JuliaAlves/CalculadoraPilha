using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class PilhaListaHerdada<Dado> : ListaSimples<Dado>,
                                    Stack<Dado>
          where Dado : IComparable<Dado>
    {
        public Dado Desempilhar()
        {
            return RemoverPrimeiro();
        }

        public void Empilhar(Dado elemento)
        {
            InserirAntesDoInicio(elemento);
        }

        public Dado OTopo()
        {
            if ( EstaVazia() )
               throw new Exception("Pilha vazia ao consultar topo!");

            return Primeiro.Info;
        }

        public int Tamanho()
        {
            return QuantosNos;
        }

        new public bool EstaVazia()
        {
            return base.EstaVazia;
        }
    }
}
