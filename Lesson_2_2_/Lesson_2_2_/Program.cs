using Lesson_2_2_.Models;
using Lesson_2_2_.Services;

namespace Lesson_2_2_;

internal class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car()
        {
            Brand = "BMW",
            Model = "X5",
            Color = "Black",
            Speed = 300,
            Price = 200000
        };

        Car car1 = new Car()
        {
            Brand = "BMW",
            Model = "X5",
            Color = "Black",
            Speed = 300,
            Price = 200000
        };

        CarService carService = new CarService();
        var carId1 = carService.AddCar(myCar);
        var carId2 = carService.AddCar(car1);


        var cars = carService.GetAllCars();
    }

}
