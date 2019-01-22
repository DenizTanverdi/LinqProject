using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLinqSql
{
    public partial class Form2 : Form
    {
        NORTHWND2DataContext db = new NORTHWND2DataContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var categori = (from ctg in db.Categories select ctg).ToList();
            comboBox1.DataSource = categori;
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DisplayMember = "CategoryName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                var product = (from prdct in db.Products where prdct.CategoryID == Id select prdct).ToList();
                dataGridView1.DataSource = product;
                
            }
            catch (Exception)
            {

               
            }
            
         
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView2.DataSource = null;
            int pid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = from p in db.Products
                         join det in db.Order_Details on p.ProductID equals det.ProductID
                         join ord in db.Orders on det.OrderID equals ord.OrderID
                         join sh in db.Shippers on ord.ShipVia equals sh.ShipperID where p.ProductID==pid
                         select new
                         {
                             p.ProductName,
                             sh.CompanyName,
                             ord.ShipCountry,
                             ord.OrderDate
                         };

            dataGridView2.DataSource = result;
        }
    }
}
