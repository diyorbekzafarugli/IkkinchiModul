using Lesson_2_2_.Models;

namespace Lesson_2_2_.Services;

public class CarService
{
    public List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public bool DeleteCar(Guid guid)
    {
        for(int i = 0; i < Cars.Count; i++)
        {
            if (Cars[i].CarId == guid)
            {
                Cars.RemoveAt(i);
                return true;
            }
        }
        return false;
    }


    public bool UpdateCar(Car newCar)
    {
        for (int i = 0; i < Cars.Count; i++)
        {
            if (Cars[i].CarId == newCar.CarId)
            {
                Cars[i] = newCar;
                return true;
            }
        }
        return false;
    }


    public Car? GetCar(Guid guid)
    {

        foreach (var car in Cars)
        {
            if (car.CarId == guid)
            {
                return car;
            }
        }

        return null;
    }
}
