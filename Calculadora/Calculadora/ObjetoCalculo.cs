using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    //classe ObjetoCalculo herdando a classe abstrata AbstractCalculo
    public class ObjetoCalculo : AbstractCalculo
    {
        //Propriedades referentes ao cálculo a ser realizado, herdada da classe abstrata AbstractCalculo
        public override double valorVisor { get; set }
        public override double valorAnterior { get; set }
        public override double valorResultado { get; set }

        public override string operacao { get; set }

        //método para realizar a operaçção de cálculo, herdado da classe abstrata AbstractCalculo
        public override double Calculo()
        {
            switch (operacao)
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
                    /*
                    double valorRaiz = valorVisor;

                    for (int i = 0; i < 10; i++)
                    {
                        valorRaiz = (valorRaiz / 2) + valorVisor / 2(2 * valorRaiz);
                    }

                    valorResultado = valorRaiz;
                    */

                    valorResultado = Math.Sqrt(valorVisor);
                    break;

                default:
                    break;

                default:
                    break;
            }                
        }
    }
    
}
