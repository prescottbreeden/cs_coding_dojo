using System;

namespace sorts
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] bob = { 5, 4, 3, 2, 1, 0 };
      // int[] ross = Lib.BubbleSort(bob);
      int[] ross = Lib.SelectionSort(bob);
      Lib.PrintArr(ross);
    }
  }
}
