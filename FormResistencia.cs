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
    public partial class FormResistencia : Form
    {
        public FormResistencia()
        {
            InitializeComponent();
        }


        private async void BtnCalcularFormResistecia_Click(object sender, EventArgs e)
        {
            try
            {
                // Ler os valores dos TextBoxes
                double tensao = double.Parse(TxtTensaoFormResistencia.Text);
                double corrente = double.Parse(TxtCorrenteFormResistencia.Text);

                // Verificar se os valores são válidos
                if (tensao == 0)
                {
                    MessageBox.Show("A tensão não pode ser zero.");
                    return;
                }
                if (corrente == 0)
                {
                    MessageBox.Show("A corrente não pode ser zero.");
                    return;
                }

                // Criar uma instância da classe Eletricidade e calcular a resistência
                Calculos eletricidade = new Calculos();
                double resistencia = eletricidade.CalcularResistencia(tensao, corrente);

                // Salvar o cálculo no banco de dados
                await Task.Run(() =>
                {
                    BancoDeDados banco = new BancoDeDados();
                    banco.InserirCalculoResistencia(tensao, corrente, resistencia);
                });

                // Criar uma nova instância do FormResultado e passar o resultado e a unidade
                FormResultado formResultado = new FormResultado(resistencia, "Ω"); // unidade de resistência
                formResultado.Show(); // Exibe a tela de resultados
                this.Hide(); // Oculta a tela atual
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

        private void BtnSairFormCalculoResistencia_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }

        private void BtnVoltarFormCalculoResistencia_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário de cálcular de resistÊncia
        }
    }
}
