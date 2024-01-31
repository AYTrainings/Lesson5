using System.Text;

class Program
{
    static void Main(string[] args)
    {
        {
            // Класс StringBuilder находится в пространстве имен System.Text. Этот класс представляет
            // динамическую строку.
            // При создании строки StringBuilder выделяет памяти больше, чем необходимо этой строке:
            //StringBuilder sb = new StringBuilder("Привет мир");
            //Console.WriteLine($"Длина строки: {sb.Length}");
            //Console.WriteLine($"Емкость строки: {sb.Capacity}");
        }
        {
            //StringBuilder sb = new StringBuilder("Название: ");
            //Console.WriteLine($"Длина строки: {sb.Length}"); // 10
            //Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 16
            //sb.Append(" Руководство");
            //Console.WriteLine($"Длина строки: {sb.Length}"); // 22
            //Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32
            //sb.Append(" по C#");
            //Console.WriteLine($"Длина строки: {sb.Length}"); // 28
            //Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32

        }

        {
            var sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            // заменяем слово
            sb.Replace("мир", "world");
            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            // получаем строку из объекта StringBuilder
            string s = sb.ToString();
            Console.WriteLine(s);
        }
    }
}