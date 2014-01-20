using LinkedListQueueProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LinkedListQueueTests
{

    [TestClass()]
    public class NodeTest
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
        public void ShouldBeAbleToCreateNodes()
        {
            Node target = new Node();
        }

        [TestMethod()]
        public void ShouldBeAbleToCreateNodesWithNames()
        {
            Node target = new Node("Jacob");
        }

        [TestMethod()]
        public void GetNameShouldReturnAName()
        {
            Node target = new Node("Jacob");
            string actual = target.GetName();
            string expected = "Jacob";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetNamesShouldChangeTheName()
        {
            Node target = new Node("Jacob");
            target.SetName("George");
            string actual = target.GetName();
            string expected = "George";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShouldBeAbleToCreateNodesWithNextNodes()
        {
            Node nodeOne = new Node("Jacob");
            Node nodeTwo = new Node("George", nodeOne);
            Node nodeThree = new Node(nodeTwo);
        }

        [TestMethod()]
        public void ShouldBeAbleToGetAndSetNextNode()
        {
            Node nodeOne = new Node();
            Node target = new Node(nodeOne);
            Node expected = nodeOne;
            Node actual = target.GetNextNode();
            Assert.AreEqual(expected, actual);
            Node newNode = new Node("Emily");
            target.SetNextNode(newNode);
            expected = newNode;
            actual = target.GetNextNode();
            Assert.AreEqual(expected, actual);
        }

    }
}
