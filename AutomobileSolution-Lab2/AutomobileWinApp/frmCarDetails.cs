using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using AutomobileLibrary.Repository;
using System;

using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //false: insert, true: update
        public Car CarInfo { get; set; }
        public frmCarDetails()
        {
            InitializeComponent();
            CarRepository = new CarRepository();
        }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            // mode update
            if (InsertOrUpdate)
            {
                // add infor car to text box
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate) // update - true
                {
                    CarRepository.UpdateCar(car);
                }
                else // insert - false
                {
                    CarRepository.InsertCar(car);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }
        void loadDatabase()
        {

            CarInfo = CarRepository.GetCarById(1);

            //txtCarID.Text = CarDAO.Instance.hello(1);
            txtCarID.Text = CarInfo.CarID.ToString();
            txtCarName.Text = CarInfo.CarName;
            txtPrice.Text = CarInfo.Price.ToString();
            txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
            cboManufacturer.Text = CarInfo.Manufacturer.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
