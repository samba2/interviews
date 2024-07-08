/*
 * A sentence is made up of a group of words. Each word is a sequence of letters [“a-z”, “A-Z”],
 * that may contain one or more hyphens and may end in a punctuation mark: period (.), comma (,), question mark (?) or exclamation mark (!).
 * Words will be separated by one or more white spaces. Hyphens joining two words into one and should be retained while the other punctuation marks should be stripped.
 * Determine the number of words in a given sentence
 */

package org.sometests;

import org.junit.Assert;
import org.junit.Test;

public class WordCountTest {

    public static class WordCount {

        public static int count(String sentence) {
            return 0;
        }
    }

    @Test
    public void test1() {
        String sentence = "How many eggs are in a half-dozen, 13?";
        int count = WordCount.count(sentence);

        Assert.assertEquals(7, count);
    }

    @Test
    public void test2() {
        String sentence = "She is a good programmer, she won 865 competitions, but sometimes she isnt. What do you think? All test-cases should pass. Done-done";
        int count = WordCount.count(sentence);

        Assert.assertEquals(21, count);
    }
}
