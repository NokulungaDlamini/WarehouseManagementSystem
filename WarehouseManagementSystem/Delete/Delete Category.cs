using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Business;
using Warehouse.Entity;
using WarehouseManagementSystem.Dashboard;

namespace WarehouseManagementSystem.Delete
{
    public partial class Delete_Category : Form
    {
        public CategoryEntity _categoryEntity = new CategoryEntity();
        public CategoryBusiness _categoryBusinessAccess = new CategoryBusiness();
        public Delete_Category()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCategoryId.Text.Equals(string.Empty))
            {
                MessageBox.Show("Category Id Field is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Are you sure you want to delete this Category!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btnDelete.Text == "Delete")
            {


                _categoryEntity.categoryId = Convert.ToInt32(txtCategoryId.Text);


                if (_categoryBusinessAccess.categorydeleteDetails(_categoryEntity) > 0)
                {
                    MessageBox.Show("Category Deleted Successfully");
                }




            }
            Manager_Dashboard home = new Manager_Dashboard();
            home.ShowDialog();
            this.Dispose();
        }

     

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
