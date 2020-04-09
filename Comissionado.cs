using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa
{
    class Comissionado: Empregado
    {
        private double Comissao; 

        public double GetComissao()
        {
            return this.Comissao;
        }

        public void SetComissao(double Comissao)
        {
            this.Comissao = Comissao;
        }

        public double GetSalario()
        {
            return salario + this.Comissao;
        }
    }
}
