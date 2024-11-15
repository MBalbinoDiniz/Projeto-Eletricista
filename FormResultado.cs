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
    public partial class FormResultado : Form
    {
        public FormResultado(double resultado, string unidade)
        {
            InitializeComponent();
            LblResultado.Text = "Resultado: " + resultado.ToString("F2") + " " + unidade;
        }

        private void BtnVoltarFormResultado_Click(object sender, EventArgs e)
        {
            // Fecha a tela de resultado
            this.Close();

        }

        private void BtnSairFormResultado_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha a aplicação
        }
    }
}
