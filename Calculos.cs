using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEletricista
{
    public class Calculos
    {
        // Método para calcular Tensão: V = I * R
        public double CalcularTensao(double corrente, double resistencia)
        {
            return corrente * resistencia;
        }

        // Método para calcular Corrente: I = V / R
        public double CalcularCorrente(double tensao, double resistencia)
        {
            return tensao / resistencia;
        }

        // Método para calcular Resistência: R = V / I
        public double CalcularResistencia(double tensao, double corrente)
        {
            return tensao / corrente;
        }
    }
}
