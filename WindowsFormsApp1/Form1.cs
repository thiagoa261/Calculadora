using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Aluno Thiago Aio
// Repositório: https://github.com/thiagoa261/Calculadora

namespace WindowsFormsApp1
{
	public partial class Calculadora : Form
	{
		int num1, num2, resultado;
		char operacao;			

		public Calculadora()
		{
			InitializeComponent();

			TelaResultados.Text = "0";

			// Mais prático que criar uma função para cada botão
			this.btnN0.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN1.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN2.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN3.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN4.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN5.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN6.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN7.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN8.Click += new System.EventHandler(this.ClicouNumero);
			this.btnN9.Click += new System.EventHandler(this.ClicouNumero);

			this.btnSoma.Click += new System.EventHandler(this.ClicouOperacao);
			this.btnSubtrae.Click += new System.EventHandler(this.ClicouOperacao);
			this.btnMultiplica.Click += new System.EventHandler(this.ClicouOperacao);
			this.btnDivide.Click += new System.EventHandler(this.ClicouOperacao);
		}

		private void ClicouNumero(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			if (TelaResultados.Text == "0")
			{
				TelaResultados.Text = "";
			}

			TelaResultados.Text += btn.Text;
			TelaHistorico.Text += btn.Text;
		}

		private void ClicouOperacao(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			operacao = btn.Text[0];
			TelaHistorico.Text += btn.Text[0];

			num1 = int.Parse(TelaResultados.Text);
			TelaResultados.Text = "0";
		}

		private void btnIgual_Click(object sender, EventArgs e)
		{
			num2 = int.Parse(TelaResultados.Text);

			if (operacao == '+')
			{
				resultado = num1 + num2;
			}

			else if (operacao == '-')
			{
				resultado = num1 - num2;
			}

			else if (operacao == '*')
			{
				resultado = num1 * num2;
			}

			else if (operacao == '/')
			{
				resultado = num1 / num2;
			}

			else
			{
				// não ocorrer nunca se ocorrer erro no código
				MessageBox.Show("Erro não há operador");
				btnLimpa_Click(sender, e);
			}

			TelaResultados.Text = resultado.ToString();
			TelaHistorico.Text += "=" + resultado.ToString();
		}

		private void btnLimpa_Click(object sender, EventArgs e)
		{
			TelaResultados.Text = "0";
			TelaHistorico.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
