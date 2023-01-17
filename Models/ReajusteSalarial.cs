using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ReajusteSalarial
    {

        static void Main(string[] args)
        {

            double salario = 0.00;
            double reajuste = 0.00;
            double novoSalario = 0.00;
            double percentual = 0.00;

            salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 0)
            {
                return;

            }
            else if (salario <= 400)
            {
                percentual = 15;
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;


            }
            else if (salario >= 400.01 && salario <= 800)
            {
                percentual = 12;
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;

            }
            else if (salario >= 800.01 && salario <= 1200)
            {
                percentual = 10;
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;

            }
            else if (salario >= 1200.01 && salario <= 2000)
            {
                percentual = 7;
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;

            }
            else
            {
                percentual = 4;
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;

            }

            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);

        }
    }
}
