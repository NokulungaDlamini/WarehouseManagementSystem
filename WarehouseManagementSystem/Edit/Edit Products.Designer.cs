﻿using System.Windows.Forms;

namespace WarehouseManagementSystem.Edit
{
    partial class Edit_Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateProductDetails = new System.Windows.Forms.Button();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitsInOrder = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtDiscontinued = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 439);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(804, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 449);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 10);
            this.panel1.TabIndex = 4;
            // 
            // btnUpdateProductDetails
            // 
            this.btnUpdateProductDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateProductDetails.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateProductDetails.FlatAppearance.BorderSize = 0;
            this.btnUpdateProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProductDetails.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProductDetails.Location = new System.Drawing.Point(532, 346);
            this.btnUpdateProductDetails.Name = "btnUpdateProductDetails";
            this.btnUpdateProductDetails.Size = new System.Drawing.Size(164, 38);
            this.btnUpdateProductDetails.TabIndex = 20;
            this.btnUpdateProductDetails.Text = "Update";
            this.btnUpdateProductDetails.UseVisualStyleBackColor = false;
            this.btnUpdateProductDetails.Click += new System.EventHandler(this.btnUpdateProductDetails_Click);
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(532, 159);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(179, 26);
            this.txtUnitInStock.TabIndex = 13;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(199, 144);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(179, 26);
            this.txtProductName.TabIndex = 14;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(199, 284);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(177, 26);
            this.txtUnitPrice.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(398, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Units In Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(44, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity Per Unit:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(81, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Unit Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(97, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "SupplierId:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(68, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(290, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Update Products Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(426, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CategoryId:";
            // 
            // txtUnitsInOrder
            // 
            this.txtUnitsInOrder.Location = new System.Drawing.Point(534, 284);
            this.txtUnitsInOrder.Name = "txtUnitsInOrder";
            this.txtUnitsInOrder.Size = new System.Drawing.Size(177, 26);
            this.txtUnitsInOrder.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(75, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Discontinued:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(728, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 39);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(399, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Units In Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(399, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reorder Level:";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(534, 225);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(177, 26);
            this.txtReorderLevel.TabIndex = 13;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(200, 231);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(179, 26);
            this.txtQuantityPerUnit.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(81, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Product Id:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(199, 104);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(179, 26);
            this.txtProductId.TabIndex = 14;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(200, 187);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(179, 26);
            this.txtSupplierId.TabIndex = 14;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(532, 107);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(179, 26);
            this.txtCategoryId.TabIndex = 14;
            // 
            // txtDiscontinued
            // 
            this.txtDiscontinued.Location = new System.Drawing.Point(199, 344);
            this.txtDiscontinued.Name = "txtDiscontinued";
            this.txtDiscontinued.Size = new System.Drawing.Size(177, 26);
            this.txtDiscontinued.TabIndex = 13;
            // 
            // Edit_Products
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 459);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateProductDetails);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.txtDiscontinued);
            this.Controls.Add(this.txtUnitsInOrder);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddNewBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateProductDetails;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitsInOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClose;
        private Label label1;
        private TextBox txtReorderLevel;
        private Label label3;
        private TextBox txtQuantityPerUnit;
        private Label label5;
        private TextBox txtProductId;
        private TextBox txtSupplierId;
        private TextBox txtCategoryId;
        private TextBox txtDiscontinued;
    }
}