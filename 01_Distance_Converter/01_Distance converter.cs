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
                PrintFeetToMeterList(1,10);
            }
            // 그 이외일 시 Meter -> Feet
            else
            {
                PrintMeterToFeetList(1, 10);
            }
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

    }
}
