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
            /*
            valorAnterior = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
            */
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
            /*
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "+";
                primeiraOperacao = false;
            }
            else

            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior + ValorVisor);
            }*/
        }
    }    
}   


