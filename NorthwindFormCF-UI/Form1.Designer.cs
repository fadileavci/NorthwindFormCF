namespace NorthwindFormCF_UI
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.getOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnGetir = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(77, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(608, 276);
			this.dataGridView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getOrderToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(126, 26);
			// 
			// getOrderToolStripMenuItem
			// 
			this.getOrderToolStripMenuItem.Name = "getOrderToolStripMenuItem";
			this.getOrderToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.getOrderToolStripMenuItem.Text = "Get Order";
			this.getOrderToolStripMenuItem.Click += new System.EventHandler(this.getOrderToolStripMenuItem_Click);
			// 
			// btnGetir
			// 
			this.btnGetir.Location = new System.Drawing.Point(474, 367);
			this.btnGetir.Name = "btnGetir";
			this.btnGetir.Size = new System.Drawing.Size(127, 23);
			this.btnGetir.TabIndex = 1;
			this.btnGetir.Text = "Get Customer";
			this.btnGetir.UseVisualStyleBackColor = true;
			this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(203, 367);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Add Customer";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 422);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnGetir);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getOrderToolStripMenuItem;
		private System.Windows.Forms.Button button2;
	}
}

