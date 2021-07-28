using NUnit.Framework;
using minipro1;

namespace test123
{
    [TestFixture]
    public class tests
    {
       
        public class UnitTest1
        {
            Class1 obj = new Class1();
            [Test]

            public void TestAdd()
            {
                int actual = obj.Add(4, 5);
                Assert.AreEqual(9, actual);
            }
        }

       
 
    }
}