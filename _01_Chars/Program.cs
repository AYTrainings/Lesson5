namespace _01_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chars

            // System.Char (char) - Хранит одиночный символ в кодировке Unicode и занимает 2 байта.Этому типу соответствуют
            //символьные литералы:

            // Обычные символы:
            char symbol1 = '2';
            char symbol2 = 'A';
            char symbol3 = 'T';
            // Console.WriteLine(symbol1);
            // Console.WriteLine(symbol2);
            // Console.WriteLine(symbol3);

            // Управляющие последовательности
            char symbol4 = '\n'; // - перевод строки
            char symbol5 = '\t'; // - табуляция
            char symbol6 = '\\'; //- обратный слеш

            // Шестнадцатеричные коды ASCII
            char symbol7 = '\x78'; // - x
            char symbol8 = '\x5A'; // - Z
            // Console.WriteLine(symbol7);
            // Console.WriteLine(symbol8);

            // Коды из таблицы символов Unicode
            char symbol9 = '\u0420'; // - P
            char symbol10 = '\u0421'; // - C
            // Console.WriteLine(symbol9);
            // Console.WriteLine(symbol10);

            #endregion

            #region Char methods

            // GetNumericValue
            // Возвращает численное значение символа, если он является цифрой, и (-1) в противном случае
            var numericValue9 = Char.GetNumericValue('9'); // == 9
            var numericValueB = Char.GetNumericValue('B'); // == -1
            // Console.WriteLine(numericValueA);
            // Console.WriteLine(numericValueB);

            // GetUnicodeCategory
            // Все символы разделены на категории. Метод возвращает Unicode категорию символа.
            var unicodeCategory9 = Char.GetUnicodeCategory('9'); // == DecimalDigitNumber
            var unicodeCategoryA = Char.GetUnicodeCategory('A'); // == UppercaseLetter
            // Console.WriteLine(unicodeCategory9);
            // Console.WriteLine(unicodeCategoryA);

            // IsControl
            // Возвращает true, если символ является управляющим
            var isControl9 = Char.IsControl('9'); // == false
            var isControlN = Char.IsControl('\n'); // == true
            // Console.WriteLine(isControl9);
            // Console.WriteLine(isControlN);

            // IsDigit
            // Возвращает true, если символ является десятичной цифрой
            var isDigit9 = Char.IsDigit('9'); // == true
            var isDigitA = Char.IsDigit('A'); // == false
            // Console.WriteLine(isDigit9);
            // Console.WriteLine(isDigitA);

            // IsLetter
            // Возвращает true, если символ является буквой
            var isLetter9 = Char.IsLetter('9'); // == false
            var isLetterA = Char.IsLetter('A'); // == true
            // Console.WriteLine(isLetter9);
            // Console.WriteLine(isLetterA);

            // IsLetterOrDigit
            // Возвращает true, если символ является буквой или цифрой
            var isLetterOrDigit9 = Char.IsLetterOrDigit('9'); // == true
            var isLetterOrDigitA = Char.IsLetterOrDigit('A'); // == true
            var isLetterOrDigitN = Char.IsLetterOrDigit('\n'); // == false
            // Console.WriteLine(isLetterOrDigit9);
            // Console.WriteLine(isLetterOrDigitA);
            // Console.WriteLine(isLetterOrDigitN);

            // IsLower
            // Возвращает true, если символ задан в нижнем регистре
             Console.WriteLine(Char.IsLower('A'));  // == false
             Console.WriteLine(Char.IsLower('b'));  // == true

            // IsUpper
            // Возвращает true, если символ задан в верхнем регистре
            Console.WriteLine(Char.IsUpper('A'));  // == true
            Console.WriteLine(Char.IsUpper('b'));  // == false

            // IsNumber
            // Возвращает true, если символ является числом (десятичной или шестнадцатеричной цифрой)
            Console.WriteLine(Char.IsNumber('A'));  // == false
            Console.WriteLine(Char.IsNumber('9'));  // == true

            // IsPunctuation
            // Возвращает true, если символ является знаком препинания
            Console.WriteLine(Char.IsPunctuation(';'));  // == true
            Console.WriteLine(Char.IsPunctuation('9'));  // == false

            // IsSeparator
            // Возвращает true, если символ является разделителем
            Console.WriteLine(Char.IsSeparator(' '));  // == true
            Console.WriteLine(Char.IsSeparator('\u1680'));  // == true ( )
            Console.WriteLine(Char.IsSeparator('W'));  // == false

            // IsSurrogate
            // Некоторые символы Unicode с кодом в интервале [0x1000, 0x10FFF] представляются двумя
            // 16-битными "суррогатными" символами. Метод возвращает true, если символ является суррогатным
            // == true ("𝄞", "𝑎", и т.д.)
            Console.WriteLine(Char.IsSurrogate('W'));  // == false

            // IsWhiteSpace
            // Возвращает true, если символ является "белым пробелом". К белым пробелам, помимо
            // пробела, относятся и другие символы, например, символ конца строки и символ перевода каретки
            Console.WriteLine(Char.IsWhiteSpace('\n'));  // == true
            Console.WriteLine(Char.IsWhiteSpace(' '));  // == true
            Console.WriteLine(Char.IsWhiteSpace('a'));  // == false

            // Parse
            // Преобразует строку в символ. Естественно, строка должна состоять из одного символа,
            // иначе возникнет ошибка
            string str = "B";
            char charB = Char.Parse(str);
            // Console.WriteLine(charB);

            // ToLower
            // Приводит символ к нижнему регистру
            Console.WriteLine(Char.ToLower('A'));  // == a
            Console.WriteLine(Char.ToLower('M'));  // == m
            Console.WriteLine(Char.ToLower('b'));  // == b
            Console.WriteLine(Char.ToLower('\n')); // == '\n'

            // ToUpper
            // Приводит символ к верхнему регистру
            Console.WriteLine(Char.ToUpper('A'));  // == A
            Console.WriteLine(Char.ToUpper('M'));  // == M
            Console.WriteLine(Char.ToUpper('b'));  // == B
            Console.WriteLine(Char.ToUpper('\n')); // == '\n'

            // MaxValue, MinValue
            // Свойства, возвращающие символы с максимальным и минимальным кодом.
            // Возвращаемые символы не имеют видимого образа
            char max = Char.MaxValue;
            char min = Char.MinValue;

            Console.WriteLine($"MIN: {min}, MAX: {max}");

            #endregion

            #region Array

            //char[] letters = { 'П', 'р', 'и', 'в', 'е', 'т', ',', ' ', 'М', 'и', 'р' };
            //for (var i = 0; i < letters.Length; i++)
            //{
            //    Console.Write(letters[i]);
            //}

            //Console.WriteLine();

            //// Можно изменить
            //letters[1] = letters[2] = letters[3] = 'W';
            //for (var i = 0; i < letters.Length; i++)
            //{
            //    Console.Write(letters[i]);
            //}
            
            #endregion
        }
    }
}