using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
namespace KnacksackSolver;

class Item
{
    internal int Value { get; set; }
    internal int Weight { get; set; }

    internal Item(int value, int weight)
    {
        Value = value;
        Weight = weight;
    }

    internal double Ratio => (double)Value / Weight;

    public override string ToString()
    {
        return $"Value: {Value}, Weight: {Weight}";
    }
}