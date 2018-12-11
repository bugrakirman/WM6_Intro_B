using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meyveler = {"a","b","c" };
            comboBox1.Items.AddRange(meyveler);
            comboBox1.Items.Add("kiraz");
            comboBox1.Items.Add("üzüm");
            listBox1.Items.AddRange(meyveler);
            listBox1.SelectionMode = SelectionMode.One;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show($"{dateTimePicker1.Value:dd-MM-yy HH.mm}");
            MessageBox.Show($"ürünün fiyatı:{numericUpDown1.Value:c2}");
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (sayac++).ToString();
        }
    }
}
