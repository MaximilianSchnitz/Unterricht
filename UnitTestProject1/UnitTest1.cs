using LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_Add_First_Recursive()
        {
            var list = new LListR<int>();
            list.Add(0);

            int result = list.first.value;

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_Add_Last_Recursive()
        {
            var list = new LListR<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);

            int result = list.first.next.next.value;

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_Count_Recursive()
        {
            var list = GenerateLListR();

            int result = list.Count;

            Assert.AreEqual(5, result);
        }

        public void Test_Remove_First_Recursive()
        {
            var list = GenerateLListR();

            list.Remove(0);
            int result = list.first.value;

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_Remove_Empty_Recursive()
        {
            var list = GenerateLListR();
            
            list.Remove(10);
        }

        [TestMethod]
        public void Test_Indexer_First_Recursive()
        {
            var list = GenerateLListR();

            int result = list[0];

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_Indexer_Last_Recursive()
        {
            var list = GenerateLListR();

            int result = list[4];

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test_Indexer_Out_Of_Range_Recursive()
        {
            var list = GenerateLListR();

            int result = list[10];
        }

        LListR<int> GenerateLListR()
        {
            var list = new LListR<int>();
            for(int i = 0; i < 5; i++)
                list.Add(i);

            return list;
        }

    }
}
