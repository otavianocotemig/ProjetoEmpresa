using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa
{
    class Horista: Empregado
    {

        private double precoHora, horasTrabalhadas;

        public double PrecoHora { get => precoHora; set => precoHora = value; }
        public double HorasTrabalhadas { get => horasTrabalhadas; set => horasTrabalhadas = value; }

        public double GetSalario()
        {
            return salario+ (precoHora * horasTrabalhadas);
        }
    }
}
