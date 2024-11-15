using ProjetoEletricista;
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
    public partial class FormTensao : Form
    {

        public FormTensao()
        {
            InitializeComponent();
        }

        private async void BtnCalcularFormTensao_Click(object sender, EventArgs e)
        {
            try
            {
                // Ler os valores dos TextBoxes
                double corrente = double.Parse(TxtCorrenteFormTensao.Text);
                double resistencia = double.Parse(TxtResistenciaFormTensao.Text);



                // Verificar se os valores são válidos
                if (corrente == 0)
                {
                    MessageBox.Show("A corrente não pode ser zero.");
                    return;
                }
                if (resistencia == 0)
                {
                    MessageBox.Show("A resistência não pode ser zero.");
                    return;
                }

                // Criar uma instância da classe Eletricidade e calcular a tensão
                Calculos eletricidade = new Calculos();
                double tensao = eletricidade.CalcularTensao(corrente, resistencia);

                // Salvar o cálculo no banco de dados 
                await Task.Run(() =>
                {
                    BancoDeDados banco = new BancoDeDados();
                    banco.InserirCalculoTensao(corrente, resistencia, tensao);
                });

                // Criar uma nova instância do FormResultado e passar o resultado
                FormResultado formResultado = new FormResultado(tensao, "V");
                formResultado.Show(); // Exibe a tela de resultados
                this.Hide(); // Oculta a tela atual
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

        private void BtnSairFormCalculoTensao_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }

        private void BtnVoltarFormCalculoTensao_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário de cálcular tensão
        }
    }
}




