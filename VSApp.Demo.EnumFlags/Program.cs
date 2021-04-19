using System;

namespace VSApp.Demo.EnumFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaType media = MediaType.MusicalClip;

            if (media.HasFlag(MediaType.DrawedPicture)) Console.WriteLine("Contient des images dessinées");
            if (media.HasFlag(MediaType.RealisticPicture)) Console.WriteLine("Contient des photos");
            if (media.HasFlag(MediaType.Audio)) Console.WriteLine("contient du son");
            if (media.HasFlag(MediaType.Music)) Console.WriteLine("Contient de la musique");



            //1       2       4       8       16
            //Picture Audio
        }
    }
}
