using System;
using dio_dotnet_poo.src.Entities;

namespace dio_dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23,"Knight");
            Wizard jennica = new Wizard("Jennica", 23, "Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(jennica.Attack(7));
        }
    }
}
