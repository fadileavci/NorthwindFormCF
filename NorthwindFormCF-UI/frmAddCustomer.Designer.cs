namespace NorthwindFormCF_UI
{
	partial class frmAddCustomer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.txtContactTitle = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Customer ID";
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(115, 61);
			this.txtCustomerId.MaxLength = 5;
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerId.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Company Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Contact Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Contact Title";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(49, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Address";
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(115, 102);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
			this.txtCompanyName.TabIndex = 10;
			// 
			// txtContactName
			// 
			this.txtContactName.Location = new System.Drawing.Point(115, 140);
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.Size = new System.Drawing.Size(100, 20);
			this.txtContactName.TabIndex = 11;
			// 
			// txtContactTitle
			// 
			this.txtContactTitle.Location = new System.Drawing.Point(115, 176);
			this.txtContactTitle.Name = "txtContactTitle";
			this.txtContactTitle.Size = new System.Drawing.Size(100, 20);
			this.txtContactTitle.TabIndex = 12;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(115, 215);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(100, 20);
			this.txtAddress.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(256, 283);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmAddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtContactTitle);
			this.Controls.Add(this.txtContactName);
			this.Controls.Add(this.txtCompanyName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.label1);
			this.Name = "frmAddCustomer";
			this.Text = "frmAddCustomer";
			this.Load += new System.EventHandler(this.frmAddCustomer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.TextBox txtContactName;
		private System.Windows.Forms.TextBox txtContactTitle;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button button1;
	}
}