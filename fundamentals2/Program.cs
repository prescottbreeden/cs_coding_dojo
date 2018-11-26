using System;

namespace fundamentals2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[3,2];
            int[,,] array3D = new int[2,3,4]
                {
                    { {1,2,3,4},        {5,6,7,8},      {9,10,11,12} },
                    { {21,22,23,24},    {25,26,27,28},  {29,210,211,212} },
                };

            /* 

            What if we need to vary the lengths of inner arrays?
            This leads to a third way of creating arrays called a 'Jagged Array'

            Though initialized and accessed differently, jagged arrays set out
            to accomplish the same task of holding arrays within arrays, but 
            without the need for uniform inner array sizes.

            */
            int[][] jaggedArray = new int[3][];

            System.Console.WriteLine(array2D[0,1]);
            System.Console.WriteLine(array3D[1,0,3]);
        }
    }
}
