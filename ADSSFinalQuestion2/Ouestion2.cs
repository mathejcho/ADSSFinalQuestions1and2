using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSFinalQuestion2
{
    class Ouestion2
    {

        static void Main(string[] args)
        {
            Ouestion2 p = new Ouestion2();


            string[] sheep = new string[6];

            Console.WriteLine("Enter status of 6 sheep ");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter status  ");
                sheep[i] = Console.ReadLine();
            }

            p.countSheep(sheep);
            Console.ReadLine();
        }

        public void countSheep(string[] sheep)
        {
            int here = 0;
            int nothere = 0;
            int missing = 0;


            foreach (string shep in sheep)
            {
                if (shep == "True" || shep == "true")
                {

                    here++;
                }
                else if (shep == "False" || shep == "false")
                {

                    nothere++;
                }
                else
                {

                    missing++;
                }
            }

            Console.WriteLine(here + " sheep are present ");
            Console.WriteLine(nothere + " sheep are absent ");
            Console.WriteLine(missing + " sheep presence unknown");


        }

    }
}
