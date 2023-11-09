namespace Exercise_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;

            Console.WriteLine("Give me a number:");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another one:");
            var2 = Convert.ToInt32(Console.ReadLine());

            if ( (var1 > 10) ^ (var2 > 10) )
            {
                Console.WriteLine($"Here are your numbers back: {var1}, {var2}." +
                    "Thank you, come again.");
            }
            else
            {
                Console.WriteLine("Sorry, seems both numbers were either below 10 or both were over 10.");    
            }

        }
    }
}