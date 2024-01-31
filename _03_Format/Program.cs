class Program
{
    static void Main(string[] args)
    {
        // Числовое значение для форматирования
        double number = 12345.6789;

        // Форматирование как валюту
        Console.WriteLine("Currency: " + string.Format("{0:C}", number)); // $12,345.68
        Console.WriteLine($"Currency: {number:C}"); // $12,345.68

        // Форматирование как десятичное число
        Console.WriteLine("Decimal: " + string.Format("{0:D}", (int)number)); // 12345

        // Форматирование в экспоненциальной форме
        Console.WriteLine("Exponential: " + string.Format("{0:E}", number)); // 1.234568E+004

        // Форматирование как число с фиксированной точкой
        Console.WriteLine("Fixed-point: " + string.Format("{0:F2}", number)); // 12345.68

        // Общий формат (автоматически выбирает между E и F)
        Console.WriteLine("General: " + string.Format("{0:G}", number)); // 12345.6789

        // Форматирование с разделителями разрядов и знаками
        Console.WriteLine("Number with commas: " + string.Format("{0:N}", number)); // 12,345.68

        // Форматирование как процент
        Console.WriteLine("Percent: " + string.Format("{0:P}", 0.123)); // 12.30%

        // Форматирование как шестнадцатеричное число
        Console.WriteLine("Hexadecimal: " + string.Format("{0:X}", 255)); // FF
        
        // Начиная с C# версии 6.0 можно использовать (Интерполяция)
        // Console.WriteLine($"Currency: {number:C}");
        // Console.WriteLine($"Decimal: {12345:D}");
        // Console.WriteLine($"Exponential: {number:E}");
        // Console.WriteLine($"Fixed-point: {number:F2}");
        // Console.WriteLine($"General: {number:G}");
        // Console.WriteLine($"Number with commas: {number:N}");
        // Console.WriteLine($"Percent: {0.123:P}");
        // Console.WriteLine($"Hexadecimal: {255:X}");
    }
}