using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Calc
{

    public class Calc_Lib
    {
        private int saved_value;
        
        private static int result_val { get; set; }

        List<string> equation_list = new List<string>();

        public void main_loop()
        {

            for (int i = 0; i < equation_list.Count; i++)
            {

                if (equation_list[i].Equals("+"))
                {
                    if (i >= 3)
                    {
                        saved_value = saved_value + Convert.ToInt32(equation_list[i + 1]);

                    }
                    else
                    {
                        saved_value = (Convert.ToInt32(equation_list[i - 1]) + Convert.ToInt32(equation_list[i + 1]));
                    }
                }
                else if (equation_list[i].Equals("-"))
                {
                    if (i >= 3)
                    {
                        saved_value = saved_value - Convert.ToInt32(equation_list[i + 1]);

                    }
                    else
                    {
                        saved_value = (Convert.ToInt32(equation_list[i - 1]) - Convert.ToInt32(equation_list[i + 1]));
                    }
                }
                else if (equation_list[i].Equals("*"))
                {
                    if (i >= 3)
                    {
                        saved_value = saved_value*Convert.ToInt32(equation_list[i + 1]);

                    }
                    else
                    {
                        saved_value = (Convert.ToInt32(equation_list[i - 1])*Convert.ToInt32(equation_list[i + 1]));
                    }
                }
                else if (equation_list[i].Equals("/"))
                {
                    if (i >= 3)
                    {
                        saved_value = saved_value*Convert.ToInt32(equation_list[i + 1]);
                    }
                    else
                    {
                        saved_value = (Convert.ToInt32(equation_list[i - 1])*Convert.ToInt32(equation_list[i + 1]));
                    }
                }
            }
            //print result
            Console.WriteLine("result: " + saved_value);
        }
        
        public void entry(int val_)
        {
            equation_list.Add(val_.ToString());

        }

        public void entry(string val_)
        {
            equation_list.Add(val_);
        }

        public int get_result()
        {
            return saved_value;

        }
    
    }

    }
    

