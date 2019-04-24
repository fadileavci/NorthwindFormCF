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
            dataGridView1.DataSource = OrderBLL.GetOrder(CustomerId);
        }
    }
}
