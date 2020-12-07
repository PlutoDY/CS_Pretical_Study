using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_CS_StudyProject._01_Distance_Converter
{
    class _01_Distance_converter
    {
        private static void Main(string[] args)
        {
            // feet -> meter
            for(int feet = 1; feet <= 10; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        private static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
    }
}
