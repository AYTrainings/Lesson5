namespace _02_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Инициализация

            // Простая инициализация
            string myString = "Hi!!!";
            string myString01 = string.Empty;
            string myString02 = null;
            
            // Через конструктор из массива символов
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            string myString2 = new string(letters); // == "ABCDEFG"
            
            // Через перегрузки конструкторов
            string myString3 = new string('-', 10); // == "----------"
            Console.WriteLine(new string('-', 10));

            string myString4 = new string(letters, 2, 3); // == "CDE"

            #endregion

            #region Индексы

            string s1 = "hello";
            char ch1 = s1[1]; // Символ 'e'
                              // s1[1] = '5'; - ОШИБКА
            Console.WriteLine(ch1);
            Console.WriteLine(s1.Length);

            #endregion

            #region Форматирование

             string name = "Ivan";
             int age = 20;
             string output = String.Format("Имя: {0} Возраст: {1}", name, age);
             //Console.WriteLine(output);

            string hello = "Hello";
            string world = "world";
            string result = hello + " " + world + "!";
            string resultFormat = string.Format("{0} {1}!", hello, world);
            string resultFormat2 = $"{hello} {world}!"; // C# 6.0 +

            // Настраиваемые форматы
            long number = 375331122512;
            string strResult = String.Format("{0:+### (##) ###-##-##}", number);
            // Console.WriteLine(strResult); // +1 (987) 654-32-10
            
            #endregion
        }
    }
}