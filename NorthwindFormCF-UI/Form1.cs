using NorthwindFormCF_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindFormCF_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetCustomer();
        }

        private void getOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrders frm = new FrmOrders();
            frm.CustomerId = dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString();

            frm.Show();
            
        }

		private void button2_Click(object sender, EventArgs e)
		{
			frmAddCustomer frm = new frmAddCustomer();
			frm.Show();
		}
	}
}
