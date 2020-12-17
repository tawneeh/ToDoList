using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest
  {

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category() // constructor test 
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Item), newCategory.GetType());
    }

  }
}