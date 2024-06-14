using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_INSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cargo;
            double salario, inss;

            Console.WriteLine("Infomre seu cargo:");
            cargo = Console.ReadLine();

            Console.WriteLine("Informe seu salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 3000) inss = salario * 10 / 100; 
            else inss = salario * 14 / 100;

            Console.Clear();

            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salario: " + salario); 
            Console.WriteLine("Valor INSS: " + inss);
            Console.WriteLine("Salario liquido:  " +(salario - inss));

            Console.ReadKey();
        }
    }
}
