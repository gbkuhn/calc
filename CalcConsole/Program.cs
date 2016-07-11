using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Calc;

namespace CalcConsole
{
    class Program
    {
        public static int current_value;
        public static int value;
        public static string op;

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a value");
            value = Convert.ToInt32(Console.ReadLine());
            */
            Calc_Lib calc_obj = new Calc_Lib();
            calc_obj.entry(1);
            calc_obj.entry("+");
            calc_obj.entry(2);
            calc_obj.entry("*");
            calc_obj.entry(2);
            calc_obj.entry("*");
            calc_obj.entry(2);

            calc_obj.main_loop();
           //Console.WriteLine(calc_obj.get_result() + "4");
            Console.ReadLine();
        }
    }
}
