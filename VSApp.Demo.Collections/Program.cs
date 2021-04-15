using System;
using System.Collections; //Obligatoire pour obtenir les collections C#
using System.Collections.Generic; //Obligatoire pour obtenir les collections Generic C#


namespace VSApp.Demo.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            //list.Add(5);
            //list.Add(5);
            //list.Add(6);
            //list.Add(5);

            //if (list.Contains(5)) Console.WriteLine("La liste contient la valeur de 5");

            //while(list.Contains(5)) list.Remove(5);

            //list[0] = "toto";
            //Console.WriteLine(list[0]);

            Dictionary<char, List<string>> livres = new Dictionary<char, List<string>>();

            livres.Add('H', new List<string>());
            livres['H'].Add("Harry Potter - A l'école des sorciers");
        }
    }
}
