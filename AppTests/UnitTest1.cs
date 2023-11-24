namespace AppTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // тесты на метод GetByID()

        [TestCase(1)]
        public void TestGetByIdCorrect_Name(int i)
        {
            var expect = "lol";
            var actual = DB.GetByID(i);
            Assert.That(actual.Item[2], Is.EqualTo(expect1));
        }        
        [TestCase(1)]
        public void TestGetByIdCorrect_Msg(int i)
        {
            var expect2 = "kek";
            var actual = DB.GetByID(i);
            Assert.That(actual.Item[3], Is.EqualTo(expect2));
        }
        [TestCase(-1)]
        public void TestGetByIdInCorrect_Msg(int i)
        {
            var actual = DB.GetByID(i);
            Assert.That(actual, Is.EqualTo(null));
        }
        [TestCase(-1)]
        public void TestGetByIdInCorrect_Name(int i)
        {
            var actual = DB.GetByID(i);
            Assert.That(actual, Is.EqualTo(null));
        }

        // GetByName()

        [TestCase(lol)]
        public void TestGetByNameCorrect_Id(string name)
        {
            var expect = 1;
            var actual = DB.GetByName(name);
            Assert.That(actual.Item[1], Is.EqualTo(expect));
        }
        
        [TestCase(lol)]
        public void TestGetByNameCorrect_Msg(string name)
        {
            var expect = "kek";
            var actual = DB.GetByName(name);
            Assert.That(actual.Item[3], Is.EqualTo(expect));
        }

        [TestCase("")]
        public void TestGetByName_Null_Id(string name)
        {
            var actual = DB.GetByName(name);
            Assert.That(actual.Item[1], Is.EqualTo(null));
        }

        [TestCase("")]
        public void TestGetByName_Null_Msg(string name)
        {
            var actual = DB.GetByName(name);
            Assert.That(actual.Item[3], Is.EqualTo(null));
        }

        // Add()

        [Test]
        public void TestAdd_New_Id()
        {
            DB.Add(18, "aaa", "bbb");
            var expect = DB.GetById(18);
            Assert.AreEqual(expect.Item[2], "aaa");
        }

        [Test]
        public void TestAdd_Old_Id()
        {
            DB.Add(1, "aaa", "bbb");
            var expect = DB.GetById(1);
            Assert.AreNotEqual(expect.Item[2], "aaa");
        }

        // Update()

        [Test]
        public void TestUpdate_Correct()
        {
            DB.Update(1, "aaa");
            var expect = DB.GetById(1);
            Assert.AreEqual(expect.Item[3], "aaa");
        }
        [Test]
        public void TestUpdate_InCorrectId()
        {
            DB.Update(28, "aaa");
            var expect = DB.GetById(28);
            Assert.AreEqual(expect.Item[3], "aaa");
        }

        // Delete()

        [Test]
        public void TestDelete_Correct()
        {
            DB.Delete(1);
            Assert.AreEqual(expect, null);
        }

        [Test]
        public void TestUpdate_InCorrect()
        {
            DB.Delete(1);
            Assert.AreEqual(expect, null);
        }
    }
}