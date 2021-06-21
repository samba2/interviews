/*

### Requirement 1
Complete the `reverse` method on the `String` class. You are not allowed to use built-in methods. 

### Requirement 2
Refactor the `reverse` method from requirement 1 in order to cater for special characters. Special characters should remain in their
place. Only non-special characters should be reversed. There is no need to implement the special character check. This has already 
been implemented for you in the `isSpecialCharacter` method.

*/

namespace Tests
{
    public class String
    {
        static bool isSpecialCharacter(char c)
        {
            return !(char.IsWhiteSpace(c) | char.IsLetterOrDigit(c));
        }

        public static string reverse(string s)
        {
            // Complete me
            return "";
        }
    }

    public class ReverseStringTests
    {
        [TestMethod]
        public void TestRequirement1()
        {
            var name = "James";
            var reversedName = String.reverse(name);

            Assert.AreEqual("semaJ", reversedName);
        }

        [TestMethod]
        public void TestRequirement2a()
        {
            var name = "J@me$";
            var reversedName = String.reverse(name);

            Assert.AreEqual("e@mJ$", reversedName);
        }

        [TestMethod]
        public void TestRequirement2b()
        {
            var name = "J@m3$ 3ond!";
            var reversedName = String.reverse(name);
            Assert.AreEqual("d@no$3 3mJ!", reversedName);
        }

        [TestMethod]
        public void TestRequirement2c()
        {
            var name = "J[a]me$s %Bo$nd% I^I*I";
            var reversedName = String.reverse(name);
            Assert.AreEqual("I[I]I $dn%oB$ s%em^a*J", reversedName);
        }
    }
}
