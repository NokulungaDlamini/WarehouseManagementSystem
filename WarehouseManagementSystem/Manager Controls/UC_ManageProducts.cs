using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Add;
using WarehouseManagementSystem.Delete;
using WarehouseManagementSystem.Edit;

namespace WarehouseManagementSystem.Manager_Controls
{
    public partial class UC_ManageProducts : UserControl
    {
        public UC_ManageProducts()
        {
            InitializeComponent();
            Display();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            Add_Products abn = new Add_Products();
            abn.ShowDialog();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            dgv.DataSource = dataTable;
            con.Close();
        }
        public void Display()
        {
            DisplayAndSearch("Select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,discontinued FROM Products ", dataGridView1);
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete_Product abn = new Delete_Product();
            abn.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Edit_Products abn = new Edit_Products();
            abn.ShowDialog();
        }
    }
}
