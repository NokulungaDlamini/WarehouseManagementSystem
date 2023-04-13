﻿using System;
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
    public partial class UC_ManageSuppliers : UserControl
    {
        public UC_ManageSuppliers()
        {
            InitializeComponent();
            Display();
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            Add_Suppliers As = new Add_Suppliers();
            As.ShowDialog();
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
            DisplayAndSearch("Select CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage FROM Suppliers ", dataGridView);
        }

     

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Edit_Suppliers As = new Edit_Suppliers();
            As.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete_Supplier As = new Delete_Supplier();
            As.ShowDialog();
        }
    }
}
