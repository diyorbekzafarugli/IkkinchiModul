namespace Lesson_2_1_;

public class Student
{
    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Addres { get; set; }
    public DateTime RegisteredDate { get; set; }







    public override string ToString()
    {
        return $"ID : {StudentId}\nFN : {FirstName}\nLN : {LastName}\nEmail : {Email}\nTel : {PhoneNumber}\nManzil : {Addres}\nRo'yxatga olingan vaqt : {RegisteredDate}";
    }
  
}



