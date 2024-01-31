class Program
{
    static void Main(string[] args)
    {
        #region Объединение

        // // Как объеденить строки?
        // string str1 = "hello";
        // string str2 = "world";
        
        // string str3 = str1 + str2;
        // string str4 = string.Format("{0}{1}", str1, str2);
        // string str5 = $"{str1}{str2}";
        // string str6 = string.Concat(str1, " ", str2);
        
        // string[] strArray =
        // {
        //     "hello",
        //     "world"
        // };
        // string str7 = string.Join(".", strArray);
        //Console.WriteLine(str7);

        #endregion

        #region Сравнение

        {
            //string s1 = "Hello!";
            //string s2 = "Hello!";
            //Console.WriteLine(s1 == s2);

            var isStringEqual = string.Equals("Hello!", "hello!", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isStringEqual);
        }

        {
            // Так же можно найти индекс первого совпадения символа
            string s1 = "hello world";
            char ch = 'o';
            int indexOfChar = s1.IndexOf(ch); // равно 4
            Console.WriteLine(indexOfChar);

            // И подстроки
            string subString = "wor";
            int indexOfSubstring = s1.IndexOf(subString); // равно 6
            Console.WriteLine(indexOfSubstring);
        }

        {
            string str = "MyMail@gmail.com";
            Console.WriteLine(str.StartsWith("MyMail")); // TRUE
            Console.WriteLine(str.EndsWith(".com")); // TRUE
        }

        // Метод Substring получает подстроку из строки (обрезает)
        {
            string text = "Хороший день";
            // обрезаем начиная с третьего символа
            text = text.Substring(2);
            // результат "роший день"
            Console.WriteLine(text);
            // обрезаем сначала до последних двух символов
            text = text.Substring(0, text.Length - 2);
            // результат "роший де"
            Console.WriteLine(text);
        }

        #endregion
    }
}