using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_CS_StudyProject._01_Distance_Converter
{
    public static class FeetConverter
    {
        // meter -> feet
        public static double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        // feet -> meter
        public static double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
