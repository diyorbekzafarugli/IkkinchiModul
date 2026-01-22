namespace Lesson_2_8_HomeWork.Services;

public class WithMasterCard : IPayService
{
    public void SendMassageToDisplay()
    {
        Console.WriteLine("Mastercard orqali to'landi");
    }
}
