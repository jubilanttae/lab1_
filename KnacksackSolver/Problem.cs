using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
namespace KnacksackSolver;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class KnapsackProblem
{
    internal int ItemCount { get; set; }
    internal int Capacity { get; set; }
    List<Item> Items { get; set; }

    internal KnapsackProblem(int seed, int itemCount, int capacity)
    {
        Random random = new Random(seed);

        ItemCount = itemCount;
        Capacity = capacity;
        Items = new List<Item>();

        for (int i = 0; i < ItemCount; i++)
        {
            int value = random.Next(1, 11);
            int weight = random.Next(1, 11);

            Items.Add(new Item(value, weight));
        }
    }

    internal Result Solve(bool verbose = false)
    {
        var result = new Result();

        var sorted = Items
            .Select((item, index) => new {Item = item, Index = index})
            .OrderByDescending(x => x.Item.Ratio)
            .ToList();

        int currentWeight = 0;

        foreach (var element in sorted)
        {
            if (currentWeight + element.Item.Weight <= Capacity)
            {
                currentWeight += element.Item.Weight;
                result.TotalWeight += element.Item.Weight;
                result.TotalValue += element.Item.Value;
                result.SelectedItems.Add(element.Index);
            }
        }

        return result;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < Items.Count; i++)
        {
            sb.AppendLine($"{i}: {Items[i]}");
        }

        return sb.ToString();
    }
}