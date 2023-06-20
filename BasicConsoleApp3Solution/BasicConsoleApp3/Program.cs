namespace BasicConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            int age = 40;
            string ageString = age.ToString();
            Console.WriteLine("I am not" + ageString);
            Console.Write("Hey how old are you?");
            string? enteredAge = Console.ReadLine();
            Console.WriteLine("You said " + enteredAge);
            try
            {
                age = int.Parse(enteredAge);
            }
            catch (FormatException)
            {
                Console.WriteLine("Etner a number, you big old dork.");
            }
            if(age >= 21)
            {
                Console.WriteLine("Sub was here");
                Console.WriteLine("How's it going?");
            }
            else
            {
                Console.WriteLine("Too young. Come back later");
            }
        }
    }
}