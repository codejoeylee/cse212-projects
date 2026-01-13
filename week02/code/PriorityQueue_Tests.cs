using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities and ensure the highest priority is dequeued first.
    // Expected Result: Item with the highest priority is returned first.
    // Defect(s) Found: Dequeue does not remove the item from the queue. Also, loop skips last item.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5); 
        priorityQueue.Enqueue("high", 10); 

        Assert.AreEqual("high", priorityQueue.Dequeue()); 
        Assert.AreEqual("medium", priorityQueue.Dequeue()); 
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority and ensure FIFO(First in ,First Out) order is preserved.
    // Expected Result: First item with the highest priority is dequeued first.
    // Defect(s) Found: Loop skips last item, and does not remove the dequeued item from the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 10); 
        priorityQueue.Enqueue("second", 10); 
        priorityQueue.Enqueue("third", 5); 

        Assert.AreEqual("first", priorityQueue.Dequeue()); 
        Assert.AreEqual("second", priorityQueue.Dequeue()); 
        Assert.AreEqual("third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}