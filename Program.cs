using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Comissionado objC = new Comissionado();
            Horista objH = new Horista();

            int tipoEmpregado;

           
            Console.WriteLine("Tipos de empregados: \n(1)Comissionado \n(2)Horista.");
            Console.Write("Digite o tipo (1 ou 2): ");

            int.TryParse(Console.ReadLine(), out tipoEmpregado);

            if (tipoEmpregado == 1) // Comissionado depende da entrada de novo dado.
            {

                Console.WriteLine("Forneça os dados abaixo: ");
                Console.Write("\nNome do funcionário: ");
                objC.SetNome(Console.ReadLine());
                Console.Write("\nSalario do funcionário: ");
                objC.SetSalario(double.Parse(Console.ReadLine()));

                Console.Write("Digite o Valor da Comissão : ");
                objC.SetComissao(double.Parse(Console.ReadLine()));

                Console.WriteLine("\nValor a ser pago: R$ " + objC.GetSalario());
            }
            else if (tipoEmpregado == 2) // Horista também depende de novos dados de entrada.
            {
                Console.WriteLine("Forneça os dados abaixo: ");
                Console.Write("\nNome do funcionário: ");
                objH.SetNome(Console.ReadLine());
                Console.Write("\nSalario do funcionário: ");
                objH.SetSalario(double.Parse(Console.ReadLine()));



                Console.Write("Digite o preço da hora trabalhada: R$ ");
                objH.PrecoHora = double.Parse(Console.ReadLine());
                Console.Write("Número de horas trabalhadas: ");
                objH.HorasTrabalhadas = double.Parse(Console.ReadLine());

                Console.WriteLine("Valor a ser pago: R$" + objH.GetSalario());
            }
            else
            {
                Console.WriteLine("Tipo de empregado não existe. ");
            }

            Console.ReadKey();
        }
    }
}
