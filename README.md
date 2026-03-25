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

## Unit tests

### Executed tests:
- **MethodCountElements** - checks if there is correct number of elements generated
- **MethodAnyApplicable** - checks if solution is generated when there is at least one applicable element
- **MethodNoneApplicable** - checks if solution is not generated when there is not any applicable elements
- **MethodSolve** - checks if the generated solution is correct
- **MethodNotExceededCapacity** - checks if weight of the selected elements does not exceed capacity
- **MethodDuplicates** - checks if there are no duplicates among selected items

## Windows Forms App

The application consists of 3 text boxes for **capacity, seed and number of elements input**, a button for **running the simulation** and two **displays for instances and the solution**.
