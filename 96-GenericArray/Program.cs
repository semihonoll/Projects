using System.Collections;

namespace _96_GenericArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p0 = new int[] { 8, 9, 10, 11 };
            var p1 = new List<int>() { 5, 10, 15, 20 };

            foreach (int i in p1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n**************\n");
            var px = p1;

            foreach (var i in px)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n**************\n");
            px.Add(53);

            foreach (var i in p1)
            {
                Console.WriteLine(i);
            }

            var p3 = new ArrayList() { 12, 14, 16, 18 }; //Tipi güvenliği.

            Console.WriteLine("\n*******My Array*******\n");

            var arr = new Array<int>();

            for (int i = 0; i < 8; i++)
            {
                arr.Add(i);
                Console.WriteLine(arr.ToString());
            }

            Console.WriteLine("\n**************\n");

            for (int i = arr.Count; i >= 1; i--)
            { 
                arr.Remove(i);
                Console.WriteLine(arr.ToString());
            }


            Console.WriteLine();


        }
    }
}
