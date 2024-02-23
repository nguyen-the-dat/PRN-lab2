using AutomobileLibrary.BussinessObject;
using System.Collections.Generic;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        List<Car> GetCars();
        Car GetCarById(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
        string hello(int id);


    }
}
