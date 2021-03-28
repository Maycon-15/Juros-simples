using System;

namespace Juros_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Capital, Juros, Tempo, Juros_simples, Result, Result2, Result3, Result4, Result5, Montante;
            //Capital (c), Juros (i), Tempo (t), Juros simples (j)

            Console.WriteLine("Vamos calcular o montante final de um juros simples (j), por favor digite as informações pedidas abaixo:");
            Console.WriteLine();

            Console.WriteLine("Coloque o numero que sera utilizado no capital (c)");
            Capital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Coloque o numero à ser utilizado na taxa de juros (i), em porcentagem (%):");
            Juros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Coloque o numero que será utilizado no tempo (t), em meses: ");
            Tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Formula de juros simples: j= c.i.t");

            Console.WriteLine();

            Result = Capital;
            Result2 = Juros /100;
            Result3 = Tempo;

            Console.WriteLine($"j= {Result} . {Result2} . {Result3}");

            Result4 = Result * Result2;
            Result5 = Result4 * Result3;

            Console.WriteLine($"j= {Result5}");

            Juros_simples = Result5;

            Console.WriteLine();

            Console.WriteLine("Agora vamos calcular o montante (m):");

            Console.WriteLine();

            Console.WriteLine("Formula: m= c + j");

            Montante = Result + Result5;

            Console.WriteLine();

            Console.WriteLine($"m= {Montante}");


        }
    }
}
