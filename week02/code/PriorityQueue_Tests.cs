using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{

    [TestMethod]
     // Scenario: Add three items with different priorities: A (priority 3), B (priority 1), C (priority 2).
     // Expected Result: When dequeued, the order should be: B, C, A (lowest number = highest priority).
     // Defect(s) Found: TBD (depends on implementation).
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("Low", 1);
        queue.Enqueue("Medium", 5);
        queue.Enqueue("High", 10);

        // "High" comes out first
        Assert.AreEqual("High", queue.Dequeue());
        // Then "Medium"
        Assert.AreEqual("Medium", queue.Dequeue());
        // Then "Low"
        Assert.AreEqual("Low", queue.Dequeue());
    }


    [TestMethod]
    public void TestPriorityQueue_2()
    // Scenario: Add multiple items with the same priority: A, B, C (all with priority 1).
    // Expected Result: Elements are dequeued in insertion order: A, B, C.
    // Defect(s) Found: TBD.
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 3);
        queue.Enqueue("B", 3);
        queue.Enqueue("C", 2);

        // if it's not stable, can return A or B first (depending >= vs >)

        Assert.AreEqual("B", queue.Dequeue()); // B added after A and has same priority
        Assert.AreEqual("A", queue.Dequeue()); // A noe
        Assert.AreEqual("C", queue.Dequeue()); // Finally C
    }
}