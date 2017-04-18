using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        Pilha operadores;
        string posfixa = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        public void TransformarEmPosfixa()
        {
            string prefixa = edVisor.Text;
            operadores = new Pilha();
            for(int i=0; i < prefixa.Length; i++)
            {
                if (prefixa[i] != '(' && prefixa[i] != ')' && prefixa[i] != '+' &&
                    prefixa[i] != '-' && prefixa[i] != '*' && prefixa[i] != '/' &&
                    prefixa[i] != '↑')
                    posfixa += prefixa[i];
                else
                {
                    bool ehParenteses = false;
                    while(!ehParenteses && !operadores.EstaVazia() && haPrecedencia "faz ai")
                }

            }
        }
    }
}

