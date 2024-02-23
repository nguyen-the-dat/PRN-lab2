using AutomobileLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AutomobileLibrary.DataAccess
{
    public class CarDAO
    {
        private static CarDAO instance;
        public static CarDAO Instance
        {
            get
            {
                if (instance == null) instance = new CarDAO(); return instance;
            }
            set
            {
                instance = value;
            }
        }

        public List<Car> GetCarList()
        {
            List<Car> list = new List<Car>();
            string sql = "select * from Cars";
            DataTable dt = DAO.Instance.GetDataBySql(sql);

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Car(dr));

            }
            return list;
        }
        public Car GetCarByID(int id)
        {
            string sql = "select * from Cars where CarID = @id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DataTable dt = DAO.Instance.GetDataBySql(sql, parameters);

            if (dt.Rows.Count != 0)
            {
                Car car = new Car(dt.Rows[0]);
                return car;
            }
            else
            {
                return null;
            }
        }
        public void AddNew(Car car)
        {
            Car check = GetCarByID(car.CarID);
            if (check == null)
            {
                // @CarID, @CarName, @Manufacturer, @Price, @ReleasedYear
                string sql = "insert Cars values(@CarID, @CarName, @Manufacturer, @Price, @ReleasedYear)";
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@CarID", SqlDbType.Int);
                parameters[1] = new SqlParameter("@CarName", SqlDbType.VarChar);
                parameters[2] = new SqlParameter("@Manufacturer", SqlDbType.VarChar);
                parameters[3] = new SqlParameter("@Price", SqlDbType.Money);
                parameters[4] = new SqlParameter("@ReleasedYear", SqlDbType.Int);
                parameters[0].Value = car.CarID;
                parameters[1].Value = car.CarName;
                parameters[2].Value = car.Manufacturer;
                parameters[3].Value = car.Price;
                parameters[4].Value = car.ReleaseYear;

                DAO.Instance.GetDataBySql(sql, parameters);
            }
            else
            {
                throw new Exception("The car is already exist");
            }
        }
        public void Update(Car car)
        {
            Car check = GetCarByID(car.CarID);
            if (check != null)
            {
                // @CarID, @CarName, @Manufacturer, @Price, @ReleasedYear
                string sql = "update Cars set CarName = @CarName, Manufacturer = @Manufacturer, Price = @Price, ReleasedYear = @ReleasedYear where CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@CarID", SqlDbType.Int);
                parameters[1] = new SqlParameter("@CarName", SqlDbType.VarChar);
                parameters[2] = new SqlParameter("@Manufacturer", SqlDbType.VarChar);
                parameters[3] = new SqlParameter("@Price", SqlDbType.Money);
                parameters[4] = new SqlParameter("@ReleasedYear", SqlDbType.Int);
                parameters[0].Value = car.CarID;
                parameters[1].Value = car.CarName;
                parameters[2].Value = car.Manufacturer;
                parameters[3].Value = car.Price;
                parameters[4].Value = car.ReleaseYear;

                DAO.Instance.GetDataBySql(sql, parameters);
            }
            else
            {
                throw new Exception("The car is already exist");
            }
        }
        public void Remove(int id)
        {
            Car check = GetCarByID(id);
            if (check != null)
            {
                string sql = "delete Cars where CarID = @CarID";
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@CarID", DbType.Int32);
                parameters[0].Value = id;
                DataTable dt = DAO.Instance.GetDataBySql(sql, parameters);
            }
            else
            {
                throw new Exception("The car does not already exist");
            }
        }

        public string hello(int id)
        {
            if (id == 1)
            {
                return "you enter" + id;
            }
            return "default";
        }
    }
}
