namespace Lesson_2_9_.Extensions;

public static class ExtensionsInt
{
    public static int SummDigit(this int num)
    {
        int summ = 0;

        while (num > 0)
        {
            summ += num % 10;
            num = num / 10;
        }
        return summ;
    }


    public static List<int> PrimeNumbers(this int num)
    {
        List<int> nums = new List<int>();
        int count;

        for (int i = 2; i < num; i++)
        {
            count = 0;

            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                nums.Add(i);
            }
        }

        return nums;
    }

    public static List<int> PrimeFactorsOfNumber(this int num)
    {
        int num1 = Math.Abs(num);
        List<int> nums = new List<int>();
        int count;

        for (int i = 1; i <= num1; i++)
        {
            if (num1 % i == 0)
            {
                nums.Add(i);
            }
        }
        return nums;
    }

    public static int ReverseDigits(this int num)
    {
        int num1 = Math.Abs(num);
        int res = 0;

        while (num1 > 0)
        {
            res = res * 10 + num1 % 10;
            num1 = num1 / 10;
        }

        if (num < 0)
        {
            return -res;
        }
        else
        {
            return res;
        }
    }

    public static bool EvenDigitsInNumber(this int num)
    {
        int num1 = Math.Abs(num);
        if (num1 == 0) return true;

        while (num1 > 0)
        {
            if (num1 % 10 % 2 == 0)
            {
                return true;
                break;
            }
            num1 = num1 / 10;
        }

        return false;
    }

    public static int GetSumOfFromOne(this int num)
    {
        int summ = 0;

        for (int i = 1; i <= num; i++)
        {
            summ += i;
        }
        return summ;
    }

}
