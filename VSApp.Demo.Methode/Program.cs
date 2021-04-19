using System;

namespace VSApp.Demo.Methode
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length>0 && args[0] == "DEBUG")
            {
                Console.WriteLine("Bienvenu en mode debuggage!");
            }
            DemoMethode dm;
            dm.Condition = true;
            dm.DireBonjour();
            string text = dm.RecupererBonjour();

            dm.ConvertToIBAN("732038207644", "FR");
            dm.ConvertToIBAN("732038207644", "BE");
            dm.ConvertToIBAN("732038207644");
            dm.ConvertToIBAN("732038207644", "Toto");
            dm.ConvertToIBAN("732038207644", null);

            if (dm.CheckBBAN("732038207644")) Console.WriteLine("OK");
            else Console.WriteLine("KO");

            dm.BonjourGenre(true);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public struct DemoMethode
    {
        public bool Condition;
        public void DireBonjour()
        {
            Console.WriteLine("Bonjour! ☀");
        }

        public string RecupererBonjour()
        {
            return "Bonjour! ☀";
        }

        public int CalculerAge(DateTime dateNaissance)
        {
            return DateTime.Now.Year - dateNaissance.Year;
        }

        /// <summary>
        /// Méthode permettant de vérifier si un BBAN Belge est valide
        /// </summary>
        /// <param name="bban">Valeur au format String représentant les 12 caractères numériques d'un compte BBAN Belge.</param>
        /// <returns></returns>
        public bool CheckBBAN(string bban)
        {
            string bban_ten = bban.Substring(0, 10);
            bool bban_ten_check = ulong.TryParse(bban_ten, out ulong ten_first);
            string bban_two = bban.Substring(10);
            bool bban_two_check = ushort.TryParse(bban_two, out ushort two_last);

            ushort rest = (ushort)(ten_first % 97);

            if (rest == two_last && rest != 0) return true;
            else if (rest == 0 && two_last == 97) return true;
            return false;
        }
        /// <summary>
        /// Méthode permettant de vérifier si un BBAN Belge est valide
        /// </summary>
        /// <param name="bban">Valeur au format Unsigned Int64 représentant les 12 caractères numériques d'un compte BBAN Belge.</param>
        /// <returns></returns>
        public bool CheckBBAN(ulong bban)
        {
            //ulong ten_first = bban / 100;
            //ushort two_last = (ushort) (bban % 100);

            //ushort rest = (ushort)(ten_first % 97);

            //if (rest == two_last && rest != 0) return true;
            //else if (rest == 0 && two_last == 97) return true;
            //return false;

            return this.CheckBBAN(bban.ToString());
        }

        public string ConvertToIBAN(string bban, string country = "BE")
        {
            if (this.CheckBBAN(bban))
            {
                string bban_two = bban.Substring(10);
                bool bban_two_check = ushort.TryParse(bban_two, out ushort two_last);
                ulong Be0 = default; 
                switch (country)
                {
                    case "BE":
                        Be0 = ulong.Parse($"{two_last}{two_last}111400");
                        break;
                    case "FR":
                        Be0 = ulong.Parse($"{two_last}{two_last}152400");
                        break;
                }
                ushort two_missing = (ushort)(98 - (Be0 % 97));
                return $"BE{two_missing} {bban}";
            }
            else return null;
        }

        public void BonjourGenre(bool estUneFemme)
        {
            if (estUneFemme)
            {
                Console.WriteLine("Quel est votre nom ?");
                string name = Console.ReadLine();
                Console.WriteLine($"Bonjour, Madame {name}!");
                return;
            }
            Console.WriteLine("Bonjour Monsieur!");
        }

        public string EstValide()
        {
            string returned = "KO";
            if (Condition)
            {
                returned = "OK";
            }
            return returned;
        }
    }
}
