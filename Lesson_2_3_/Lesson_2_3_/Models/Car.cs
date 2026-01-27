namespace Lesson_2_3_.Models;

public class Car
{
    public Guid CarId { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }


    public Car()
    {
        SayHello();
    }
    public Car(string model, string brand, string color, int speed)
    {
        Model = model;
        Brand = brand;
        Color = color;
        Speed = speed;
    }
    public void SayHello()
    {
        Console.WriteLine("Assalomu Alaykum");

        Car car = new Car("Nexia", "GM", "Black", 180);
        Console.WriteLine(car.Model);
        Console.WriteLine(car.Color);
        Console.WriteLine(car.Speed);
        Console.WriteLine(car.Brand);
    }
}
