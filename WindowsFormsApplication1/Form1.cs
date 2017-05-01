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
        PilhaListaHerdada<char> operadores;
        double[] valores;
        string posfixa = "";
        string infixa = "";
        string prefixa = "";
        static bool[][] tabelaPrecedencia = new bool[][]
            {
                new bool[] { false, false, false, false, false, false, true },
                new bool[] { false, true,  true,  true,  true,  true,  true },
                new bool[] { false, false, true,  true,  true,  true,  true },
                new bool[] { false, false, true,  true,  true,  true,  true },
                new bool[] { false, false, false, false, true,  true,  true },
                new bool[] { false, false, false, false, true,  true,  true },
                new bool[] { false, false, false, false, false, false, false},
            };
        public Calculadora()
        {
            InitializeComponent();
        }

        public void TransformarEmPosfixa()
        {
            posfixa = "";
            char maiorPrecedencia = ' ';
            operadores = new PilhaListaHerdada<char>();
            for (int i = 0; i < infixa.Length; i++)
            {
                if (infixa[i] != '(' && infixa[i] != ')' && !EhOperador(infixa[i]))
                    posfixa += infixa[i];
                else
                {
                    bool ehParenteses = infixa[i] == '(';
                    while (!ehParenteses && !operadores.EstaVazia() && haPrecedencia(operadores.OTopo(), infixa[i]))
                    {
                        maiorPrecedencia = operadores.Desempilhar();
                        if (maiorPrecedencia != '(')
                            posfixa += maiorPrecedencia;
                        else
                            ehParenteses = true;

                    }
                    if (infixa[i] != ')')
                        operadores.Empilhar(infixa[i]);
                    else
                        if(!operadores.EstaVazia())
                            posfixa += operadores.Desempilhar();
                }

            }
            while (!operadores.EstaVazia())
            {
                maiorPrecedencia = operadores.Desempilhar();
                if (maiorPrecedencia != '(')
                    posfixa += maiorPrecedencia;
            }
        }

        private bool haPrecedencia(char v1, char v2)
        {
            int primeiro=0;
            int segundo = 0;

            switch (v1)
            {
                case '^': primeiro = 1;
                    break;
                case '*': primeiro = 2;
                    break;
                case '/': primeiro = 3;
                    break;
                case '+': primeiro = 4;
                    break;
                case '-': primeiro = 5;
                    break;
                case ')': primeiro = 6;
                    break;
            }

            switch (v2)
            {
                case '^': segundo = 1;
                    break;
                case '*': segundo = 2;
                    break;
                case '/': segundo = 3;
                    break;
                case '+': segundo = 4;
                    break;
                case '-': segundo = 5;
                    break;
                case ')': segundo = 6;
                    break;
            }

            return tabelaPrecedencia[primeiro][segundo];
        }

        public double CalcularResultado() 
        {
            PilhaListaHerdada<double> pilha = new PilhaListaHerdada<double>();            
            for(int i=0; i<posfixa.Length;i++)
            {
                if (!EhOperador(posfixa[i]))
                    pilha.Empilhar(valores[posfixa[i]-'A']);
                else
                {
                    double operando1 = pilha.Desempilhar();
                    double operando2 = pilha.Desempilhar();
                    pilha.Empilhar(CalcularExpressao(posfixa[i], operando2, operando1));
                }
            }

            return pilha.Desempilhar();
        }

        public double CalcularExpressao(char sim, double A, double B)
        {
            switch (sim)
            {
                case '+': return A + B;
                case '-': return A - B;
                case '/': return A / B;
                case '*': return A * B;
                case '^': return Math.Pow(A,B);
                default : return 0;
            }
                
        }

        public void TransformarEmInfixa()
        {
            infixa = "";
            valores= new double[25];
            int qtosValores=0;
            string valor="";
            bool ehUltimo = false;
            for (int i = 0; i < prefixa.Length; i++)
            {
                if (i == prefixa.Length - 1)
                    ehUltimo = true;

                if (prefixa[i] == '(' || prefixa[i] == ')' || EhOperador(prefixa[i]))
                    infixa += prefixa[i];
                else
                {
                    valor += prefixa[i];

                    if (ehUltimo)
                    {
                        try
                        {
                            valores[qtosValores] = Convert.ToDouble(valor);
                        }
                        catch (FormatException erro)
                        {
                            MessageBox.Show(erro.Message);
                        }                        
                        valor = "";
                        infixa += (char)(qtosValores + (int)'A');
                        qtosValores++;
                    }
                    else 
                    if (prefixa[i+1] == '(' || prefixa[i+1] == ')' || EhOperador(prefixa[i+1]))
                    {
                        try
                        {
                            valores[qtosValores] = Convert.ToDouble(valor);
                        }
                        catch (FormatException erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                        
                        valor = "";
                        infixa += (char)(qtosValores + (int)'A');
                        qtosValores++;
                    }
                }
            }
        }

        public bool EhOperador(char A)
        {
            if (A != '+' && A != '-' && A != '*' &&
                A != '/' && A != '^')
                return false;

            return true;
        }

        private void tratarBotao(object sender, EventArgs e)
        {
            string digitado= ((Button)sender).Text;
            if (digitado == "C")
                edVisor.Clear();
            else if (digitado == "=")
            {
                prefixa = edVisor.Text;

                //Código para tratamento da prefixa
                for(int i=0; i<prefixa.Length; i++)
                {
                    if (EhOperador(prefixa[i]))
                    {
                        if (EhOperador(prefixa[i + 1]))
                        {
                            MessageBox.Show("Deve haver parênteses entre dois operadores(Exemplo: x*(-y)");
                            return;
                        }                            
                    }
                    else
                    {
                        //string auxiliar para guardar a prefixa
                        string outraprefixa = "";

                        if (prefixa[i] == '(')
                            if (prefixa[i + 1] == '-')
                            {
                                //É operador unário
                                //Agora deve-se colocar um 0 antes do '-' para que o próximo número fique negativo

                                for (int j = 0; j <= i; j++)//Colocando toda a prefixa até o '-' na string auxiliar
                                    outraprefixa += prefixa[j];

                                outraprefixa += '0';//Coloca o 0 antes do '-'
                                for(int j = i+1; j<prefixa.Length; j++)//Coloca o resto da prefixa(a partir do '-') na string auxiliar
                                    outraprefixa += prefixa[j];

                                prefixa = outraprefixa;
                            }
                    }
                    
                }                

               TransformarEmInfixa();
                lbInfixa.Text = infixa;
                TransformarEmPosfixa();
                lbPosfixa.Text = posfixa;
                edResultado.Text=Convert.ToString(CalcularResultado());
            }
            else
                edVisor.Text += digitado;
        }

        private void edVisor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                prefixa = edVisor.Text;

                //Código para tratamento da prefixa
                for (int i = 0; i < prefixa.Length; i++)
                {
                    if (EhOperador(prefixa[i]))
                    {
                        if (EhOperador(prefixa[i + 1]))
                        {
                            MessageBox.Show("Deve haver parênteses entre dois operadores(Exemplo: x*(-y)");
                            return;
                        }
                    }
                    else
                    {
                        //string auxiliar para guardar a prefixa
                        string outraprefixa = "";

                        if (prefixa[i] == '(')
                            if (prefixa[i + 1] == '-')
                            {
                                //É operador unário
                                //Agora deve-se colocar um 0 antes do '-' para que o próximo número fique negativo

                                for (int j = 0; j <= i; j++)//Colocando toda a prefixa até o '-' na string auxiliar
                                    outraprefixa += prefixa[j];

                                outraprefixa += '0';//Coloca o 0 antes do '-'
                                for (int j = i + 1; j < prefixa.Length; j++)//Coloca o resto da prefixa(a partir do '-') na string auxiliar
                                    outraprefixa += prefixa[j];

                                prefixa = outraprefixa;
                            }
                    }
                }
            

           TransformarEmInfixa();
                lbInfixa.Text = infixa;
                TransformarEmPosfixa();
                lbPosfixa.Text = posfixa;
                edResultado.Text = Convert.ToString(CalcularResultado());
            }            
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string ret = "";
            for (int i = 0; i < edVisor.Text.Length - 1; i++)
                ret += edVisor.Text[i];
            edVisor.Text = ret;
        }
    }
}