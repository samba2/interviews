/*
### Requirement 1
Complete the `reverse` method on the `String` class. You are not allowed to use built-in methods. 

### Requirement 2
Refactor the `reverse` method from requirement 1 in order to cater for special characters. Special characters should remain in their
place. Only non-special characters should be reversed. There is no need to implement the special character check. This has already 
been implemented for you in the `isSpecialCharacter` method.
*/

using NUnit.Framework;

namespace Tests.Reverse
{
    public class MyString
    {
        private static bool IsSpecialCharacter(char character) 
            => !(char.IsWhiteSpace(character) | char.IsLetterOrDigit(character));

        public static string Reverse(string input)
        {
            // Complete me
            return "";
        }
    }

    [TestFixture]
    public class ReverseString
    {
        [Test]
        public void TestRequirement1()
        {
            const string name = "James";
            var reversedName = MyString.Reverse(name);

            Assert.AreEqual("semaJ", reversedName);
        }

        [Test]
        public void TestRequirement2A()
        {
            const string name = "J@me$";
            var reversedName = MyString.Reverse(name);

            Assert.AreEqual("e@mJ$", reversedName);
        }

        [Test]
        public void TestRequirement2B()
        {
            const string name = "J@m3$ 3ond!";
            var reversedName = MyString.Reverse(name);
            Assert.AreEqual("d@no$3 3mJ!", reversedName);
        }

        [Test]
        public void TestRequirement2C()
        {
            const string name = "J[a]me$s %Bo$nd% I^I*I";
            var reversedName = MyString.Reverse(name);
            Assert.AreEqual("I[I]I $dn%oB$ s%em^a*J", reversedName);
        }
    }
}