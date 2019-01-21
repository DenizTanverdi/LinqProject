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
    public partial class Form1 : Form
    {
        NORTHWND2DataContext db = new NORTHWND2DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sales = db.Sales_by_Year(new DateTime(1990, 1, 1), new DateTime(2000, 1, 1));
            SALES.DataSource = sales;
            var q = from c in db.Customers select new { c.CustomerID, c.CompanyName };
            CustomerGird.DataSource = q;
        }

        private void CustomerGird_MouseClick(object sender, MouseEventArgs e)
        {
            string custId = CustomerGird.CurrentRow.Cells[0].Value.ToString();
            var order = from ord in db.Orders where ord.CustomerID == custId select ord;
            OrderGrid.DataSource = order;
            int detId = Convert.ToInt32(OrderGrid.CurrentRow.Cells[0].Value.ToString());
            var detail = from det in db.Order_Details where det.OrderID == detId select det;
            OrderDGrid.DataSource = detail;
        }
    }
}
