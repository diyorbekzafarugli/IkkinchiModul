using Lesson_2_9_.Extensions;

namespace Lesson_2_9_;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(45.SummDigit());

        //var num = 1198.PrimeNumber();
        //DislpayList(num);

        //var num = 7.EvenDigitsInNumber();
        //Console.WriteLine(num);
        //DislpayList(res);

        string str = "cat.cat.acat.Salom";
        var res = str.GetCountOfCat2();
        Console.WriteLine(res);
    }

    static void DislpayList(List<int> nums)
    {
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
}
