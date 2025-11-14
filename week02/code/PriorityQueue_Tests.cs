using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue that has both data and a set priority. make sure that the objects containing data and priority are being added to the back of the queue.
    // Expected Result: [floor, desk, bed, closet]
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        var floor = new PriorityItem("floor", 3);
        var desk = new PriorityItem("desk", 3);
        var bed = new PriorityItem("bed", 2);
        var closet = new PriorityItem("closet", 1);

        string expectedResult = "[floor (Pri:3), desk (Pri:3), bed (Pri:2), closet (Pri:1)]";

        priorityQueue.Enqueue(floor.Value, floor.Priority);
        priorityQueue.Enqueue(desk.Value, desk.Priority);
        priorityQueue.Enqueue(bed.Value, bed.Priority);
        priorityQueue.Enqueue(closet.Value, closet.Priority);

        Assert.AreEqual(expectedResult, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue highest priority item.
    // Expected Result: "desk" will be returned
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("bed", 1);
        priorityQueue.Enqueue("floor", 3);
        priorityQueue.Enqueue("desk", 3);
        priorityQueue.Enqueue("closet", 2);


        string expectedResult = priorityQueue.Dequeue();

        Assert.AreEqual("desk", expectedResult);
    }
}