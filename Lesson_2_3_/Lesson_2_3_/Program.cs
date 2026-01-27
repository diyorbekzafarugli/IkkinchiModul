using Lesson_2_3_.Models;

namespace Lesson_2_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Car Cars = new Car();
            Console.WriteLine("---------------------");
            Car Cars1 = new Car("X5", "BMW", "Black", 300);
            Console.WriteLine(Cars1.Model);
            Console.WriteLine(Cars1.Brand);
            Console.WriteLine(Cars1.Color);
            Console.WriteLine(Cars1.Speed);
        }
    }
}
