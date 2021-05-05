using System;

namespace Ispit
{
    
    public class Trokut : GeometrijskiLik
    {

        private Duzina DuzinaA { get; }
        private Duzina DuzinaB { get; }
        private Duzina DuzinaC { get; }

        private Trokut() {}

        public Trokut(Tocka tockaA, Tocka tockaB, Tocka tockaC)
        {
            DuzinaA = new Duzina(tockaB, tockaC);
            DuzinaB = new Duzina(tockaA, tockaC);
            DuzinaC = new Duzina(tockaA, tockaB);
        }

        public bool JeJednakostranican()
        {
            float duljinaA = DuzinaA.Duljina();
            float duljinaB = DuzinaB.Duljina();
            float duljinaC = DuzinaC.Duljina();
            return Util.FloatEquals(duljinaA, duljinaB) &&
                   Util.FloatEquals(duljinaB, duljinaC) &&
                   Util.FloatEquals(duljinaC, duljinaA);
        }

        public bool JePravokutan()
        {
            float duljinaA = DuzinaA.Duljina();
            float duljinaB = DuzinaB.Duljina();
            float duljinaC = DuzinaC.Duljina();
            return Util.VrijediPitagora(duljinaB, duljinaC, duljinaA) ||
                   Util.VrijediPitagora(duljinaA, duljinaC, duljinaB) ||
                   Util.VrijediPitagora(duljinaA, duljinaB, duljinaC);
        }

        public override double Opseg()
        {
            return DuzinaA.Duljina() + DuzinaB.Duljina() + DuzinaC.Duljina();
        }

        public override double Povrsina()
        {
            double s = Opseg() / 2;
            return Math.Sqrt(s * (s - DuzinaA.Duljina()) * (s - DuzinaB.Duljina()) * (s - DuzinaC.Duljina()));
        }
        
    }
    
}
