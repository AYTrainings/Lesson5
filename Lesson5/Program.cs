using System.Text;

namespace Lesson5
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
            Console.WriteLine(symbol1);
            Console.WriteLine(symbol2);
            Console.WriteLine(symbol3);

            // Управляющие последовательности
            char symbol4 = '\n'; // - перевод строки
            char symbol5 = '\t'; // - табуляция
            char symbol6 = '\\'; //- обратный слеш

            // Шестнадцатеричные коды ASCII
            char symbol7 = '\x78'; // - x
            char symbol8 = '\x5A'; // - Z
            Console.WriteLine(symbol7);
            Console.WriteLine(symbol8);

            // Коды из таблицы символов Unicode
            char symbol9 = '\u0420'; // - P
            char symbol10 = '\u0421'; // - C
            Console.WriteLine(symbol9);
            Console.WriteLine(symbol10);

            #endregion

            #region Methods

            

            #endregion
        }
    }
}
