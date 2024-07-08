/*
### Requirement 1
Complete the `reverse` method on the `String` class. You are not allowed to use built-in methods. 

### Requirement 2
Refactor the `reverse` method from requirement 1 in order to cater for special characters. Special characters should remain in their
place. Only non-special characters should be reversed. There is no need to implement the special character check. This has already 
been implemented for you in the `isSpecialCharacter` method.
*/

package org.sometests;

import org.junit.Assert;
import org.junit.Test;

public class ReverseStringTest {

    public static class MyString {

        private static boolean isSpecialCharacter(char character) {
            return !(Character.isWhitespace(character) || Character.isLetterOrDigit(character));
        }

        public static String reverse(String input) {
            // Complete me
            return "";
        }
    }

    @Test
    public void testRequirement1() {
        var name = "James";
        var reversedName = ReverseStringTest.MyString.reverse(name);
        Assert.assertEquals("semaJ", reversedName);
    }

    @Test
    public void testRequirement2A() {
        var name = "J@me$";
        var reversedName = ReverseStringTest.MyString.reverse(name);
        Assert.assertEquals("e@mJ$", reversedName);
    }

    @Test
    public void testRequirement2B() {
        var name = "J@m3$ 3ond!";
        var reversedName = ReverseStringTest.MyString.reverse(name);
        Assert.assertEquals("d@no$3 3mJ!", reversedName);
    }

    @Test
    public void testRequirement2C() {
        var name = "J[a]me$s %Bo$nd% I^I*I";
        var reversedName = ReverseStringTest.MyString.reverse(name);
        Assert.assertEquals("I[I]I $dn%oB$ s%em^a*J", reversedName);
    }
}
