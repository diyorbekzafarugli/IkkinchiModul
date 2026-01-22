using Lesson_2_8_HomeWork.Services;

namespace Lesson_2_8_HomeWork;

internal class Program
{
    static void Main(string[] args)
    {
        IPayService paymend = PayWithCard("HMO");
        paymend.SendMassageToDisplay();

    }


    public static IPayService PayWithCard(string element)
    {
        return element.ToLower() switch
        {
            "click" => new WithClick(),
            "visa" => new WithVisa(),
            "uzcard" => new WithUzCard(),
            "humo" => new WithHumoCard(),
            "mastercard" => new WithMasterCard(),
            "paypal" => new WithPayPal(),
            "payme" => new WithPayMe(),
            _ => throw new ArgumentException("To'lov muvaffaqiyatli bo'lmadi")
        };



    }
} 



