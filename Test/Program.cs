class Program
{
    static void Main(string[] args)
    {
        #region Задание 1

        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers[2]);
        }

        #endregion

        #region Задание 2

        {
            //string message = "Hello";
            //Console.WriteLine(message[1]);
        }

        #endregion

        #region Задание 3

        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //numbers[2] = 10;
            //Console.WriteLine(numbers[2]);
        }

        #endregion

        #region Задание 4

        {
            //string[] names = { "Alice", "Bob", "Charlie" };
            //Console.WriteLine(names.Length);
        }
         
        #endregion

        #region Задание 5

        {
            //string firstName = "John";
            //string lastName = "Doe";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);
        }

        #endregion

        #region Задание 6

        {
            //string str1 = "hello";
            //string str2 = "Hello";
            //Console.WriteLine(str1 == str2);
        }

        #endregion

        #region Задание 7

        {
            //string names = "Alice,Bob,Charlie";
            //string[] nameArray = names.Split(',');
            //Console.WriteLine(string.Join(", ", nameArray));
        }

        #endregion

        #region Задание 8

        {
            //string[] colors = { "Red", "Green", "Blue" };
            //string joinedColors = string.Join("-", colors);
            //Console.WriteLine(joinedColors);
        }

        #endregion

        #region Задание 9

        {
            //string message = "Hello, World!";
            //string substring = message.Substring(7, 5);
            //Console.WriteLine(substring);
        }

        #endregion

        #region Задание 10

        {
            string sentence = "C# is a powerful language.";
            int index = sentence.IndexOf("powerful");
            // Console.WriteLine(index);
        }

        #endregion

        #region Задание 11

        {
            string text = "The quick brown fox jumps over the lazy dog.";
            string replacedText = text.Replace("fox", "cat");
            // Console.WriteLine(replacedText);
        }

        #endregion

        #region Задание 12

        {
            //string message = "Hello World";
            //Console.WriteLine(message.ToLower());
            //// Console.WriteLine(message.ToUpper());

            //var result = $"{Char.ToLower(message[0])}{message.Substring(1)}";
            //Console.WriteLine(result);
        }

        #endregion

        #region Задание 13

        {
            string dirtyString = "   Clean me!   ";
            string cleanedString = dirtyString.Trim();
            //Console.WriteLine(cleanedString);
        }

        #endregion

        #region Задание 14

        {
            string sentence = "C# is fun!";
            //Console.WriteLine(sentence.Contains("Fun"));
        }

        #endregion

        #region Задание 15

        {
            //string word = "example";
            //Console.WriteLine(word[2]);
        }

        #endregion

        #region Задание 16

        {
            double number = 42.475;
            string result = "The answer is " + number;
            // Console.WriteLine(result);
        }

        #endregion

        #region Задание 17

        {
            string sentence = "This is a long sentence.";
            string lastWord = sentence.Substring(sentence.LastIndexOf(" ") + 1);
            //Console.WriteLine(lastWord);
        }

        #endregion

        #region Задание 18

        {
            string word = "reverse";
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            //Console.WriteLine(new string(charArray));
        }

        #endregion

        #region Задание 19

        {
            int[] numbers = { 5, 2, 8, 1, 9 };
            int minValue = numbers.Max();
            //Console.WriteLine(minValue);
        }

        int GetSomething(){
            return 0;
        }

        #endregion
    }
}