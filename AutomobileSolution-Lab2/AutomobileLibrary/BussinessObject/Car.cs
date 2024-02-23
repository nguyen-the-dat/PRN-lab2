using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.BussinessObject
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int ReleaseYear { get; set; }

        public Car(DataRow dr)
        {
            CarID = Convert.ToInt32(dr["CarID"]);
            CarName= dr["CarName"].ToString();
            Manufacturer= dr["Manufacturer"].ToString();
            Price= Convert.ToDecimal(dr["Price"]);
            ReleaseYear= Convert.ToInt32(dr["ReleasedYear"]);

        }

        public Car()
        {
        }
    }
}
