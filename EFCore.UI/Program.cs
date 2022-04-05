using EFCore.Data;

var _context = new EFCoreContext();
_context.Database.EnsureCreated();
var results = _context.EFCores.ToList();
Console.WriteLine($"Beginning: { results.Count}");

if (results.Any())
{
    foreach (var result in results)
    {
        Console.WriteLine(result);
    }
}

var efcoreitem = new EFCore.Domain.EFCore { Name = "Simpson" };
_context.EFCores.Add(efcoreitem);
_context.SaveChanges();

var resultslast = _context.EFCores.ToList();
Console.WriteLine($"Last: { resultslast.Count}");
