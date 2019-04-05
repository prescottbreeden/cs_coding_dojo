using System;

namespace sorts
{
  class Lib
  {
    public static int[] SelectionSort(int[] arr)
    {
      int start = 0;
      while(start < arr.Length)
      {
        int min = arr[start];
        for(int i = start; i < arr.Length; i++)
        {
          if (arr[i] < arr[min])
            min = i;
        }
        int temp = arr[start];
        arr[start] = arr[min];
        arr[min] = temp;
        start++;
      }
      return arr;
    }

    public static int[] BubbleSort(int[] arr)
    {
      Boolean sorted = false;
      while(!sorted)
      {
        Boolean touched = false;
        for(int i = 0; i < arr.Length - 1; i++)
        {
          if (arr[i] > arr[i+1])
          {
            touched = true;
            int temp = arr[i];
            arr[i] = arr[i+1];
            arr[i+1] = temp;
          }
        }
        if (!touched) 
          sorted = true;
      }
      return arr;
    }

    public static void PrintArr(int[] arr)
    {
      foreach(int num in arr)
      {
        System.Console.WriteLine(num);     
      };
    }

  }
}
