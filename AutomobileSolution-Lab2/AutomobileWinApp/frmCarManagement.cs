using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System.Windows.Forms;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository;
        BindingSource source;
        public frmCarManagement()
        {
            InitializeComponent();
            carRepository = new CarRepository();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;


        }

        void LoadCarList()
        {
            var carList = carRepository.GetCars();
            try
            {
                source = new BindingSource();
                source.DataSource = carList;

                // 
                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtManufacturer.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManufacturer.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");


                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;
                if (carList.Count == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }

        }

        private void ClearText()
        {
            txtCarID.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            LoadCarList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Add car",
                InsertOrUpdate = false,
                CarRepository = carRepository,
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = getCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }

        }

        private Car getCarObject()
        {
            Car car = null;
            try
            {
                car = new Car()
                {
                    CarID = Convert.ToInt32(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManufacturer.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    ReleaseYear = Convert.ToInt32(txtReleaseYear.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return car;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Update Car",
                InsertOrUpdate = true,
                CarInfo = getCarObject(),
                CarRepository = carRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }
    }
}
