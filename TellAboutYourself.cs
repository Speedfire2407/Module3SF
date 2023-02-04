namespace FirstTask
{
    internal class TellAboutYourself
    {
        /// <summary>
        /// Перечисления дней недели
        /// </summary>
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
        /// <summary>
        /// Программа задает вопросы о пользователе
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter you're name: ");
            string myName = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            int intage = age;
            Console.WriteLine("Your name is {0} and age is {1}", myName, intage);
            Console.WriteLine("Enter you're grouth sm: ");
            float yourTall = (float)int.Parse(Console.ReadLine());
            Console.WriteLine("What is your shoe size? ");
            byte shoeSize = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("You're {0} cm tall and you have shoes size {1}", yourTall, shoeSize);
            Console.Write("What is your favorite day of week? ");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            Console.ReadKey();
        }
    }
}