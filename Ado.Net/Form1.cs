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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //kullandığımız sql serverın bağlantı özellikleri
        SqlConnection conn = new SqlConnection("Data Source=WISSEN\\MSSQL2017; Initial Catalog=Northwindsabah; uid=bugra; pwd=1234");
        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryId.Text == null) return;
            //sql de çalışacak sorgu
            //SqlCommand comm = new SqlCommand("select CategoryName from Categories where CategoryID = "+txtCategoryId.Text,conn);
            //daha güvenli olması için kullan
            SqlCommand comm = new SqlCommand("select CategoryName from Categories where CategoryID = @Id", conn);
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtCategoryId.Text);
            if (conn.State == ConnectionState.Closed) //bağlantı kapalıysa açılır
                conn.Open();
            try
            {
                txtCategoryName.Text= comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); } //her durumda bağlantı sonlandırılır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
