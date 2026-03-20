using KnacksackSolver;
namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethodCountElements()
    {
        List<int> sizes = new List<int>() {1, 2, 3, 4, 5};
        foreach (int n in sizes)
        {
            KnapsackProblem problem = new KnapsackProblem(12, n, 20);
            Assert.AreEqual (n, problem.ItemCount);
        }
    }

    [TestMethod] //add checking if any element fits
                 //(at least one of them should, but it is not really checked here)
    public void TestMethodAnyApplicable()
    {
        KnapsackProblem problem = new KnapsackProblem(12, 10, 20);
        var result = problem.Solve();
        Assert.IsTrue(result.SelectedItems.Count > 0);
    }
    
    [TestMethod] //when capacity = 0, none of the elements can be selected
    public void TestMethodNoneApplicable()
    {
        KnapsackProblem problem = new KnapsackProblem(12, 10, 0);
        var result = problem.Solve();
        Assert.AreEqual(0, result.SelectedItems.Count);
    }
    
    [TestMethod] //TotalValue and TotalWeight calculated with var result = problem.Solve(true);
    public void TestMethodSolve()
    {
        KnapsackProblem problem = new KnapsackProblem(0, 4, 10);
        var result = problem.Solve();
        Assert.AreEqual(10, result.TotalValue);
        Assert.AreEqual(5, result.TotalWeight);
    }
    
    [TestMethod] //checks if TotalWeight does not exceed capacity
    public void TestMethodNotExceedCapacity()
    {
        KnapsackProblem problem = new KnapsackProblem(12, 10, 20);
        var result = problem.Solve();
        Assert.IsTrue(result.TotalWeight <= problem.Capacity);
    }

    [TestMethod] //checks if any item is selected more than once
    public void TestMethodDuplicates()
    {
        KnapsackProblem problem = new KnapsackProblem(12, 10, 20);
        var result = problem.Solve();
        
        var uniqueItems = result.SelectedItems.Distinct().Count();
        Assert.AreEqual(result.SelectedItems.Count, uniqueItems);
    }
}