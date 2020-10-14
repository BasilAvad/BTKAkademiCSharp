using RecapProject1.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // performans amacıyla kaullanılır ve Datagrid tüm ürünlri göstermek
            ListProducts();
            ListCategory();

        }
        private void ListProducts()
        {
            using (NorthWindContext context=new NorthWindContext())
            {

                //dgwProduct.DataSource = context.products.ToList();
                
            }
        }
        private void ListCategory()
        {
            using (NorthWindContext context = new NorthWindContext())
            {

                cbxCategory.DataSource = context.categories.ToList();
                cbxCategory.DisplayMember = "CategoryId";
                cbxCategory.DisplayMember = "CategoryName";

            }
           
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbxCategory.SelectedValue.ToString());
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgwProduct.DataSource = context.products.ToList();
        }
    }
}
