﻿using System;
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

namespace WarehouseManagementSystem.Edit
{
    public partial class Edit_Suppliers : Form
    {
        public SupplierEntity _supplierEntity = new SupplierEntity();
        public SupplierBusiness _supplierBusinessAccess = new SupplierBusiness();
        public Edit_Suppliers()
        {
            InitializeComponent();
        }

        

        private void btnUpdateSupplierDetails_Click(object sender, EventArgs e)
        {
            if (txtSupplierId.Text.Equals(string.Empty))
            {
                MessageBox.Show("Supplier Id Field is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnUpdateSupplierDetails.Text == "Update")
            {
                _supplierEntity.supplierId = Convert.ToInt32(txtSupplierId.Text);
                _supplierEntity.companyName = txtCompanyName.Text;
                _supplierEntity.contactName = txtContactName.Text;
                _supplierEntity.contactTitle = txtContactTitle.Text;
                _supplierEntity.address = txtAddress.Text;
                _supplierEntity.city = txtCity.Text;
                _supplierEntity.region = txtRegion.Text;
                _supplierEntity.postalCode = txtPostalCode.Text;
                _supplierEntity.country = txtCountry.Text;
                _supplierEntity.phone = txtPhone.Text;
                _supplierEntity.fax = txtFax.Text;
                _supplierEntity.homePage = txtHomePage.Text;


                if (_supplierBusinessAccess.supplierUpdateDetails(_supplierEntity) != 0)
                {

                    MessageBox.Show("Supplier Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    }
}
