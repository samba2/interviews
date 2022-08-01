using NUnit.Framework;
using Tests.Reverse;

namespace Tests.Words
{
    public static class WordCount
    {
        public static int Count(string sentence)
        {
            //COMPLETE ME
            return 0;
        }
    }
    
    [TestFixture]
    public class WordCountTests
    {
        [Test]
        public void Test1()
        {
            const string sentence = "How many eggs are in a half-dozen, 13?";
            var count = WordCount.Count(sentence);

            Assert.AreEqual(7, count);
        }

        [Test]
        public void Test2()
        {
            const string sentence = "He is a good programmer, he  won 865 competitions, but sometimes he dont. What do you think? All test-cases should pass. Done-done";
            var count = MyString.Reverse(sentence);

            Assert.AreEqual(21, count);
        }
    }
}