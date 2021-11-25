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
    public partial class AddCategoryWindow : Form
    {
        string nameCategory;
        public AddCategoryWindow()
        {
            InitializeComponent();
        }

        private void txtNameOfCategory_TextChanged(object sender, EventArgs e)
        {
            nameCategory = txtNameOfCategory.Text;
            //Store.Insert
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
