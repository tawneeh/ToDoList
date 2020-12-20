using System.Collections.Generic; // needed to access Lists
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; } 
    public int Id { get; }

    public Item(string description) // constructor
    {
      Description = description;
    }

    public Item(string description, int id) // overloaded constructor 
    {
      Description = description;
      Id = id;
    }

    public static List<Item> GetAll()
    {
        List<Item> allItems = new List<Item> { };
        MySqlConnection conn = DB.Connection();
        conn.Open(); // each time we make a query, we need to open a new database connection. lines 19 and 20
        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM items;"; // lines 21 and 22: this is the actual SQL query. selecting all entries from the items table. The query is stored in a special object called a MySqlCommand. MySqlConnection needs a MySqlCommand
        MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader; // this Data Reader Object is responsible for reading the data returned by our database in response to the query command
        while (rdr.Read()) // build-in Read() method (built-in to the MySqlDataReader object). Reads results one at a time from the database and returns a boolean; when it reaches the end of the database records, it returns false and the while loop ends
        { // this code block below turns each row in our database into an Item stored in a List that our application understands. lesson 6
            int itemId = rdr.GetInt32(0);
            string itemDescription = rdr.GetString(1);
            Item newItem = new Item(itemDescription, itemId); // must add an overloaded constructor to Item so that Items retrieved from the database can contain their Id
            allItems.Add(newItem);
        }
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
        return allItems; // returns the list of all items
    }

    public static void ClearAll()
    {
      // empty for now
    }

    public static Item Find(int searchId)
    {
    // Temporarily returning placeholder item to get beyond compiler errors until we refactor to work with a database.
    Item placeholderItem = new Item("placeholder item");
    return placeholderItem;
    }

  }
}