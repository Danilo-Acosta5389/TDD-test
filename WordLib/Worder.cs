namespace WordLib
{

    public class Worder
    {
        //Method that counts amount of letters in input string
        public int CountLetters(string input)
        {
            char[] stringArray = input.ToCharArray();
            if (input == "")
                throw new ArgumentException("Please input word");
            else
                return stringArray.Count();
        }

        //Method that checks if input is a palindrome
        public bool IsPalindrome(string input)
        {
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);

            if (input == "") 
                throw new ArgumentException("Please input word");
            else 
                return input == reversedStr ? true : false;
        }

        //Method that returns output input string backwards
        public string Palindrome(string input)
        {
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            if (input == "")
                throw new ArgumentException("Please input word");
            else 
                return reversedStr;
        }
    }
}