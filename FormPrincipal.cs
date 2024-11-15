using System;
using System.Windows.Forms;

namespace ProjetoEletricista
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnTensao_Click(object sender, EventArgs e)
        {
            FormTensao tensao = new FormTensao();
            tensao.Show();
        }

        private void BtnResistencia_Click(object sender, EventArgs e)
        {
            FormResistencia resistencia = new FormResistencia();
            resistencia.Show();
        }
        private void BtnCorrente_Click(object sender, EventArgs e)
        {
            FormCorrente corrente = new FormCorrente();
            corrente.Show();
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            FormHistorico formHistorico = new FormHistorico();
            formHistorico.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

