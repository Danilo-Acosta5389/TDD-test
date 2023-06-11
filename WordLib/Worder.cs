namespace WordLib
{

    public class Worder
    {
        public int CountLetters(string input)
        {
            char[] stringArray = input.ToCharArray();
            if (input == "")
                throw new ArgumentException("Please input word");
            else
                return stringArray.Count();
        }

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