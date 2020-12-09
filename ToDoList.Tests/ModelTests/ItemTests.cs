using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
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

  }
}