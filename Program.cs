namespace FirstTask
{
    internal class Program2
    {
        enum DaysOfWeek: byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Semophone: short
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        static void Main(string[] args)
        {
            Console.Write("Enter youre name: ");
            string myName = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            int intage = age;
            bool haveYouPet = false;
            Console.WriteLine("Your name is {0} and age is {1}", myName, intage);
            Console.Write("What is your favorite day of week?");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            Console.ReadKey();
        }
    }
}