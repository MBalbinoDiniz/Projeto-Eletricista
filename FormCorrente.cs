using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEletricista
{
    public partial class FormCorrente : Form
    {
        public FormCorrente()
        {
            InitializeComponent();
        }


        private async void BtnCalcularFormCorrente_Click(object sender, EventArgs e)
        {
            try
            {
                // Ler os valores dos TextBoxes
                double resistencia = double.Parse(TxtResistenciaFormCorrente.Text);
                double tensao = double.Parse(TxtTensaoFormCorrente.Text);

                // Verificar se os valores são válidos
                if (resistencia == 0)
                {
                    MessageBox.Show("A resistência não pode ser zero.");
                    return;
                }
                if (tensao == 0)
                {
                    MessageBox.Show("A tensão não pode ser zero.");
                    return;
                }

                // Criar uma instância da classe Eletricidade e calcular a corrente
                Calculos eletricidade = new Calculos();
                double corrente = eletricidade.CalcularCorrente(resistencia, tensao);

                // Salvar o cálculo no banco de dados
                await Task.Run(() =>
                {
                    BancoDeDados banco = new BancoDeDados();
                    banco.InserirCalculoCorrente(tensao, resistencia, corrente);
                });

                // Criar uma nova instância do FormResultado e passar o resultado e a unidade
                FormResultado formResultado = new FormResultado(corrente, "A"); // unidade de corrente
                formResultado.Show(); // Exibe a tela de resultados
                this.Hide(); // Oculta a tela atual
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }

        }

        private void BtnVoltarFormHistorico_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário de cálcular corrente
        }

        private void BtnSairFormCalculoCorrente_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }
    }
}
