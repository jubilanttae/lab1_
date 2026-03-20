# lab1_
.net &amp; java lab 1 project repository

## Knapsack problem solution

### Used classes:
- **Item** with Value and Weight attributes
- **Result** with SelectedItems, TotalValue and TotalWeight attributes
- **Knapsackproblem** with ItemCount, Seed and Capacity attributes, also containing an item list

In addition, **ToString()** function has been overrided to make reffering 
to the result easier in further steps of the project

### Solve() function:
The problem is solved by defining ratio for each of the items, then sorting them descending 
and deciding what items are the most valuable to pack.

### Randomizing instances:
The instances are generated pseudorandomly using seed provided by the user.
