using NorthwindFormCF_BLL;
using NorthwindFormCF_entity;
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
	public partial class frmAddCustomer : Form
	{
		public frmAddCustomer()
		{
			InitializeComponent();
		}

		private void frmAddCustomer_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();
			customer.CustomerID = txtCustomerId.Text.ToString();
			customer.ContactName = txtContactName.Text.ToString();
			customer.ContactTitle = txtContactTitle.Text.ToString();
			customer.CompanyName = txtCompanyName.Text.ToString();
			customer.Address = txtAddress.Text.ToString();
			customer.City ="istanbul";
			customer.Country ="sdfghj";
			customer.Fax ="fgh";
			customer.Phone ="fgh";
			customer.PostalCode ="bn";
			customer.Region =1;
			CustomerBLL.AddCustomer(customer);
			
		
		


		}
	}
}
