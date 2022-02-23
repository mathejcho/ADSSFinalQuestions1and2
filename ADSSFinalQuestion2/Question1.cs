using System;

namespace ADSSFinalQuestion1
{
    class Program
    {
        public void FindStudent()
        {
            Console.WriteLine("Enter string");
            string st = Console.ReadLine();

            string[] arr = st.Split(',');

            int[] Students = Array.ConvertAll(arr, int.Parse);

           

            Array.Sort(Students);
            int youngest = 0;
            int oldest = 0;

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[0] == Students[i])
                {
                    youngest = youngest + 1;
                    
                }
            }

            for (int y = 7; y > 0; y--)
            {
                if (Students[7] == Students[y])
                {
                    oldest = oldest + 1;
                    
                }
            }


            Console.WriteLine("the youngest Student is " + Students[0]);
            if (youngest > 1)
            {
                Console.WriteLine("\nThere are " + youngest + " students at that age in the group. ");
            }

            Console.WriteLine("\nThe oldest student is" + Students[7]);

            if (oldest > 1)
            {
                Console.WriteLine("\nThere are " + oldest + " students at that age in the group. ");
            }





        }

        

        static void Main(string[] args)
        {
            int[] arr = { 10, 15, 9, 12, 15, 7, 7, 8 };

            Program p = new Program();
           
            p.FindStudent();
            
            Console.ReadLine();

        }
    }
}
