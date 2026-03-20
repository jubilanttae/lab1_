using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
namespace KnacksackSolver;

using System.Collections.Generic;
using System.Text;

class Result
{
    internal List<int> SelectedItems { get; set; } = new List<int>();
    internal int TotalValue { get; set; }
    internal int TotalWeight { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Selected items: " + string.Join(", ", SelectedItems));
        sb.AppendLine("Total value: " + TotalValue);
        sb.AppendLine("Total weight: " + TotalWeight);
        return sb.ToString();
    }
}