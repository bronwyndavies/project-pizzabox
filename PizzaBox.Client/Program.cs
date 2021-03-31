using System;
using System.Collections.Generic;

namespace PizzaBox.Client
{
  internal class Program //access modifiers - internal, protected, public, private 
  {
    private static void Main(string[] args)
    {
      Run();
    }
    private static void Run() //needs to be static...static vs constant vs readonly
    {
      System.Console.WriteLine("Welcome to PizzaBox");
      var stores = new List<string>()
      {
          "Store 001",
          "Store 002",
          "Store 003"
      };

      foreach (var item in stores)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}
