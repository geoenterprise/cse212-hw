using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  Enqueue items with different priorities and dequeue returns highest priority.
    // Expected Result: The item with the highest priority is dequeued first.
    // Defect(s) Found: Before fixing the code, the last item was skipped due to wrong loop limit.
    // After fix, test passes as expected.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same high priority.
    // Expected Result: Dequeue removes the first inserted item among the tied highest priorities using FIFO.
    // Defect(s) Found: Before fixing the code, the last inserted was dequeued due to '>=' in comparison.
    // After fix, test passes and FIFO order is taken into account.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstHigh", 5);
        priorityQueue.Enqueue("SecondHigh", 5);
        priorityQueue.Enqueue("Low", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("FirstHigh", result);
    }

    // Add more test cases as needed below.
     [TestMethod]
    // Scenario: Dequeue on empty queue shows exception.
    // Expected Result: InvalidOperationException is shown.
    // Defect(s) Found: None.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}