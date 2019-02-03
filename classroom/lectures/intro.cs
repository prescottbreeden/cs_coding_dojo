using System;

namespace projectname
{
  class Counter
  {
    public int intProp { get; set; }
    public string strProp { get; set; }

    // -----------------------
    //       overloading
    // -----------------------

    public Counter()
    {
      intProp = 0;
      strProp = "I'm the count... ah ah ah!";
    }

    public Counter(int num)
    {
      intProp = num;
    }

    public Counter(int num, string str)
    {
       intProp = num;
       strProp = str; 
    }

    // -----------------------
    //     implementation
    // -----------------------
    
    public void countOneToTen()
    {
      for (int i = 1; i <= 10; i++)
      {
        console.WriteLine(i);
      }
    }

    public void countOneToTen()
    {
      int i = 1;
      while (i <= 10)
      {
        console.WriteLine(i);
      }
    }

    // -----------------------
    //       overwriting
    // -----------------------

    public override string ToString()
    {
      return "Rubber Baby Buggy Bumpers";
    }

  }
}






