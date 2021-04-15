using System;
using System.Collections.Generic;

namespace VSApp.Demos.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Coalesce
            //List<int> ints = null;

            //if (bool.Parse(Console.ReadLine()))
            //{
            //    ints = new List<int>();
            //    ints.Add(1);
            //}
            //ints = ints ?? new List<int>();            //ints ??= new List<int>();

            //Console.WriteLine(ints.Count);
            #endregion

            #region Coalesce avec objet
            //myclass mc = new myclass();
            //mc = myclass.convert(mc) ?? myclass.convert(mc);
            #endregion
            //long i = 0;
            //Console.WriteLine(i.GetType());
            //Console.WriteLine(typeof(int));
            //if(i.GetType() == typeof(int))
            //    Console.WriteLine("Cela fonctionne?");

            //object o = (long)int.Parse(Console.ReadLine());

            //if(o is long)
            //{
            //    Console.WriteLine("Hourra c'est compatible!");
            //}



            //int i = int.MaxValue;
            //i += int.Parse(Console.ReadLine());
            //unchecked
            //{
            //    ushort us = ushort.MaxValue;
            //    ushort x = (ushort)(us + 10);
            //    Console.WriteLine(x);
            //}

            Console.WriteLine("Avec esperluette");
            if(myclass.donneFalse() && myclass.donneTrue())   //&& n'obtiens true que si 2 true
            {
                Console.WriteLine("C'est vrai!");
            }
            else
            {
                Console.WriteLine("C'est faux!");
            }


            if (myclass.donneFalse() & myclass.donneTrue())   //& n'obtiens true que si 2 true
            {
                Console.WriteLine("C'est vrai!");
            }
            else
            {
                Console.WriteLine("C'est faux!");
            }

            Console.WriteLine("Avec Pipe");


            if (myclass.donneTrue() || myclass.donneTrue())   //&& n'obtiens true que si 2 true
            {
                Console.WriteLine("C'est vrai!");
            }
            else
            {
                Console.WriteLine("C'est faux!");
            }


            if (myclass.donneTrue() | myclass.donneTrue())   //& n'obtiens true que si 2 true
            {
                Console.WriteLine("C'est vrai!");
            }
            else
            {
                Console.WriteLine("C'est faux!");
            }
        }
    }

    public class myclass {

        public bool isfirst;

        public myclass()
        {
            this.isfirst = true;
        }
        public static myclass convert(myclass root)
        {
            if (!root.isfirst)
            {
                return root;
            }
            root.isfirst = !root.isfirst;
            return null;
        }

        public static bool donneTrue()
        {
            Console.WriteLine("Je donne vrai...");
            return true;
        }
        public static bool donneFalse()
        {
            Console.WriteLine("Je donne faux...");
            return false;
        }
    }
}
