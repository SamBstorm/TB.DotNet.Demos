using System;
using System.Collections.Generic;

namespace VSApp.Demo.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User { Email = "samuel.legrain@bstorm.be", Identifiant = "Formateur", MotDePasse = "1234Test=", Droit=DroitUtilisateur.Administrateur | DroitUtilisateur.RedacteurEnChef });
            users.Add(new User { Email = "toto@bstorm.be", Identifiant = "Stagiaire", MotDePasse = "1234Test=", Droit = DroitUtilisateur.Utilisateur });
            users.Add(new User() { Email = "titi@bstorm.be", Identifiant = "Stagiaire", MotDePasse = "1234Test=" });

            User u = users[0];
            if (u.Droit.HasFlag(DroitUtilisateur.Administrateur)) Console.WriteLine("Il peut donner des cours");
            if (u.Droit.HasFlag(DroitUtilisateur.Utilisateur)) Console.WriteLine("Il peut suivre des cours");
            if (u.Droit.HasFlag(DroitUtilisateur.RedacteurEnChef)) Console.WriteLine("Il peut rédiger des cours");

            foreach (string color in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                Console.BackgroundColor = Enum.Parse<ConsoleColor>(color);
                Console.WriteLine($"{(int)Console.BackgroundColor} {color}");
            }

            ConsoleColor fgc;
            do
            {
                Console.WriteLine("Veuillez choisir votre couleur : ");
            } while (!Enum.TryParse<ConsoleColor>(Console.ReadLine(), out fgc));

            Console.ForegroundColor =fgc;
            Console.WriteLine("Merci!");

        }
    }

    [Flags]
    enum DroitUtilisateur { Administrateur = 1, Utilisateur=2, RedacteurEnChef = 4 }

    struct User
    {
        public string Email;
        public string Identifiant;
        public string MotDePasse;

        public DroitUtilisateur Droit;
    }
}
