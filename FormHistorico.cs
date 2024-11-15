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
    public partial class FormHistorico : Form
    {
        public FormHistorico()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            // Limpa o ListBox antes de carregar novos itens
            listBoxHistoricoTensao.Items.Clear();
            listBoxHistoricoResistencia.Items.Clear();
            listBoxHistoricoCorrente.Items.Clear();

            BancoDeDados banco = new BancoDeDados();

            banco.RecuperarHistoricoTensao(resultado =>
            {
                // Adicionar os resultados no ListBox ou outro controle de exibição
                listBoxHistoricoTensao.Items.Add(resultado);
            });

            banco.RecuperarHistoricoResistencia(resultado =>
            {
                // Adicionar os resultados no ListBox ou outro controle de exibição
                listBoxHistoricoResistencia.Items.Add(resultado);
            });

            banco.RecuperarHistoricoCorrente(resultado =>
            {
                // Adicionar os resultados no ListBox ou outro controle de exibição
                listBoxHistoricoCorrente.Items.Add(resultado);
            });
        }

        private void FormHistorico_Load(object sender, EventArgs e)
        {
            CarregarHistorico(); // Chama o método para carregar os dados do banco
        }

        private void BtnSairFormHistorico_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }

        private void BtnVoltarFormHistorico_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário de histórico
        }

        private void BtnLimparFormHistorico_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            banco.LimparHistorico();
            listBoxHistoricoTensao.Items.Clear(); // Limpa o ListBox Tensão
            listBoxHistoricoResistencia.Items.Clear(); // Limpa o ListBox Resistência
            listBoxHistoricoCorrente.Items.Clear(); // Limpa o ListBox Corrente
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxHistoricoTensao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxHistoricoCorrente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
