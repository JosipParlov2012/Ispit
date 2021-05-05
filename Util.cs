using System;

namespace Ispit
{
    
    public static class Util
    {
        
        public static bool FloatEquals(float a, float b)
        {
            return Math.Abs(a - b) < float.Epsilon;
        }

        public static bool VrijediPitagora(float duljinaA, float duljinaB, float duzinaC)
        {
            return FloatEquals((float) Math.Sqrt(Math.Pow(duljinaA, 2) + Math.Pow(duljinaB, 2)), duzinaC);
        }

    }
    
}
