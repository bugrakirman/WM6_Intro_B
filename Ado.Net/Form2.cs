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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=WISSEN\\MSSQL2017; Initial Catalog=Northwindsabah; uid=bugra; pwd=1234");
        private void btnCategories_Click(object sender, EventArgs e)
        {
            lwCategories.Items.Clear();
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
                    lwCategories.Items.Add(dr[0].ToString());
                    lwCategories.Items[sayac].SubItems.Add(dr[1].ToString());
                    lwCategories.Items[sayac].SubItems.Add(dr[2].ToString());
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
    }
}
