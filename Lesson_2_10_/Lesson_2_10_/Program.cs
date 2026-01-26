using Lesson_2_10_.Exstensions;

namespace Lesson_2_10_;

internal class Program
{
    static void Main(string[] args)
    {
        string str = "AssalomG13";
        var res = str.GetStringSplit();
        Console.WriteLine(res.chFirst);
        Console.WriteLine(res.chLast);
        Console.WriteLine(res.Length);
        Console.WriteLine(res.strFirst);
        Console.WriteLine(res.strLast);
    }
}
