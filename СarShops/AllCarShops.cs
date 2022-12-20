using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using СarShops.Entities;
using System.IO;

namespace СarShops
{
    public partial class AllCarShops : Form
    {
        public List<CarShop> CarShops { get; set; }
        private bool _descending = false;
        public AllCarShops()
        {
            CarShops = InitializeDefaultShops();

            InitializeComponent();
        }

        private void AllCarShops_Load(object sender, EventArgs e)
        {
            ShowAllShops();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CarShop shop = new();
            CarShops.Add(shop);
            CarShopForm carShopForm = new(this, CarShops.IndexOf(shop));
            carShopForm.Show();
            ShowAllShops();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {   
            if(Directory.Exists("ShopData"))
            {
                if (Directory.Exists($"ShopData\\{CarShops[listView1.SelectedItems[0].Index].Name}"))
                {
                    File.Delete($"ShopData\\{CarShops[listView1.SelectedItems[0].Index].Name}\\Cars.txt");
                    File.Delete($"ShopData\\{CarShops[listView1.SelectedItems[0].Index].Name}\\ShopData.txt");
                    File.Delete($"ShopData\\{CarShops[listView1.SelectedItems[0].Index].Name}\\Workers.txt");
                    Directory.Delete($"ShopData\\{CarShops[listView1.SelectedItems[0].Index].Name}");
                }
            }
            CarShops.RemoveAt(listView1.SelectedItems[0].Index);
            
            ShowAllShops();
        }

        public void ShowAllShops()
        {
            listView1.Items.Clear();
            foreach (var shop in CarShops)
            {
                ListViewItem item = new(CarShops.IndexOf(shop).ToString());
                item.SubItems.Add(shop.Name);
                item.SubItems.Add(shop.Address);
                item.SubItems.Add(shop.WorkersAmount.ToString());

                listView1.Items.Add(item);
            }
        }

        public List<CarShop> InitializeDefaultShops()
        {
            List<CarShop> shops = new();
            return shops;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            CarShopForm carShopForm = new(this, (sender as ListView).SelectedItems[0].Index);
            carShopForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compare_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 2)
            {
                var firstShop = CarShops[listView1.SelectedItems[0].Index];
                var secondShop = CarShops[listView1.SelectedItems[1].Index];
                var compare = firstShop.CompareTo(secondShop);
                if (compare < 0)
                    MessageBox.Show("Second is bigger");
                else if (compare == 0)
                    MessageBox.Show("They are equal");
                else
                    MessageBox.Show("First is bigger");
            }
            else
                MessageBox.Show("Choose only two shops!");
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (_descending)
            {
                CarShops.Sort();
                CarShops.Reverse();
            }
            else
                CarShops.Sort();

            _descending = !_descending;
            ShowAllShops();
        }

        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            foreach (var shop in CarShops)
                WriteShopToFile(shop);
        }
        private void WriteShopToFile(CarShop carShop)
        {
            Directory.CreateDirectory($"ShopData\\{carShop.Name}");
            File.AppendAllText($"ShopData\\{carShop.Name}\\ShopData.txt", "");
            File.AppendAllText($"ShopData\\{carShop.Name}\\ShopData.txt", $"{carShop.Name}!{carShop.Address}");
            WriteWorkersToFile(carShop);
            WriteCarsToFile(carShop);
        }
        private void WriteWorkersToFile(CarShop carShop)
        {
            foreach (var worker in carShop.Workers)
            {
                File.AppendAllText($"ShopData\\{carShop.Name}\\Workers.txt", "");
                File.AppendAllText($"ShopData\\{carShop.Name}\\Workers.txt",
                    $"{worker.Name}!" +
                    $"{worker.Surname}!" +
                    $"{worker.Salary}!" +
                    $"{worker.Birthday}!" +
                    $"{worker.Position}!" +
                    $"{worker.Education}!" +
                    $"{worker.Code}!" +
                    $"{worker.Age}{Environment.NewLine}");
            }
        }
        private void WriteCarsToFile(CarShop carShop)
        {
            foreach (var car in carShop.Cars)
            {
                File.AppendAllText($"ShopData\\{carShop.Name}\\Cars.txt", "");
                File.AppendAllText($"ShopData\\{carShop.Name}\\Cars.txt",
                    $"{car.Brand}!" +
                    $"{car.Model}!" +
                    $"{car.GearBox}!" +
                    $"{car.Fuel}!" +
                    $"{car.Volume}!" +
                    $"{car.Consumption}!" +
                    $"{car.PurchaseCost}!" +
                    $"{car.SellCost}{Environment.NewLine}");
            }
        }
        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            string line;

            if (Directory.Exists("ShopData"))
            {
                string[] dirs = Directory.GetDirectories("ShopData");
                foreach (var dir in dirs)
                {
                    CarShop carShop = new();
                    List<Car> cars = new();
                    List<Worker> workers = new();
                    try
                    {
                        StreamReader sr = new StreamReader($"{dir}\\ShopData.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            string[] data = line.Split('!');
                            carShop.Name = data[0];
                            carShop.Address = data[1];
                            line = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    try
                    {
                        StreamReader sr = new StreamReader($"{dir}\\Cars.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            string[] data = line.Split('!');
                            cars.AddRange(new List<Car>
                            {
                                new()
                                {
                                    Brand = Enum.Parse<Brand>(data[0]),
                                    Model = data[1],
                                    GearBox = Enum.Parse<GearBox>(data[2]),
                                    Fuel = Enum.Parse<Fuel>(data[3]),
                                    Volume = Double.Parse(data[4]),
                                    Consumption=Double.Parse(data[5]),
                                    PurchaseCost=Double.Parse(data[6]),
                                    SellCost=Double.Parse(data[7])
                                }
                            });
                            line = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    try
                    {
                        StreamReader sr = new StreamReader($"{dir}\\Workers.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            string[] data = line.Split('!');
                            workers.AddRange(new List<Worker>
                            {
                                new()
                                {
                                    Name=data[0],
                                    Surname=data[1],
                                    Salary=Double.Parse(data[2]),
                                    Birthday=DateTime.Parse(data[3]),
                                    Position=Enum.Parse<Position>(data[4]),
                                    Education=Enum.Parse<Education>(data[5]),
                                    Code=data[6],
                                    Age=Int32.Parse(data[7])
                                }
                            });
                            line = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    carShop.Cars = cars;
                    foreach (var worker in workers)
                        carShop.AddWorker(worker);
                    CarShops.Add(carShop);
                    ShowAllShops();
                }
            }
        }
    }
}