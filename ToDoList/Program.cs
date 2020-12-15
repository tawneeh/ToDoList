using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList // files with the same namespace will be able to communicate with each other
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}