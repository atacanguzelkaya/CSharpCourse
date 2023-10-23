class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        bool condition = false; // true false
        char character = 'A';

        int number1 = 2147483647; // +- 2147483647
        long number2 = 9223372036854775807; // +- 9223372036854775807
        short number3 = 32767; // +- 32767
        byte number4 = 255; // 0-255
        double number5 = 10.4;
        decimal number6 = 10.4m;
        var number7 = 10; // Girilen veriye gore tanimlanir. Burada Int32 olarak aldi
        number7 = 'A'; // number7 = "A"; yapamazsin String 



        Console.WriteLine("Number1 is {0}", number1);
        Console.WriteLine("Number2 is {0}", number2);
        Console.WriteLine("Number3 is {0}", number3);
        Console.WriteLine("Number4 is {0}", number4);
        Console.WriteLine("Character is {0}", (int)character); // ASCII karsiligini almak
        Console.WriteLine("Number5 is {0}", number5);
        Console.WriteLine("Number6 is {0}", number6);
        Console.WriteLine("Number7 is {0}", number7);
        Console.WriteLine("Day is {0}", Days.Friday);
        Console.ReadLine();

    }
    enum Days
    {
        Monday, Tuesday, Wednsday, Thursday, Friday, Satursday, Sunday
    }
}