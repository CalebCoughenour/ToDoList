using System;
using System.Collections.Generic;
using ToDoList.Models;
using System.Linq;

public class Program 
{
  public static void Main()
  {
    while (true)
  {
    Console.WriteLine("Would you like to add something to your Add to your List or View it? add/view/exit");
    string userInput = Console.ReadLine();
    if (userInput == "exit")
    {
      return;
    }
    else if (userInput == "add") 
    {
      Console.WriteLine("What would you like to add to the list?");
      string description = Console.ReadLine();
      Item userItem = new Item(description);
      string result = userItem.Description;
      List<Item> newList = new List<Item> { userItem };
    }
    else if (userInput == "view")
    {
      if ( !Item.GetAll().Any() )
      {
        Console.WriteLine("Nothing to see here."); 
      }
      else 
      {
        foreach (Item item in Item.GetAll())
        {
          Console.WriteLine(item.Description);
        }
      } 
    }
    else 
    {
      Console.WriteLine("Please enter a valid entry.");
    }
  }
  }
}