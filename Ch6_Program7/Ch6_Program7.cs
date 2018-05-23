using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;

namespace Ch6_Program7
{
    class Ch6_Program7 : CT
    {
        static void Main(string[] args)
        {
            
            CT.Header("Ch6_Program7",
               "to make a 10 by 10 multiplication table");

            //Good starting values
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("{0}\t", i*j);
                    //MR.LYNCH SHOWED ME HOW TO DO IT THE GOOD WAY
                }
                Console.WriteLine();
            }
            //I did it by adding which is not as smart as this way
            Header2();

            CT.Footer();
        }
    }
}
