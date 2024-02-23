using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System.Collections.Generic;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {

        public Car GetCarById(int carId) => CarDAO.Instance.GetCarByID(carId);

        public List<Car> GetCars() => CarDAO.Instance.GetCarList();

        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);   
        public void DeleteCar(int carId) => CarDAO.Instance.Remove(carId);

        public string hello(int id) => CarDAO.Instance.hello(id);
    }
}
