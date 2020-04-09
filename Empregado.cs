using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa
{
    class Empregado
    {
        private string nome;
        protected double salario;

        public string Getnome()
        {
            return this.nome;
        }
        public void SetNome(string Nome)
        {
            this.nome = Nome;
        }

        public virtual double Getsalario()
        {
            return salario;
        }
        public void SetSalario(double Salario)
        {
            this.salario = Salario;

        }
    }
}
