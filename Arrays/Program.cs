using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            int [] OddNumbers=new int[4];
            string[] names = new string[5];

            names[0] = "varun";
            names[1] = "sai";
            names[2] = "Rushi";  


            OddNumbers[0] = 101;
            OddNumbers[1] = 103;
            OddNumbers[2] = 105;
            OddNumbers[3] = 107;
            //OddNumbers[4] = 109;// it will give exception ie index was out of bonds of an array cause size of array is 4
            Console.WriteLine(names[1]);
            Console.WriteLine(OddNumbers[1]);

            Console.ReadLine();
        }
    }
}


/*     Arrays in C#
 

An array is a collection of similar data types.

Advantages:  Arrays are strongly typed.

Disadvantages:  Arrays cannot grow in size once initilalized
Have to depend on integral indices to store or retrive items from
the array.
 















 */