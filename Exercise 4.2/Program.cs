namespace Exercise_4._2
{
    using static System.Convert;
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;

            WriteLine("Give me a number:");
            var1 = ToInt32(ReadLine());
            WriteLine("Give me another one:");
            var2 = ToInt32(ReadLine());

            if ( (var1 > 10) ^ (var2 > 10) )
            {
                WriteLine($"Here are your numbers back: {var1}, {var2}.\n" +
                    "Thank you, come again.");
            }
            else
            {
                WriteLine("Sorry, seems both numbers were either below 10 or both were over 10.");    
            }

        }
    }
}