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
            
            string myName = "Alexander";
            int age = 29;
            bool haveYouPet = false;
            float shoeSize = 42;
            Console.WriteLine("My name is " + myName + "\nMy age is " + age + "\nDo I have a pet? " + haveYouPet + "\nMy shoe size is " + shoeSize);
            Console.ReadKey();
        }
    }
}