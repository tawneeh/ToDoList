using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System; 

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll(); // comment this line out to run foreach loops with dotnet test! delete this comment and foreach loops(x2) when done testing
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange - gather, declare and create all necessary components
      string description = "Walk the doggo.";
      Item newItem = new Item(description);
      // Act - invoke functionality (often by calling a method or retriecing a property)
      string result = newItem.Description;
      // Assert - confirm the functionality works properly by comparing actual output to anticipated output (description and result AreEqual)
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      // Arrange
      string description = "Walk the doggo.";
      Item newItem = new Item(description);

      // Act
      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      // Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };

      // Act
      List<Item> result = Item.GetAll();

      // foreach (Item thisItem in result)
      // {
      //   Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
      // }

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      // Arrange
      string description01 = "Walk the doggo.";
      string description02 = "Do the dishes.";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      // Act
      List<Item> result = Item.GetAll();

      // foreach (Item thisItem in result)
      // {
      //   Console.WriteLine("Output from second GetAll test " + thisItem.Description);
      // }

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}