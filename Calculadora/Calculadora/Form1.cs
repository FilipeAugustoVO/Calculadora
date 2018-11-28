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

        private void btn_Click(object snder, EventArgs e)
        {

        }

        Button botaoAcionado = (Button)sender; //O objeto botão que foi clicado será carregado no botaoAcionado.

        switch

        private void btnNum7_Click(object sender, EventArgs e)
        {

        }

        private void btnNum8_Click(object sender, EventArgs e)
        {

        }

        private void btnNum9_Click(object sender, EventArgs e)
        {

        }

        private void btnNum4_Click(object sender, EventArgs e)
        {

        }

        private void btnNum5_Click(object sender, EventArgs e)
        {

        }

        private void btnNum6_Click(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {

        }

        private void btnNum3_Click(object sender, EventArgs e)
        {

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Clear(); //apaga o que está no Visor da Calculadora
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            //botão backspace apaga um caractere por vez usando o metodo remove da classe string
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void btnMulticacao_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
