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
        //Pilha com operadores da expressão
        PilhaListaHerdada<char> operadores;
        //Vetor com os valores da expressão
        double[] valores;
        //String pósfixa, que é a ultima string e servirá de base para calcular o resultado da expressão
        string posfixa = "";
        //String infixa, que é a prefixa com letras no lugar dos valores
        string infixa = "";
        //String prefixa, que é a expressão como ela veio
        string prefixa = "";
        //Tabela de valores booleanos que indica qual operador deve ter prioridade sobre qual
        static bool[][] tabelaPrecedencia = new bool[][]
            {//                (      ^      *      /      +     -       )
                new bool[] { false, false, false, false, false, false, true },// (
                new bool[] { false, true,  true,  true,  true,  true,  true },// ^
                new bool[] { false, false, true,  true,  true,  true,  true },// *
                new bool[] { false, false, true,  true,  true,  true,  true },// /
                new bool[] { false, false, false, false, true,  true,  true },// +
                new bool[] { false, false, false, false, true,  true,  true },// -
                new bool[] { false, false, false, false, false, false, false},// )
            };
        public Calculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Transforma a string infixa em pósfixa
        /// </summary>
        public void TransformarEmPosfixa()
        {
            posfixa = "";
            char maiorPrecedencia = ' '; //indica o operador com a maior precedência(que deve ser priorizado)
            operadores = new PilhaListaHerdada<char>(); //instancia a pilha que contém os operadores da expressão
            for (int i = 0; i < infixa.Length; i++)
            {
                if (infixa[i] != '(' && infixa[i] != ')' && !EhOperador(infixa[i]))
                    //Significa que infixa[i] é um valor, portanto é só adicioná-lo
                    posfixa += infixa[i];
                else
                {
                    bool ehParenteses = infixa[i] == '('; //Variável booleana que indica se é parenteses(e o que vem depois deve ser priorizado)
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

        /// <summary>
        /// Este método verifica a precedência entre dois operadores
        /// </summary>
        /// <param name="v1">Um operador</param>
        /// <param name="v2">Outro operador</param>
        /// <returns>Retorna true se v1 tiver prioridade sobre v2 na expressão, false caso contrário</returns>
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

        /// <summary>
        /// Calcula o resultado da operação entre dois números
        /// </summary>
        /// <param name="sim">O operador que indicará qual operação deve ser feita(potência, adição, subtração, etc.)</param>
        /// <param name="A">Um valor</param>
        /// <param name="B">Outro valor</param>
        /// <returns>Retorna o resultado da operação</returns>
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

        /// <summary>
        /// Esta função transformará a string prefixa(que contém a expressão) em Infixa(A*B+C, por exemplo), ou seja, trocará números por letras
        /// </summary>
        public void TransformarEmInfixa()
        {
            infixa = "";
            valores= new double[25]; //Vetor contendo os valores da prefixa é instanciado
            int qtosValores=0;       //Quantos valores existem no vetor
            string valor="";         //O valor atual que será inserido no vetor(uma string que representa um double)
            bool ehUltimo = false;   //Variável booleana para saber se o índice acessado é o último(para evitar acesso em posição inválida)

            for (int i = 0; i < prefixa.Length; i++)
            {
                if (i == prefixa.Length - 1)
                    ehUltimo = true;

                if (prefixa[i] == '(' || prefixa[i] == ')' || EhOperador(prefixa[i]))
                    infixa += prefixa[i]; //Como prefixa[i] é um operador(ou parênteses) deve ser apenas incluido na infixa
                else
                {
                    valor += prefixa[i];  //Adicionara prefixa[i] ao valor atual(ex: se valor for 4 e prefixa[i] for 5, valor será 45)

                    if (ehUltimo) //Se estiver na última posição, não tentará  acessar uma posição a mais(prefixa[i+1])
                                  // e com certeza a última posição não é um operador(senão a expressão não faria sentido e estaria errada)
                    {
                        try
                        {
                            valores[qtosValores] = Convert.ToDouble(valor); //Converte o valor atual de string para double e o adiciona no vetor
                        }
                        catch (FormatException erro)
                        {
                            MessageBox.Show(erro.Message); //Caso haja alguma letra ou caracter inválido na expressão
                        }                        
                        valor = "";
                        infixa += (char)(qtosValores + (int)'A'); //Adiciona uma letra na infixa que representa o número
                     //Esta letra dependerá de quantos valores existem no vetor, ou seja, se houver 1 valor a letra será A,se houver 2 será B,etc
                        qtosValores++;
                    }
                    else 
                    if (prefixa[i+1] == '(' || prefixa[i+1] == ')' || EhOperador(prefixa[i+1]))
                    {   //Se o proximo caracter for um operador ou parênteses, significa que acabou o número e pode ser feita a conversão
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

        /// <summary>
        /// Função para descobrir se um caracter é operador na equação ou não
        /// </summary>
        /// <param name="A">Caracter</param>
        /// <returns>Retorna true se o caracter for +, -, *, / ou ^, false caso contrario</returns>
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