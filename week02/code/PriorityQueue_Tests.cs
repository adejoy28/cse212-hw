using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    // Defect(s) Found: None.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Laundry", 3);
        priorityQueue.Enqueue("Work", 2);
        priorityQueue.Enqueue("Chores", 1);

        String expectedResult = "[Laundry (Pri:3), Work (Pri:2), Chores (Pri:1)]";

        Assert.AreEqual(expectedResult, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Remove the item with the highest priority and return its value.
    // Expected Result: The Dequeue function shall remove the item with the highest priority and return its value.
    // Defect(s) Found: Items with highestPriorityIndex was not removed even though value was gotten
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Laundry", 3);
        priorityQueue.Enqueue("Work", 2);
        priorityQueue.Enqueue("Pray", 5);
        priorityQueue.Enqueue("Chores", 1);

        var result = priorityQueue.Dequeue();

        String expectedResult = "Pray";

        Assert.AreEqual(expectedResult, result);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Select items closest to the front of the queue if there a more than one items with highest priority
    // Expected Result: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Defect(s) Found: Items with highestPriorityIndex was being overwritten even with items with the same priority index.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Laundry", 3);
        priorityQueue.Enqueue("Work", 2);
        priorityQueue.Enqueue("Pray", 3);
        priorityQueue.Enqueue("Chores", 1);

        var result = priorityQueue.Dequeue();

        String expectedResult = "Laundry";

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    // Scenario: Handling the queue is empty error 
    // Expected Result: If the queue is empty, then an error exception shall be thrown. This exception should be an InvalidOperationException with a message of "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }

    }
}