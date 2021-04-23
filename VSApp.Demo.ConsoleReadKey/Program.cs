using System;

namespace VSApp.Demo.ConsoleReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                cki = Console.ReadKey();
                Console.WriteLine($"Caractère : {cki.KeyChar}, Touche : {cki.Key} + {cki.Modifiers}");

            } while (!(cki.Key == ConsoleKey.Q && cki.Modifiers == ConsoleModifiers.Control));
        }


        /*
         Définissez un enum d'action ( Avancer, reculer, tourner à gauche, tourner à droite, valider, ouvrir inventaire, quitter,...)
        Créez en une seul variable une liaison de touches aux actions définis dans notre énum de telle sorte que vous puissez afficher le nom des actions à la pression d'une touche.

        Exemple :
        J'appuie sur i => la Console affiche OuvrirInventaire
        J'appuie sur e => la Console affiche Valider
        J'appuie sur Enter => la Console affiche Valider
        J'appuie sur z => la Console affiche Avancer
        J'appuie sur Flèche du haut => la Console affiche Avancer
        J'appuie sur 7 du NumPad => la Console affiche Avancer
        ...
         
         */
    }
}
