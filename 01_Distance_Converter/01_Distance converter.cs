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
           // 인수 지정 -> Length가 1이상이고 인수가 tom이면 Feet -> Meter
            if (args.Length >= 1 && args[0] == "-tom")
            {
                for (int feet = 1; feet <= 10; feet++)
                {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
                }
            }
            // 그 이외일 시 Meter -> Feet
            else
            {
                for(int meter = 1; meter <= 10; meter++)
                {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
                }
            }
        }


        // 계산 로직을 메서드의 형태로 독립
        private static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        private static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}
