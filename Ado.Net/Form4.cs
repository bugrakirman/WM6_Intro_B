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

namespace Ado.Net
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=WISSEN\\MSSQL2017; Initial Catalog=Northwindsabah; uid=bugra; pwd=1234");
        int CategoryId;
        private void Form4_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void GetAllCategories()
        {
            cbCategories.Items.Clear();
            SqlCommand comm = new SqlCommand("select CategoryId,CategoryName,Description from Categories", conn);

            if (conn.State == ConnectionState.Closed) //bağlantı kapalıysa açılır
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Category c = new Category();
                    c.CategoryId = Convert.ToInt32(dr[0]);
                    c.CategoryName = dr[1].ToString();
                    //lwCategories.Items.Add(dr["CategoryId"].ToString());
                    cbCategories.Items.Add(c);
                }
                dr.Close(); // yoğun olarak datareader kullanılan yerlerde ihtiyac olur
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); } //her durumda bağlantı sonlandırılır
        }

        Category secilen;
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = (Category)cbCategories.SelectedItem;
            CategoryId = secilen.CategoryId;
            lvProduct.Items.Clear();
            SqlCommand comm = new SqlCommand("select ProductID,ProductName,UnitPrice,UnitsInStock,p.CategoryID,CategoryName from Products p inner join Categories c on p.CategoryID=c.CategoryID where CategoryName=@CategoryName", conn);
            comm.Parameters.Add("@CategoryName",SqlDbType.NVarChar).Value=secilen.CategoryName;

            if (conn.State == ConnectionState.Closed) //bağlantı kapalıysa açılır
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    //lwCategories.Items.Add(dr["CategoryId"].ToString());
                    lvProduct.Items.Add(dr[0].ToString());
                    lvProduct.Items[sayac].SubItems.Add(dr[1].ToString());
                    lvProduct.Items[sayac].SubItems.Add(dr[2].ToString());
                    lvProduct.Items[sayac].SubItems.Add(dr[3].ToString());
                    lvProduct.Items[sayac].SubItems.Add(dr[4].ToString());
                    lvProduct.Items[sayac].SubItems.Add(dr[5].ToString());
                    sayac++;
                }
                dr.Close(); // yoğun olarak datareader kullanılan yerlerde ihtiyac olur
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); } //her durumda bağlantı sonlandırılır
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() != "")
            {
                SqlCommand comm = new SqlCommand("Insert into Categories(ProductName,UnitPrice,UnitsInStock,CategoryId) values (@ProductName,@UnitPrice,@UnitsInStock,@CategoryId,@CategoryName)", conn);
                comm.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = txtProductName.Text;
                comm.Parameters.Add("@UnitPrice", SqlDbType.VarChar).Value = txtUnitPrice.Text;
                comm.Parameters.Add("@UnitsInStock", SqlDbType.VarChar).Value = txtUnitsInStock.Text;
                comm.Parameters.Add("@CategoryId", SqlDbType.VarChar).Value = secilen.CategoryId;
                comm.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = secilen.CategoryName;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
                    if (sonuc)
                    {
                        MessageBox.Show("kategori eklendi kayıt tamamlandı");
                        GetAllCategories();
                    }
                    else
                    {
                        MessageBox.Show("kayıt gerçekleşmedi");
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally { conn.Close(); } //her durumda bağlantı sonlandırılır
            }
            else
            {
                MessageBox.Show("Category Name girmelisiniz", " Dikkat eksik bilgi");
            }
        }
    }
}
