using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    var myTestClass = new TestClass("MyName");

    Console.WriteLine(myTestClass.GetTestClassName());

    Console.WriteLine(StaticTestClass.GetStaticTestClassName());

  }

  public class TestClass
  {
    private string testClassName;

    public TestClass(string name)
    {
      testClassName = name;
    }

    public string GetTestClassName()
    {
      return testClassName;
    }
  }

  public static class StaticTestClass
  {
    private string staticTestClassName;

    static StaticTestClass(string name = "StaticClassName")
    {
      staticTestClassName = name;
    }

    public static string GetStaticTestClassName()
    {
      return staticTestClassName;
    }
  }

}
