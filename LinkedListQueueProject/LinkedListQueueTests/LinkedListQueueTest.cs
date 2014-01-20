using LinkedListQueueProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LinkedListQueueTests
{

    [TestClass()]
    public class LinkedListQueueTest
    {


        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void LinkedListQueueConstructorTest()
        {
            LinkedListQueue target = new LinkedListQueue();
        }

        [TestMethod()]
        public void EnqueueShouldTakeANode()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node newNode = new Node();
            target.Enqueue(newNode);
        }

        [TestMethod()]
        public void TailShouldReturnLastNodeInQueue()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node newNode = new Node();
            target.Enqueue(newNode);
            Node expected = newNode;
            Node actual = target.Tail();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EnqueueShouldAddPreviousTailToNewTailsNextNode()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node nodeOne = new Node();
            Node nodeTwo = new Node();
            target.Enqueue(nodeOne);
            target.Enqueue(nodeTwo);
            Node expected = nodeOne;
            Node actual = nodeTwo.GetNextNode();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DequeueShouldReturnHeadNode()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node firstNode = new Node();
            target.Enqueue(firstNode);
            Node expected = firstNode;
            Node actual = target.Dequeue();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HeadMethodShouldReturnHeadNode()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node firstNode = new Node();
            target.Enqueue(firstNode);
            Node expected = firstNode;
            Node actual = target.Head();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DequeueShouldCreateNewHeadNode()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node firstNode = new Node();
            Node secondNode = new Node(firstNode);
            Node thirdNode = new Node(secondNode);
            target.Enqueue(firstNode);
            target.Enqueue(secondNode);
            target.Enqueue(thirdNode);
            target.Dequeue();
            Node expected = secondNode;
            Node actual = target.Head();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindShouldReturnDesiredNode()
        {
            LinkedListQueue target = new LinkedListQueue();
            Node firstNode = new Node("First");
            Node secondNode = new Node("Second");
            Node thirdNode = new Node("Third");
            Node fourthNode = new Node("Fourth");
            target.Enqueue(firstNode);
            target.Enqueue(secondNode);
            target.Enqueue(thirdNode);
            target.Enqueue(fourthNode);
            Node actual = target.Find("Second");
            Node expected = secondNode;
            Assert.AreEqual(expected, actual);
        }
    }
}
