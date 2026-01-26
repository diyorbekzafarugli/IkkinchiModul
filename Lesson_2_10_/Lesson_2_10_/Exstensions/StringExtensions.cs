namespace Lesson_2_10_.Exstensions;

public static class StringExtensions
{
    public static (char chFirst, char chLast, int Length, string strFirst, string strLast) GetStringSplit(this string text)
    {
        return (text[0], text[text.Length - 1], text.Length, text.Substring(0, 3), text.Substring(text.Length - 3));
    }
}
