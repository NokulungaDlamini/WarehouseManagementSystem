﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Business;
using Warehouse.Entity;
using WarehouseManagementSystem.Dashboard;

namespace WarehouseManagementSystem.Add
{
    public partial class Add_Categories : Form
    {
        public CategoryEntity _categoryEntity = new CategoryEntity();
        public CategoryBusiness _categoryBusinessAccess = new CategoryBusiness();
        public Add_Categories()
        {
            InitializeComponent();
        }

        string imgLocation = "";

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                PictureUploadBox.ImageLocation = imgLocation;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (txtCategoryName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Category Name Field is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescription.Text.Equals(string.Empty))
            {
                MessageBox.Show("Description Field is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (imgLocation.Equals(string.Empty))
            {
                MessageBox.Show("Category Picture not Uploaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnSave.Text == "Save")
            {
                byte[] images = null;
                FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((byte)Streem.Length);

                _categoryEntity.categoryname = txtCategoryName.Text;
                _categoryEntity.description = txtDescription.Text;
                _categoryEntity.picture = images;

                if (_categoryBusinessAccess.categoryinsertDetails(_categoryEntity) > 0)
                {

                    MessageBox.Show("Category Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
