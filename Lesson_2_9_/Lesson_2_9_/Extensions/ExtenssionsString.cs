namespace Lesson_2_9_.Extensions;

public static class ExtenssionsString
{
    public static string FirstHalfString(this string text)
    {
        var str = string.Empty;

        for (int i = 0; i < text.Length - 1; i++)
        {
            str += text[i];
            if (char.IsUpper(text[i + 1]))
            {
                break;
            }
        }
        return str;
    }

    public static string RemoveDigits(this string text)
    {
        string str = string.Empty;

        foreach (char ch in text)
        {
            if (!char.IsDigit(ch))
            {
                str += ch;
            }
        }
        return str;
    }

    public static bool StringIsPalindrome(this string str)
    {
        var text = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            text += str[i];
        }
        return str == text;
    }

    public static string DoubleTheVowels(this string text)
    {
        var str = string.Empty;
        var wovels = "AEIOUaeiou";

        for (int i = 0; i < text.Length; i++)
        {
            if (wovels.Contains(text[i]))
            {
                str += text[i].ToString() + text[i].ToString();
            }
            else
            {
                str += text[i];
            }

        }
        return str;
    }

    public static int CountVowelsOfString(this string text)
    {
        var counter = 0;
        var vowels = "AEIOUaeiou";

        foreach (char ch in text)
        {
            if (vowels.Contains(ch))
            {
                counter++;
            }
        }

        return counter;
    }

    public static int CountDigitsInString(this string text)
    {
        var count = 0;
        foreach (var ch in text)
        {
            if (char.IsDigit(ch))
            {
                count++;
            }
        }

        return count;
    }


    public static int GetCountOfCat1(this string text)
    {
        int count = 0; // "c a l o m"
        for (int i = 1; i < text.Length - 1; i++)
        {
            if (text[i - 1] == 'c' && text[i] == 'a' && text[i + 1] == 't')
            {
                count++;
            }
        }
        return count;
    }

    public static int GetCountOfCat2(this string text) // "cat.cat.acat.Salom"
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        string[] arr = text.Split("cat");
        return arr.Length - 1;
    }
}
