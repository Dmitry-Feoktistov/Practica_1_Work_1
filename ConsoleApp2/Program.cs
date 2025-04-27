namespace Работа 1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1";
            //Console.WriteLine("C# — это современный, с открытым исходным кодом, объектно-ориентированный язык программирования");
            //Console.WriteLine("C# — это современный,\n\tс открытым исходным кодом,\n\t\tобъектно-ориентированный\n\t\t\tязык программирования");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("C# — это современный,");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tс открытым исходным кодом,");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tобъектно - ориентированный");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tязык программирования");
            Console.ResetColor();
            Console.Write("Нажми любую клавишу...");
            Console.ReadKey();
        }
    }
}
