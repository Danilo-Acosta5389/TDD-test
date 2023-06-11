namespace WordLib
{

    public class Worder
    {
        public int CountLetters(string input)
        {
            char[] stringArray = input.ToCharArray();
            return stringArray.Count();
        }

        public bool IsPalindrome(string input)
        {
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            return input == reversedStr ? true : false;
        }

        public string Palindrome(string input)
        {
            //throw new NotImplementedException();
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            return reversedStr;
        }
    }
}