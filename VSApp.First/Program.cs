using System;
using System.Text;

namespace VSApp.First
{
    class Program
    {
        #region Fields / Champs
        int champs;

        const string NAME = "Samuel";
        #endregion
        #region Methods
        public void MaMethode()
        { 
            #region Différences Variables locales et champs

            int varLocal = 10;

            Console.WriteLine(varLocal);
            Console.WriteLine(champs);

            #endregion

            object o = null;
            string s = null;
        }
        static void Main(string[] args)
        {
            #region Exemple Console.WriteLine()
            //Console.WriteLine("Samuel");
            //Console.WriteLine('L');
            //Console.WriteLine(33);
            //Console.WriteLine("Êtes-vous une femme?");
            //Console.WriteLine(false); //true
            //Console.WriteLine(11.40);
            //Console.WriteLine(new object());
            //Console.WriteLine();
            #endregion

            #region Exemple Console.Write()
            //Console.Write("Samuel");
            //Console.Write('L');
            //Console.Write(33);
            //Console.Write("Êtes-vous une femme?");
            //Console.Write(false); //true
            //Console.Write(11.40);
            //Console.Write(new object());
            ////Console.Write(); doit toujours obtenir une valeur entre ses parenthèses
            #endregion

            #region Formattage Console.WriteLine()
            //Console.Clear();
            //Console.Write("Quel est votre nom?\n");
            //string name = Console.ReadLine();
            //Console.WriteLine("Bienvenue {0}",name);
            //Console.WriteLine($"Bienvenue {name}");
            #endregion

            #region Variable et initialisation

            //int x = 10, y;
            //y = 10;

            ////int x = 10, y = 10;

            ////int x, y;
            ////x = y = 10;

            ////int x, y = x = 10;

            //Console.WriteLine($"x : {x} | y : {y}");

            #endregion

            #region Les Types

            //int i1 = 2147483647;
            //uint ui = 2147483648;
            //long l1 = -2147483649;
            //ulong ul = 2147483649;
            //short sh = 32000;
            //ushort us = 65000;

            ////float fl = 3.14;
            //double db = 3.14;

            ////decimal dc = 3.14;

            //bool bo = true; // false;
            //                // 
            //DateTime date = DateTime.Now;
            //date = new DateTime(1987, 9, 27);
            //long d = date.Ticks;

            #endregion

            #region Les caractères
            //string code = "AXHRF";
            //string codeCrypt = "00000";
            //string s = $"Code d'entrée : {code}\rCode d'entrée : {codeCrypt} les Amis!";
            //Console.WriteLine(s);

            //Console.Write(code);
            //Console.Write("\r");
            //Console.Write(codeCrypt);

            #endregion

            #region Struct vs Ref

            int i1 = 5;
            int i2 = i1;

            Console.WriteLine(i1); //5
            Console.WriteLine(i2); //5

            i2 = 7;

            Console.WriteLine(i1); //5
            Console.WriteLine(i2); //7

            string s1 = "Une chaine";
            string s2 = s1;

            Console.WriteLine(ReferenceEquals(s1,s2));

            s2 = "Une autre chaine";

            Console.WriteLine(ReferenceEquals(s1,s2));


            #endregion

            #region Fin Programme
            //Console.Write("Appuyez sur Enter pour ferme le programme...");
            //Console.ReadLine();
            //Console.Clear();
            #endregion
        }


        #endregion
    }
}
