namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
        }
    }
}