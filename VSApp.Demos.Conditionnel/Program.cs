using System;

namespace VSApp.Demos.Conditionnel
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Structure conditionnel
            //Console.WriteLine("Bonjour et bienvenu sur le site de la loterie nationale belge!");
            //Console.Write("Veuillez indiquer votre âge :");
            //int age;
            //bool age_check = int.TryParse(Console.ReadLine(), out age);
            //if (age_check)
            //{
            //    if(age >= 18)
            //    {
            //        Console.Write("Quel est votre nationalité ?");
            //        Console.WriteLine("1. Français");
            //        Console.WriteLine("2. Belge");
            //        Console.WriteLine("3. Luxembourgeois");

            //        bool choix_check = int.TryParse(Console.ReadLine(), out int choix);

            //        if (choix_check)
            //        {
            //            switch (choix)
            //            {
            //                case 2:
            //                    Console.WriteLine("Bienvenue à la loterie national!");
            //                    break;
            //                case 1:
            //                case 3:
            //                    Console.WriteLine("Vous n'avez pas le bon goût des choses.");
            //                    break;
            //                default:
            //                    Console.WriteLine("Votre choix n'est pas valide!");
            //                    break;
            //            }
            //        }
            //        else Console.WriteLine("Il fallait choisir entre 1 et 3...");
            //    }
            //    else Console.WriteLine("Dégage gamin!");
            //}
            //else Console.WriteLine("Âge invalide.");
            #endregion

            #region Switch Case
            //string meteo = "Ensoleillé";

            //string first_value = Console.ReadLine();

            //switch (meteo)
            //{
            //    case "Ensoleillé":
            //        Console.WriteLine("☀");
            //        break;
            //    case "Nuageux":
            //        Console.WriteLine("☁");
            //        break;
            //}
            #endregion

            #region Opérateur ternaire
            Console.WriteLine("Quel est votre age ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Quelle est votre nationalité ?");
            string nationnalite = Console.ReadLine();
            string message = (age < 18)
                                        ? "Revenez dans quelques années"
                                        : (nationnalite == "Belge")
                                                                ? "Bienvenue"
                                                                : "Vous n'êtes pas de la bonne nationalité";
            Console.WriteLine(message);
            #endregion
        }
    }
}