using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam1
{
    class Program
    { 
        static int no_of_strings;
        static int max_period;
        static String[] acgt;
        static void Main(string[] args)
        {

            Console.WriteLine("enter number of stringd u want to enter");
            no_of_strings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter max_period");
            max_period = Convert.ToInt32(Console.ReadLine());

            acgt=new String[no_of_strings];
            int result = MinChanges(max_period, acgt);
            Console.WriteLine("no of replacements {0}", result);

        }

        static int MinChanges(int max_period_l, String[] acgt_l)
        {
            String app_string = "";
            for (int i = 0; i < acgt_l.Length; i++)
            {
                Console.WriteLine("Enter the string ");
                acgt_l[i] = Console.ReadLine();

                app_string = app_string + acgt[i];
            }
            Console.WriteLine(app_string);
            int count = 50;
            int period = max_period_l;
            

            while (period != 1)
            {
                int new_count=0;
                for (int j = 0; j < max_period_l; j++)
                {
                    for (int i = j; i < acgt_l.Length - period; i = i + period)
                    {
                        if (acgt_l[j] != acgt_l[i + period])
                        {
                            new_count++;
                        }
                    }

                }
                

                period--;
                if (new_count < count)
                {
                    count = new_count;
                }
            }
            return count;


        }

    }
}
