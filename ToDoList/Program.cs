using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  class Program
  {
      static void Main()
      {
        List<Item> newList = new List<Item> { };
        Console.WriteLine("Main Menu");
        Console.WriteLine("Would you like to add an item to your to do list? ['Y' for yes, 'Enter' for no]");
        string response = Console.ReadLine();
        if (response == "Y" || response == "y")
        {
          Console.WriteLine("Enter your task");
          Item newItem = new Item(Console.ReadLine());
          
        }
        else
        {
          Console.WriteLine("Would you like to view your list? ['Y' for yes, 'Enter' for no]");
          string listAnswer = Console.ReadLine();
          if (listAnswer == "Y" || listAnswer == "y") 
          {
              List<Item> result = Item.GetAll();
              Console.WriteLine(result);
          }
        }
      }

  }
}