using System;

namespace VSApp.Demo.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg;
            msg.subject = "Toto est encore malpoli";
            msg.content = "Madame, Monsieur, votre fils toto...";
            msg.sender = "prof@toto.ecole.be";
            msg.receiver = "parent@toto.ecole.be";

            Message msg2 = msg;

            Console.WriteLine($"{msg.subject}");
            Console.WriteLine($"{msg2.subject}");

            msg2.subject = "Titi est trop gentil!";

            Console.WriteLine($"{msg.subject}");
            Console.WriteLine($"{msg2.subject}");
        }
    }
}
