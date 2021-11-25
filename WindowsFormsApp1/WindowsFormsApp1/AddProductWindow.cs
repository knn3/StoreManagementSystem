using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddProductWindow : Form
    {
        

        public Product p { get; set; }

        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Month_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductWindow_Load(object sender, EventArgs e)
        {

        }

        private void Category_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            p.nameofproduct = txtName.Text;
            p.id = ID.Text;
            p.company = CompanyName.Text;
            p.expirydate = Date.Text + "/" + Month.Text + "/" + Year.Text;
            p.yearofproduction = int.Parse(YearOfProduction.Text);
            p.nameofcategory = Category.Text;
            //create Category object with the data
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
