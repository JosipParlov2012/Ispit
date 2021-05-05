namespace Ispit
{
    
    public class Pravokutnik : GeometrijskiLik
    {
        
        private Duzina DuzinaA { get; }
        private Duzina DuzinaB { get; }
        
        private Pravokutnik() {}

        public Pravokutnik(Tocka tockaA, Tocka tockaB)
        {
            DuzinaA = new Duzina(tockaA, new Tocka(tockaB.X, tockaA.Y));
            DuzinaB = new Duzina(tockaA, new Tocka(tockaA.X, tockaB.Y));
        }
        
        public override double Opseg()
        {
            return 2 * (DuzinaA.Duljina() + DuzinaB.Duljina());
        }

        public override double Povrsina()
        {
            return DuzinaA.Duljina() * DuzinaB.Duljina();
        }
        
    }
    
}
