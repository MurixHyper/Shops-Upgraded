using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using СarShops.Entities;

namespace СarShops
{
    public partial class CarShopForm : Form
    {
        public AllCarShops AllCarShops { get; set; }
        public CarShop CarShop { get; set; }

        public CarShopForm(AllCarShops allCarShops, int index)
        {
            this.AllCarShops = allCarShops;
            this.CarShop = this.AllCarShops.CarShops[index];

            InitializeComponent();
            InitializeAllItems();
        }

        public void InitializeAllItems()
        {
            try
            {
                NameTb.Text = CarShop.Name;
                AddressTb.Text = CarShop.Address;
                InitializeEmployees();
                InitializeDepartments();
                InitializeProducts();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        public void InitializeEmployees()
        {
            EmployeesListView.Items.Clear();
            List<Worker> workers = CarShop.WorkerDictionaty.Values.ToList();
            foreach (var worker in workers)
            {
                ListViewItem listViewItem = new(workers.IndexOf(worker).ToString());
                listViewItem.SubItems.Add(worker.Code);
                listViewItem.SubItems.Add(worker.Name);
                listViewItem.SubItems.Add(worker.Position.ToString());
                EmployeesListView.Items.Add(listViewItem);
            }
        }

        public void InitializeDepartments()
        {
            
        }

        public void InitializeProducts()
        {
            ProductsListView.Items.Clear();
            foreach (var cars in CarShop.Cars)
            {
                ListViewItem listViewItem = new(CarShop.Cars.IndexOf(cars).ToString());
                listViewItem.SubItems.Add(cars.Brand.ToString());
                listViewItem.SubItems.Add(cars.Model);
                listViewItem.SubItems.Add(cars.SellCost.ToString()+"₴");
                ProductsListView.Items.Add(listViewItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                CarShop.Name = NameTb.Text;
                CarShop.Address = AddressTb.Text;
            }
            catch
            {
                MessageBox.Show("Data is not correct");
                return;
            }

            AllCarShops.ShowAllShops();
            Close();
        }

        private void EmployeesListView_ItemActivate(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new(this, (sender as ListView).SelectedItems[0].Index);
            employeeForm.Show();
        }

        private void DepartmentsListView_ItemActivate(object sender, EventArgs e)
        {
        }

        private void ProductsListView_ItemActivate(object sender, EventArgs e)
        {
            ProductForm productForm = new(this, (sender as ListView).SelectedItems[0].Index);
            productForm.Show();
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            var workers = CarShop.Workers;
            CarShop.RemoveWorker(workers[EmployeesListView.SelectedItems[0].Index].Code);
            InitializeAllItems();
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            CarShop.Cars.RemoveAt(ProductsListView.SelectedItems[0].Index);
            InitializeAllItems();
        }

        private void ProductsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            Worker worker = new();
            worker.NewCode();
            for(int i=0;i<CarShop.Workers.Count;i++) 
            {
                if (worker.Code == CarShop.Workers[i].Code)
                {
                    worker.NewCode();
                    i--;
                }
            }
            CarShop.WorkerDictionaty.Add(worker.Code, worker);
            EmployeeForm employeeForm = new(this, CarShop.WorkersAmount - 1);
            employeeForm.Show();
            InitializeAllItems();
        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            CarShop.Cars.Add(new());
            ProductForm productForm = new(this, CarShop.CarsAmount - 1);
            productForm.Show();
            InitializeAllItems();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarShopForm_Load(object sender, EventArgs e)
        {

        }
    }
}