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
    /*
     *A sentence is made up of a group of words. Each word is a sequence of letters [“a-z”, “A-Z”],
     * that may contain one or more hyphens and may end in a punctuation mark: period (.), comma (,), question mark (?) or exclamation mark (!).
     * Words will be separated by one or more white spaces. Hyphens joining two words into one and should be retained while the other punctuation marks should be stripped.
     * Determine the number of words in a given sentence
     */
    
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