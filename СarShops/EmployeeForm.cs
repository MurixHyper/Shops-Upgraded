using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using СarShops.Entities;

namespace СarShops
{
    public partial class EmployeeForm : Form
    {
        public CarShopForm CarShopForm { get; set; }
        public Worker Worker { get; set; }

        public EmployeeForm(CarShopForm carShopForm, int index)
        {
            CarShopForm = carShopForm;
            Worker = carShopForm.CarShop.Workers[index];
            InitializeComponent();
            InitializeAllItems();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        public void InitializeAllItems()
        {
            try
            {
                AgeTb.Text = Worker.Age.ToString();
                NameTb.Text = Worker.Name;
                Surnametb.Text = Worker.Surname;
                SalaryTb.Text = Worker.Salary.ToString();
                PositionCb.Items.Add(Position.Director);
                PositionCb.Items.Add(Position.HR);
                PositionCb.Items.Add(Position.OlderSeller);
                PositionCb.Items.Add(Position.Seller);
                PositionCb.Items.Add(Position.Security);
                EducationCb.Items.Add(Education.Financial);
                EducationCb.Items.Add(Education.Legal);
                EducationCb.Items.Add(Education.Liberal);
                EducationCb.Items.Add(Education.None);
                EducationCb.Items.Add(Education.Technic);
                BirthdayDp.Text = Worker.Birthday.ToString();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Worker.Name = NameTb.Text;
                Worker.Surname = Surnametb.Text;
                Worker.Age = Int32.Parse(AgeTb.Text);
                Worker.Birthday = DateTime.Parse(BirthdayDp.Text);
                Worker.Position = Enum.Parse<Position>(PositionCb.Text);
                Worker.Education = Enum.Parse<Education>(EducationCb.Text);
                Worker.NewCode();
                if (8000 <= Double.Parse(SalaryTb.Text) && Double.Parse(SalaryTb.Text) <= 60000)
                    Worker.Salary = Double.Parse(SalaryTb.Text);
                else
                {
                    MessageBox.Show("Data is not correct\nSallary could be [8000:60000]");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Data is not correct");
                return;
            }
            CarShopForm.InitializeAllItems();
            Close();
        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        private void AgeTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
