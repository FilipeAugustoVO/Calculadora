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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text == "0") // se o visor estiver com o numero 0, é pra limpa-lo.
            {
                txtVisor.Clear();
            }
            Button botaoAcionado = (Button)sender; //O objeto botão que foi clicado será carregado no BotãoACionado

            switch (botaoAcionado.Name) //Verifica o nome do botão acionado
            {
                case "btn1":                    //Caso seja btn1
                    txtVisor.Text += "1";       //A propriedade Text do visor receberá o número 1
                    break;                      //parar a verificação

                case "btn2":                    //Caso seja btn2
                    txtVisor.Text += "2";       //A propriedade Text do visor receberá o número 2
                    break;                      //parar a verificação

                case "btn3":                    //Caso seja btn3
                    txtVisor.Text += "3";       //A propriedade Text do visor receberá o número 3
                    break;                      //parar a verificação

                case "btn4":                    //Caso seja btn4
                    txtVisor.Text += "4";       //A propriedade Text do visor receberá o número 4
                    break;                      //parar a verificação

                case "btn5":                     //Caso seja btn5
                    txtVisor.Text += "5";       //A propriedade Text do visor receberá o número 5
                    break;                      //parar a verificação

                case "btn6":                 //Caso seja btn6
                    txtVisor.Text += "6";       //A propriedade Text do visor receberá o número 6
                    break;                      //parar a verificação

                case "btn7":                     //Caso seja btn7
                    txtVisor.Text += "7";       //A propriedade Text do visor receberá o número 7
                    break;                      //parar a verificação

                case "btn8":                    //Caso seja btn8
                    txtVisor.Text += "8";       //A propriedade Text do visor receberá o número 8
                    break;                      //parar a verificação

                case "btn9":                    //Caso seja btn9
                    txtVisor.Text += "9";       //A propriedade Text do visor receberá o número 9
                    break;                      //parar a verificação

                case "btn0":                    //Caso seja btn0
                    txtVisor.Text += "0";       //A propriedade Text do visor receberá o número 0
                    break;                      //parar a verificação                

                case "btnVirgula":              //Caso seja btnVirgula
                    if(string.IsNullOrWhiteSpace(txtVisor.Text))
                    txtVisor.Text += "0,";       //A propriedade Text do visor receberá a virgula
                                                //parar a verificação
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;
                 default:
                    break;
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear(); //apaga o que está no Visor da Calculadora    
            txtHistorico.Clear();
            
            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
            
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            //botão backspace apaga um caractere por vez usando o metodo remove da classe string
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {            
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text; // txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = "+"; //determina que a operacao realizada é a adição
                primeiraOperacao = false; //PrimeiraOperacao passa a ser false
            }
            else

            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o numero do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente e o numero do Visor

                //txtVisor.Text = Convert.ToString(valorAnterior + ValorVisor); //realiza as soma dos números e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo)); //realiza a soma dos números e exibe no txtVisor.

                operacao = "+"; //determina que a operacao realizada é adição
                txtHistorico.Text += "=" + txtVisor.Text; //txtHistorico recebe o sinal de = e o ultimo número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor    
                botaoIgual = true; //async variável igual passa a ser true
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //1. Se click no btnIgual, variavel valorVisor receberá o ultimo número exibido no visor.
            valorVisor = Convert.ToDouble(txtVisor.Text);

            //2. Sinal da operação anterior e o conteudo do txtVisor adicionados no txtHistorico
            txtHistorico.Text += óperacao + txtVisor.Text;

            //3. Resultado cálculo realizado antes de clicarnos no botão de igual deve ser exibido no txtVisor.
            //Porém, quando programamos os botões das operações, já definimos qual era a operação realizada (adição, subtração, multiplicação ou divisão)
            txtVisor.Text = Convert.ToString(Calculo());

            //4. Depois, é adicionado txtHistorico o sinal de igual e o resultado do calculo, que será mostrado no visor.
            txtHistorico.Text += "=" + txtVisor.Text;

            //5. Dai, a variável valorAnterior passar a ser o que estiver no txtVisor, que no caso é o resultado do ultimo cálculo realizado
            valorAnterior = Convert.ToDouble(txtVisor.Text);

            //6. Já que o resultado está sendo exibido, a variável botãoIgual fica como true.
            botaoIgual = true;
            //7. Após clicar no botão de igual, podemos clicar em outro numero para iniciar outras operações,
            //pois definimos que variável PrimeiraOperacao passa a ser true.
            primeiroOperacao = true;
        }

        

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if(primeiraOperacao)
            {
                //1. Quando for primeira operaçção, número no visor é armazenado na variável ValorAnterior
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if(botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "x";
                primeiraOperacao = false;                                
            }
            else
            {
                //2. Ao clicamos em algum botão de operação, seguido de outro número, e novamente no botão de operação
                //Esse ultimo número inserido será armazenado na variável valorVisor
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                //3. Resultado do visor será convertido em string
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = "x";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }
        
        /* //depreciado, ver classe ObjetoCalculo
        public double Calculo()
        {
            switch (operacao)//metodo para verificar qual operação deverá ser realizada
            {
                case "+":
                    valorAnterior = valorAnterior + valorVisor;
                    break;

                case "-":
                    valorAnterior = valorAnterior - valorVisor;
                    break;

                case "x":
                    valorAnterior = valorAnterior * valorVisor;
                    break;

                case "/":
                    valorAnterior = valorAnterior / valorVisor;
                    break;

                case "√":

                    /*double valorRaiz = valorVisor;
                    
                    for (int i = 0; i < 10; i++)
                    {
                        valorRaiz = (valorRaiz / 2) + valorVisor / (2 * valorRaiz);
                    }

                    valorResultado = valorRaiz;
                    */

                    valorResultado = Math.Sqrt(valorVisor);
                    break;

                default:
                    break;
            }

            return valorAnterior;
        }
        */

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text; // txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = "-"; //determina que a operacao realizada é a adição
                primeiraOperacao = false; //PrimeiraOperacao passa a ser false
            }
            else

            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o numero do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente e o numero do Visor

                //txtVisor.Text = Convert.ToString(valorAnterior + ValorVisor); //realiza as soma dos números e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo)); //realiza a soma dos números e exibe no txtVisor.

                operacao = "-"; //determina que a operacao realizada é adição
                txtHistorico.Text += "=" + txtVisor.Text; //txtHistorico recebe o sinal de = e o ultimo número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor    
                botaoIgual = true; //async variável igual passa a ser true
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text; // txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = "/"; //determina que a operacao realizada é a adição
                primeiraOperacao = false; //PrimeiraOperacao passa a ser false
            }
            else

            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o numero do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente e o numero do Visor

                //txtVisor.Text = Convert.ToString(valorAnterior + ValorVisor); //realiza as soma dos números e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo)); //realiza a soma dos números e exibe no txtVisor.

                operacao = "/"; //determina que a operacao realizada é adição
                txtHistorico.Text += "=" + txtVisor.Text; //txtHistorico recebe o sinal de = e o ultimo número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor    
                botaoIgual = true; //async variável igual passa a ser true
            }
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            if(PrimeiraOperacao)
            {
                operacao = "√";
            }

            valorVisor = Convert.ToDouble(txtVisor.Text);
            txtHistorico.Text += operacao + txtVisor.Text;

            ObjetoCalculo novoCalculo = new ObjetoCalculo Calculo();

            novoCalculo.ValorVisor = this.ValorVisor;
            novoCalculo.valorAnterior = this.valorAnterior;
            novoCalculo.operacao = this.operacao;

            txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

            operacao = "√";
            txtHistorico.Text += "=" + txtVisor.Text;
            valorAnterior = Convert.ToDouble(txtVisor.Text);

            if(novoCalculo.Operacao != "√")
            {
                txtHistorico.Text += "=" + operacao + txtVisor.Text;

                valorVisor = Convert.ToDouble(txtVisor.Text);

                novoCalculo.operacao  this.operacao;
                novoCalculo.valorVisor = this.valorVisor;

                txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

                txtHistorico.Text += "=" + txtVisor.Text;
            } 
        }
    }    
}   


