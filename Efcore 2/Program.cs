using Microsoft.EntityFrameworkCore;
namespace Efcore_2;

internal class Program
{
    static void Main(string[] args)
    {
        using var context = new EventHubContext();
        context.Database.Migrate();

        Console.WriteLine("EventHub Database created successfully!");
    }
}