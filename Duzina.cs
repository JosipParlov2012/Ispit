using System;

namespace Ispit
{
    
    public class Duzina
    {
        
        private Tocka TockaA { get; }
        private Tocka TockaB { get; }
        
        private Duzina() {}

        public Duzina(Tocka tockaA, Tocka tockaB)
        {
            TockaA = tockaA;
            TockaB = tockaB;
        }

        public float Duljina()
        {
            return (float) Math.Sqrt(Math.Pow(TockaB.X - TockaA.X, 2) + Math.Pow(TockaB.Y - TockaA.Y, 2));
        }
        
    }
    
}
