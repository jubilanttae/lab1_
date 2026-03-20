using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
namespace KnacksackSolver;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the seed: ");
        if (!TryReadInt(out int seed))
        {
            Console.WriteLine("Invalid seed.");
            return;
        }

        Console.Write("Enter the item count: ");
        if (!TryReadInt(out int itemCount))
        {
            Console.WriteLine("Invalid item count.");
            return;
        }

        Console.Write("Enter the capacity: ");
        if (!TryReadInt(out int capacity))
        {
            Console.WriteLine("Invalid capacity.");
            return;
        }

        var problem = new KnapsackProblem(seed, itemCount, capacity);

        Console.WriteLine();
        Console.WriteLine("Problem:");
        Console.WriteLine(problem);

        var result = problem.Solve(verbose: true);

        Console.WriteLine();
        Console.WriteLine("Solution:");
        Console.WriteLine(result);
    }

    static bool TryReadInt(out int value)
    {
        return int.TryParse(Console.ReadLine(), out value);
    }
}