using System;
using System.Globalization;

namespace EntradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dig = ("Digite ");
            string idade = ("a idade: ");
            string sex = ("o sexo: ");
            string alt = ("a Altura: ");
            Console.WriteLine(dig + idade);
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(dig + sex);
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(dig + alt);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.WriteLine(idade + n1);
            Console.WriteLine(sex + ch);
            Console.WriteLine(alt + n2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}