namespace Lesson_2_8_HomeWork.Services;

public class WithPayPal : IPayService
{ 
    public void SendMassageToDisplay()
    {
        Console.WriteLine("PayPal orqali to'landi");
    }
}
