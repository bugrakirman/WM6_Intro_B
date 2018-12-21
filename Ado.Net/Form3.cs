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

namespace Ado.Net
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=WISSEN\\MSSQL2017; Initial Catalog=Northwindsabah; uid=bugra; pwd=1234");
        private void Form3_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void GetAllCategories()
        {
            lvCategories.Items.Clear();
            SqlCommand comm = new SqlCommand("select CategoryId,CategoryName,Description from Categories", conn);

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
                    lvCategories.Items.Add(dr[0].ToString());
                    lvCategories.Items[sayac].SubItems.Add(dr[1].ToString());
                    lvCategories.Items[sayac].SubItems.Add(dr[2].ToString());
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
            if (txtCategoryName.Text.Trim() != "")
            {
                SqlCommand comm = new SqlCommand("Insert into Categories(CategoryName,Description) values (@CategoryName,@Description)",conn);
                comm.Parameters.Add("@CategoryName",SqlDbType.VarChar).Value=txtCategoryName.Text;
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = txtDescription.Text;
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
                MessageBox.Show("Category Name girmelisiniz"," Dikkat eksik bilgi");
            }
           
        }
        
}
}
