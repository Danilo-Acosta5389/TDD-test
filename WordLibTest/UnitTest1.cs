using WordLib;

namespace WordLibTest
{
    [TestClass]
    public class UnitTest1
    {
        /* Skriv 2 tester. ett om funk anropas med "radar" -> true
         * "boat" -> false
         * "" -> throw 
         */
        

        //Test to reverse word and matching with the word in expectedResult
        [TestMethod]
        public void TestPalindrome_whenGivenAWord_returnsWordReversed()
        {
            //Creating instance of a test
            Worder worder = new Worder();

            //Define test input and output value:
            string input = "boat";
            string palindrom = worder.Palindrome(input);

            // Verify the result:
            string expectedResult = "taob";
            Assert.AreEqual(palindrom, expectedResult);

        }

        //Checks if input is palindrom and returns true if it is.
        [TestMethod]
        public void TestPalindrom_whenGivenAWord_returnsTrue_IfIsPalindrom()
        {
            //Creating instance of a test
            Worder worder = new Worder();

            //Define test input and output value:
            string input = "radar";
            bool palindrom = worder.IsPalindrome(input);

            // Verify the result:
            bool expectedResult = true;
            Assert.AreEqual(palindrom, expectedResult);  
        }

        //Checks if input is palindrom and returns false if it is not.
        [TestMethod]
        public void TestPalindrom_whenGivenAWord_returnsFalse_IfIsNotPalindrom()
        {
            //Creating instance of a test
            Worder worder = new Worder();

            //Define test input and output value:
            string input = "boat";
            bool palindrom = worder.IsPalindrome(input);

            // Verify the result:
            bool expectedResult = false;
            Assert.AreEqual(palindrom, expectedResult);
        }

        [TestMethod]
        public void CountLettersInWord() 
        {
            Worder worder = new Worder();
            string input = "Kalle";
            int count = worder.CountLetters(input);
            Assert.IsTrue(count > 0);
        }
    }
}