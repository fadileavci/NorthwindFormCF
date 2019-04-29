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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }
        public string CustomerId=" ";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = OrderBLL.GetOrder(CustomerId);
            //dataGridView1.DataSource = OrderBLL.searchOrder(textBox1.Text);
            dataGridView1.DataSource = EmployeeBLL.searchOrderEmploye(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = OrderBLL.searchOrder(textBox1.Text);
            dataGridView1.DataSource = EmployeeBLL.searchOrderEmploye(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.searchOrderEmploye(textBox1.Text);
        }
    }
}
