using System;

namespace Ispit
{

    public static class Program
    {
        
        public static void Main()
        {
            Duzina duzina = new Duzina(new Tocka(0, 0), new Tocka(3, 4));
            Trokut trokut = new Trokut(new Tocka(1, 1), new Tocka(4, 4), new Tocka(4, 1));
            Pravokutnik pravokutnik = new Pravokutnik(new Tocka(0, 0), new Tocka(5, -5));
            Kruznica kruznica = new Kruznica(new Tocka(0, 0), new Tocka(4, 0));

            Console.WriteLine(duzina.Duljina()); // 5
            Console.WriteLine(trokut.JeJednakostranican()); // false
            Console.WriteLine(trokut.JePravokutan());  // true
            Console.WriteLine(trokut.Opseg()); // 10.24
            Console.WriteLine(pravokutnik.Opseg()); // 20
            Console.WriteLine(pravokutnik.Povrsina()); // 25
            
            // Abstract test.
            // 25.13
            Console.WriteLine(kruznica.Opseg());
            // 50.27
            Console.WriteLine(kruznica.Povrsina());

            GeometrijskiLik[] likovi = new GeometrijskiLik[4];
            // polymorphic array
            likovi[0] = trokut;
            likovi[1] = pravokutnik;
            likovi[2] = kruznica;
        }
        
    }
    
}
