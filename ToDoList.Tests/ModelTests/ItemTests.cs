using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System; 
using MySql.Data.MySqlClient;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    public void ItemTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=to_do_list_test;";
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Item()
    {
      // Arrange, Act
      Item firstItem = new Item("Mow the lawn");
      Item secondItem = new Item("Mow the lawn");

      // Assert
      Assert.AreEqual(firstItem, secondItem);
    }

    [TestMethod]
    public void Save_SavesToDatabase_ItemList()
    {
      //Arrange
      Item testItem = new Item("Mow the lawn");

      //Act
      testItem.Save();
      List<Item> result = Item.GetAll();
      List<Item> testList = new List<Item>{testItem};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item()
    // {
    //   Item newItem = new Item("test");
    //   Assert.AreEqual(typeof(Item), newItem.GetType());
    // }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   // Arrange - gather, declare and create all necessary components
    //   string description = "Walk the doggo.";
    //   Item newItem = new Item(description);
    //   // Act - invoke functionality (often by calling a method or retriecing a property)
    //   string result = newItem.Description;
    //   // Assert - confirm the functionality works properly by comparing actual output to anticipated output (description and result AreEqual)
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   // Arrange
    //   string description = "Walk the doggo.";
    //   Item newItem = new Item(description);

    //   // Act
    //   string updatedDescription = "Do the dishes.";
    //   newItem.Description = updatedDescription;
    //   string result = newItem.Description;

    //   // Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };

      // Act
      List<Item> result = Item.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      newItem1.Save(); // New code
      Item newItem2 = new Item(description02);
      newItem2.Save(); // New code
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   // Arrange
    //   string description = "Walk the doggo.";
    //   Item newItem = new Item(description);

    //   // Act
    //   int result = newItem.Id;

    //   // Assert
    //   Assert.AreEqual(1, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectItem_Item()
    // {
    //   // Arrange
    //   string description01 = "Walk the doggo.";
    //   string description02 = "Do the dishes.";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);

    //   // Act
    //   Item result = Item.Find(2);

    //   // Assert
    //   Assert.AreEqual(newItem2, result);
    // }
  }
}