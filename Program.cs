using System;
using DIO.src.Entities;

namespace  dotnet_poo
{
    class Programs
    {
        static void Main(string[] args)
        {  
            Knight arus = new Knight("Arus", "Knight", 25, 100, 10);            
            Wizard jennica = new Wizard("Jennica", "White Wizard", 26, 80, 200);
            Ninja wedge = new Ninja("Wedge", "Ninja", 25, 90, 30);
            BlackWizard topapa = new BlackWizard("Topapa", "Black Wizard!", 26, 80, 200);

            
            Console.WriteLine();
            Console.WriteLine(arus);
            Console.WriteLine("Vamos derrotar nosso inimigo! Irei utilizar minha espada!");
            Console.WriteLine();
            Console.WriteLine(jennica);
            Console.WriteLine("Vou usar minhas melhores técnicas e magias para poder derrota-lo, sou uma bruxa muito poderosa");
            Console.WriteLine();
            Console.WriteLine(wedge);
            Console.WriteLine(@"Sou como o silêncio de uma floresta virgem! Atacarei sem piedade e sem que o inimigo perceba!");
            Console.WriteLine();
            Console.WriteLine(topapa);
            Console.WriteLine(@"Venho das profundezas mais obscuras para ajudar-los, sou o maior e melhor Magico Negro!");
            Console.WriteLine();
            Console.WriteLine(topapa.Attack());
            Console.WriteLine();
            Console.WriteLine(jennica.Attack(10));
            Console.WriteLine();
            Console.WriteLine(wedge.Attack());
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine();
            Console.WriteLine(@"Após uma batalha dura e sangrenta o inimigo é derrotado por nossos melhores heróis!");

        }
    }
}

