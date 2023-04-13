﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Entity;

namespace Warehouse.DataAccess
{
    public class ProductRepository
    {
        public SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();

        public int productinsert(ProductEntity productEntity)
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertProduct_sp";

            cmd.Parameters.AddWithValue("@ProductName", productEntity.productName);
            cmd.Parameters.AddWithValue("@SupplierId", productEntity.supplierId);
            cmd.Parameters.AddWithValue("@CategoryId", productEntity.categoryId);
            cmd.Parameters.AddWithValue("@QuantityPerUnit", productEntity.quantityPerUnit);
            cmd.Parameters.AddWithValue("@UnitPrice", productEntity.unitPrice);
            cmd.Parameters.AddWithValue("@UnitsInStock", productEntity.unitsInStock);
            cmd.Parameters.AddWithValue("@UnitsOnOrder", productEntity.unitsOnOrder);
            cmd.Parameters.AddWithValue("@ReorderLevel", productEntity.reorderLevel);
            cmd.Parameters.AddWithValue("@discontinued", productEntity.discontinued);


            int i = cmd.ExecuteNonQuery();
            return i;

        }

        public int productUpdate(ProductEntity productEntity)
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateProduct_sp";
            cmd.Parameters.AddWithValue("@ProductId", productEntity.productId);
            cmd.Parameters.AddWithValue("@ProductName", productEntity.productName);
            cmd.Parameters.AddWithValue("@SupplierId", productEntity.supplierId);
            cmd.Parameters.AddWithValue("@CategoryId", productEntity.categoryId);
            cmd.Parameters.AddWithValue("@QuantityPerUnit", productEntity.quantityPerUnit);
            cmd.Parameters.AddWithValue("@UnitPrice", productEntity.unitPrice);
            cmd.Parameters.AddWithValue("@UnitsInStock", productEntity.unitsInStock);
            cmd.Parameters.AddWithValue("@UnitsOnOrder", productEntity.unitsOnOrder);
            cmd.Parameters.AddWithValue("@ReorderLevel", productEntity.reorderLevel);
            cmd.Parameters.AddWithValue("@discontinued", productEntity.discontinued);


            int i = cmd.ExecuteNonQuery();
            return i;




        }

        public int productDelete(ProductEntity productEntity)
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteProduct_sp";

            cmd.Parameters.AddWithValue("@ProductId", productEntity.productId);

            int i = cmd.ExecuteNonQuery();
            return i;


        }
    }
}
