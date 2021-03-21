using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            string stringNome;
            decimal decimalJ;
            decimal decimalC;
            decimal decimalI;
            decimal decimalT;
            decimal decimalM;
            decimalI = 2;
            Console.WriteLine(" ■ ■ Poupança a juros simples ■ ■");
        
            Console.Write("\n Digite seu nome: ");
            stringNome = Convert.ToString(Console.ReadLine());
            Console.Write(" Seja bem vindo, " + stringNome + " digite o capital a ser investido: ");
            decimalC = Convert.ToDecimal(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(" Lembrando " + stringNome + " que a taxa de juros esta 2% ao mês");
            Console.ResetColor();
            Console.Write(" Ola " + stringNome + " por quanto tempo quer deixar esta aplicação? ");
            decimalT = Convert.ToDecimal(Console.ReadLine());

            decimalJ = (decimalI/100 * decimalC ) * decimalT;
            decimalM = decimalC + decimalJ;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" \n Capital aplicado: {decimalC:C}\n Taxa de juros de {decimalI}%\n Tempo de meses {decimalT}\n \n Juros {decimalJ:C}\n Montante {decimalM:C}");
            Console.ResetColor();
        }
    }
}
