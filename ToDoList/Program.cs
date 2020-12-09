using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList // files with the same namespace will be able to communicate with each other
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Main Menu");
      Console.WriteLine("If you would like to add an item to your to do list [press 'A'] or if you would like to view your list [press 'Enter']");
      string response = Console.ReadLine();
      if (response == "A" || response == "a")
      {
        Console.WriteLine("Enter your task");
        Item newItem = new Item(Console.ReadLine());
        Main();
      }
      else
      {
        List<Item> result = Item.GetAll(); // can create new empty List here - but not needed at all
        foreach (Item thisItem in result)
        {
          Console.WriteLine("To-Do: " + thisItem.Description);
        }
        Main(); 
      }
    }
  }
}