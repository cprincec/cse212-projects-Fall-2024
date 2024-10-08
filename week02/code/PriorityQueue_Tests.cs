using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following values and priority: Study (3), Eat (2), Sleep (5) and
    // run
    // Expected Result: [Study (Pri: 3), Eat (Pri: 2), Sleep (Pri: 5)]
    // Defect(s) Found: The Enqueue method adds priority items to the back of the queue. No defect found
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Study", 3);
        priorityQueue.Enqueue("Eat", 2);
        priorityQueue.Enqueue("Sleep", 5);

        Assert.AreEqual(priorityQueue.ToString(), "[Study (Pri:3), Eat (Pri:2), Sleep (Pri:5)]");
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and priority: Study (5), Eat (3), Sleep (2) and
    // run 3 times
    // Expected Result: Study, Eat, Sleep
    // Defect(s) Found: The Dequeue method only returns but does not remove items from the queue
    public void TestPriorityQueue_2()
    {
        PriorityItem study = new PriorityItem("Study", 5);
        PriorityItem eat = new PriorityItem("Eat", 3);
        PriorityItem sleep = new PriorityItem("Sleep", 2);

        PriorityItem[] expectedresults = [study, eat, sleep];


        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(study.Value, study.Priority);
        priorityQueue.Enqueue(eat.Value, eat.Priority);
        priorityQueue.Enqueue(sleep.Value, sleep.Priority);

        for (int i = 0; i < 3; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedresults[i].Value, value);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and priority: Study (3), Eat (2), Sleep (5) and
    // run 3 times
    // Expected Result: Sleep, Study, Eat
    // Defect(s) Found: The Dequeue method does not return item with the highest priority from the queue.
    //                  It just returns the first item put in the queue regardless of its priority.
    public void TestPriorityQueue_3()
    {
        PriorityItem study = new PriorityItem("Study", 3);
        PriorityItem eat = new PriorityItem("Eat", 2);
        PriorityItem sleep = new PriorityItem("Sleep", 5);

        PriorityItem[] expectedresults = [sleep, study, eat];


        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(study.Value, study.Priority);
        priorityQueue.Enqueue(eat.Value, eat.Priority);
        priorityQueue.Enqueue(sleep.Value, sleep.Priority);

        for (int i = 0; i < 3; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedresults[i].Value, value);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and negative priority: Study (-3), Eat (-2), Sleep (-5) and
    // run 3 times
    // Expected Result: Eat, Study, Sleep
    // Defect(s) Found: The Dequeue method  does not return the item with hightest priority for items with negative priority.
    public void TestPriorityQueue_4()
    {
        PriorityItem study = new PriorityItem("Study", -3);
        PriorityItem eat = new PriorityItem("Eat", -2);
        PriorityItem sleep = new PriorityItem("Sleep", -5);

        PriorityItem[] expectedresults = [eat, study, sleep];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(study.Value, study.Priority);
        priorityQueue.Enqueue(eat.Value, eat.Priority);
        priorityQueue.Enqueue(sleep.Value, sleep.Priority);

        for (int i = 0; i < 3; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedresults[i].Value, value);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and priority: Study (2), Eat (1), Sleep (2) and
    // run 3 times
    // Expected Result: Study, Sleep, Eat
    // Defect(s) Found: The Dequeue method does not return items with same priority on FIFO basis. When two items with
    //                  the same priority are added to the queue the dequeue method returns the last of the two items added to the queue.
    public void TestPriorityQueue_5()
    {
        PriorityItem study = new PriorityItem("Study", 2);
        PriorityItem eat = new PriorityItem("Eat", 1);
        PriorityItem sleep = new PriorityItem("Sleep", 2);

        PriorityItem[] expectedresults = [study, sleep, eat];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(study.Value, study.Priority);
        priorityQueue.Enqueue(eat.Value, eat.Priority);
        priorityQueue.Enqueue(sleep.Value, sleep.Priority);

        for (int i = 0; i < 3; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedresults[i].Value, value);
        }
    }


    [TestMethod]
    // Scenario: Try to dequeue an item from an empty queue
    // Expected Result: An Exception should be shown with error message indicating empty queue 
    // Defect(s) Found: The Dequeue method does not return items with same priority on FIFO basis. When two items with
    //                  the same priority are added to the queue the dequeue method returns the last of the two items added to the queue.
    public void TestPriorityQueue_6()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            var value = priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}










































































