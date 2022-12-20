using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using СarShops.Entities;

namespace СarShops
{
    public partial class ProductForm : Form
    {
        public CarShopForm CarShopForm { get; set; }
        public Car Cars { get; set; }

        public ProductForm(CarShopForm carShopForm, int index)
        {
            CarShopForm = carShopForm;
            Cars = carShopForm.CarShop.Cars[index];
            InitializeComponent();
            InitializeAllItems();
        }

        private void InitializeAllItems()
        {
            try
            {
                comboBrand.Items.Add(Brand.Audi);
                comboBrand.Items.Add(Brand.BMW);
                comboBrand.Items.Add(Brand.Ferrari);
                comboBrand.Items.Add(Brand.Koenigsegg);
                comboBrand.Items.Add(Brand.Lamborghini);
                comboBrand.Items.Add(Brand.Lotus);
                comboBrand.Items.Add(Brand.McLaren);
                comboBrand.Items.Add(Brand.Mercedes);
                comboBrand.Items.Add(Brand.Nissan);
                comboBrand.Items.Add(Brand.Porsche);
                comboBrand.Items.Add(Brand.Tesla);
                textBoxModel.Text = Cars.Model;
                comboGearBox.Items.Add(GearBox.Automatic);
                comboGearBox.Items.Add(GearBox.Mechanic);
                comboGearBox.Items.Add(GearBox.SemiAutomatic);
                comboFuel.Items.Add(Fuel.Diesel);
                comboFuel.Items.Add(Fuel.Electric);
                comboFuel.Items.Add(Fuel.Petrol);
                textBoxConsumption.Text=Cars.Consumption.ToString();
                textBoxVolume.Text=Cars.Volume.ToString();
                PurchaseCostTb.Text = Cars.PurchaseCost.ToString();
                SellCostTb.Text = Cars.SellCost.ToString();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Cars.Brand = Enum.Parse<Brand>(comboBrand.Text);
                Cars.Model = textBoxModel.Text;
                Cars.GearBox = Enum.Parse<GearBox>(comboGearBox.Text);
                Cars.Fuel = Enum.Parse<Fuel>(comboFuel.Text);
                Cars.Consumption = Double.Parse(textBoxConsumption.Text);
                Cars.Volume=Double.Parse(textBoxVolume.Text);
                Cars.PurchaseCost = Double.Parse(PurchaseCostTb.Text);
                Cars.SellCost = Double.Parse(SellCostTb.Text);
            }
            catch
            {
                MessageBox.Show("Data is not correct");
                return;
            }

            CarShopForm.InitializeAllItems();
            Close();
        }

        private void Brand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TotalCostLbl_Click(object sender, EventArgs e)
        {

        }
    }
}