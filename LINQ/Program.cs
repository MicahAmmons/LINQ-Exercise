
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Zelda", "Donkey Kong", "Mario", "Crash Bandicoot" };
            var listSortedByLength = list.OrderBy(x => x.Length).ToList();
        }
    }
}
