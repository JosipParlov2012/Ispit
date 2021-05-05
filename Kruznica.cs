using System;

namespace Ispit
{
    
    public class Kruznica : GeometrijskiLik
    {
        
        private Duzina Radijus { get; }
        
        private Kruznica() {}

        public Kruznica(Tocka srediste, Tocka tocka)
        {
            Radijus = new Duzina(srediste, tocka);
        }
        
        public override double Opseg()
        {
            return 2 * Radijus.Duljina() * Math.PI;
        }

        public override double Povrsina()
        {
            return Math.Pow(Radijus.Duljina(), 2) * Math.PI;
        }
        
    }
    
}
