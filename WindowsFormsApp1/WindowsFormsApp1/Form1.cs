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
    public partial class WindowForm : Form
    {

        // Store object declaration

        public Store project = new Store();
        public WindowForm()
        {
            InitializeComponent();
        }
        private void btn2_Click(object sender, EventArgs e)
        {

        }
        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnCategory.Visible = false;
            btnProduct.Visible = false;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnCategory.Visible = false;
            btnProduct.Visible = false;
            btnAddProduct.Visible = true;
            btnDeleteProduct.Visible = true;
            btnFindProduct.Visible = true;
            btnEditProduct.Visible = true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // AddProductWindow window = new AddProductWindow();
            // window.Show();
            using (AddProductWindow window = new AddProductWindow() { p = new Product() } )
            {

                if (window.ShowDialog() == DialogResult.OK)
                {
                    productBindingSource.Add(window.p);
                }
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int rowIndex = dtGridView.CurrentCell.RowIndex;
            dtGridView.Rows.RemoveAt(rowIndex);
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            dtGridView.BeginEdit(true);
            dtGridView.EndEdit();
        }

 


        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnCategory.Visible = true;
            btnProduct.Visible = true;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;

            btnAddProduct.Visible = false;
            btnDeleteProduct.Visible = false;
            btnFindProduct.Visible = false;
            btnEditProduct.Visible = false;
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var bd = (BindingSource)dtGridView.DataSource;
            var dt = (DataTable)bd.DataSource;
            DataView dv = new DataView(bd);
            dv.RowFilter = string.Format("id like '%{0}%'", txtSearch.Text);
            dtGridView.DataSource = dv;
        }
    }
}
