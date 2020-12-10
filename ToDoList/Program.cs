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
      Console.WriteLine("If you would like to add an item to your to do list [press 'A'], to remove an item [press 'r'], or to view your list [press 'Enter']");
      string response = Console.ReadLine();
      if (response == "A" || response == "a")
      {
        Console.WriteLine("Enter your task");
        Item newItem = new Item(Console.ReadLine());
        Main();
      }
      else if (response == "r" || response == "R")
      {
        Console.WriteLine("Type the task you wish to remove:");
        List<Item> gathered = Item.GetAll();
        Item removeItem = new Item(Console.ReadLine());

        // foreach (Item thisItem in gathered)
        // {
        //   Console.WriteLine("To-Do: " + thisItem.Description);
        // }

        Console.WriteLine(gathered.Remove(removeItem));
        // Console.WriteLine(gathered.Remove();
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