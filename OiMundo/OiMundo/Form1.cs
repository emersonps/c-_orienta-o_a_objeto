using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.00;
            double valorDoSaque = 10.00;
            saldo -= valorDoSaque;

            MessageBox.Show("O valor do saldo é:"+saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = 1;
            long valorGrande = valor1;

            MessageBox.Show("Resultado: "+valorGrande);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor1 = 1;
            short valorPequeno = (short)valor1; //casting - convertendo valor para caber na variável de outro tipo

            MessageBox.Show("Resultado: " + valorPequeno);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensagem = "Olá";
            string nome = "Emerson";
            MessageBox.Show(mensagem+" "+nome+"!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ano = 2021;
            int nascimento = 1982;
            int idade = ano - nascimento;

            MessageBox.Show("Você é de "+nascimento+" Sua idade é: "+idade);
        }
        
        //Exercícios
        private void button6_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadePedro = 30;
            float mediaIdade = (idadeJoao + idadeMaria + idadePedro) / 3;

            MessageBox.Show(
                "A idade de João é: " + idadeJoao + 
                "A idade de Maria é: "+idadeMaria + 
                "A idade de Pedro é: "+idadePedro + 
                "A média de Idade é: "+mediaIdade    
            );
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQUbrado: "+piQuebrado);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;
            int c = 8;

            double delta = b*b-4*a*c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b + Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("Resultado A1: "+(int)a1+" - "+"Resultado A2: "+(int)a2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double saldo = 0;
            double valorSaque = 10.0;

            if(saldo >= valorSaque)
            {
                saldo = saldo - valorSaque;
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double saldo = 5000.0;
            double valorSaque = 100.0;
            double taxa;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                
                if (saldo < 1000)
                {
                    taxa = 0.01;
                    saldo = saldo + taxa;
                }
                else if (saldo <= 5000)
                {
                    taxa = 0.05;
                    saldo = saldo + taxa;
                }
                else
                {
                    taxa = 0.10;
                    saldo = saldo + taxa;
                }

                MessageBox.Show("Saque realizado com sucesso! Saldo: " + saldo + " Foi adicionado uma taxa de: " + taxa);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente! Saldo: "+saldo);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int idade = 17;
            bool brasileira = true;

            if(idade > 16)
            {
                MessageBox.Show("Apto a votar!");
            }
            else
            {
                MessageBox.Show("Votação apenas para maiores de 16 anos!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 3001;

            if(valorDaNotaFiscal <= 999)
            {
                double imposto = (valorDaNotaFiscal*2)/100;
                valorDaNotaFiscal = valorDaNotaFiscal+imposto;
                MessageBox.Show("Valor da NF: "+valorDaNotaFiscal+ " Valor do Imposto: " + imposto+"%");
            }
            else if (valorDaNotaFiscal > 1000 && valorDaNotaFiscal < 2999)
            {
                double imposto = (valorDaNotaFiscal * 2.5) / 100;
                valorDaNotaFiscal = valorDaNotaFiscal + imposto;
                MessageBox.Show("Valor da NF: " + valorDaNotaFiscal + " Valor do Imposto: " + imposto + "%");
            }
            else if (valorDaNotaFiscal > 3000 && valorDaNotaFiscal < 6999)
            {
                double imposto = (valorDaNotaFiscal * 2.8) / 100;
                valorDaNotaFiscal = valorDaNotaFiscal + imposto;
                MessageBox.Show("Valor da NF: " + valorDaNotaFiscal + " Valor do Imposto: " + imposto + "%");
            }
            else if (valorDaNotaFiscal >= 7000)
            {
                double imposto = (valorDaNotaFiscal * 3) / 100;
                valorDaNotaFiscal = valorDaNotaFiscal + imposto;
                MessageBox.Show("Valor da NF: " + valorDaNotaFiscal + " Valor do Imposto: " + imposto + "%");
            }
            else
            {
                MessageBox.Show("Valor não tributado: "+valorDaNotaFiscal);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = "";

            //condição ? true : false;
            mensagem = valor > 10 ? "o valor é maior que 10" : "o valor é menor que";
            
            MessageBox.Show(mensagem);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000;

            for(int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido é: "+valorInvestido);
        }
    }
}
