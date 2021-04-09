using System;

namespace VSApp.ExoIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Bonjour, veuillez indiquer votre prénom : ");
            string prenom = Console.ReadLine();
            Console.Clear();
            Console.Write($"Merci {prenom}, veuillez indiquer maintenant votre nom : ");
            string nom = Console.ReadLine();
            Console.Clear();
            DateTime date_naissance = new DateTime(1987, 9, 27);
            int age = DateTime.Now.Year - date_naissance.Year;
            Console.WriteLine($"Bonjour {prenom} {nom}, soyez la bienvenue! Vous avez atteint vos {age} ans!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
