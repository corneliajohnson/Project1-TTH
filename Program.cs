using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album1 = new Album("Let It Burn", "Usher");
            var album2 = new Album("The Carter", "Lil Wayne");
            var album3 = new Album("Take Care", "Drake");

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());

            album1.Loan("Mary");
            Console.WriteLine(album1.GetDisplayText());

            album1.Return();
            Console.WriteLine(album1.GetDisplayText());

            album1.Loan();
            Console.WriteLine(album1.GetDisplayText());

            Console.ReadLine();
        }
    }
}