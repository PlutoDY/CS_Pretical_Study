using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_CS_StudyProject._01_Distance_Converter
{
    public class FeetConverter
    {
        // meter -> feet
        public double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        // feet -> meter
        public double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
