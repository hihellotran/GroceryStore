namespace WinFormsApp1.Boundary
{
    partial class BillDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.txtIDBill = new System.Windows.Forms.Label();
            this.txbIDBill = new System.Windows.Forms.TextBox();
            this.txbIDProduct = new System.Windows.Forms.TextBox();
            this.txtIDProduct = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(424, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILL DETAIL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 150);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txbQuantity);
            this.panel2.Controls.Add(this.txtIDBill);
            this.panel2.Controls.Add(this.txbIDBill);
            this.panel2.Controls.Add(this.txbIDProduct);
            this.panel2.Controls.Add(this.txtIDProduct);
            this.panel2.Location = new System.Drawing.Point(12, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 154);
            this.panel2.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Location = new System.Drawing.Point(903, 61);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(95, 28);
            this.txtQuantity.TabIndex = 30;
            this.txtQuantity.Text = "Quantity:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(1006, 61);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(233, 31);
            this.txbQuantity.TabIndex = 29;
            // 
            // txtIDBill
            // 
            this.txtIDBill.AutoSize = true;
            this.txtIDBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDBill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDBill.Location = new System.Drawing.Point(521, 64);
            this.txtIDBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.Size = new System.Drawing.Size(70, 28);
            this.txtIDBill.TabIndex = 28;
            this.txtIDBill.Text = "ID Bill:";
            // 
            // txbIDBill
            // 
            this.txbIDBill.Location = new System.Drawing.Point(599, 61);
            this.txbIDBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIDBill.Name = "txbIDBill";
            this.txbIDBill.Size = new System.Drawing.Size(233, 31);
            this.txbIDBill.TabIndex = 27;
            // 
            // txbIDProduct
            // 
            this.txbIDProduct.Location = new System.Drawing.Point(225, 61);
            this.txbIDProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIDProduct.Name = "txbIDProduct";
            this.txbIDProduct.Size = new System.Drawing.Size(233, 31);
            this.txbIDProduct.TabIndex = 26;
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.AutoSize = true;
            this.txtIDProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDProduct.Location = new System.Drawing.Point(103, 61);
            this.txtIDProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(114, 28);
            this.txtIDProduct.TabIndex = 25;
            this.txtIDProduct.Text = "ID Product:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.txbsearch);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1319, 498);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 347);
            this.dataGridView1.TabIndex = 9;
            // 
            // txbsearch
            // 
            this.txbsearch.Location = new System.Drawing.Point(651, 28);
            this.txbsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbsearch.Multiline = true;
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(437, 54);
            this.txbsearch.TabIndex = 8;
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsearch.Location = new System.Drawing.Point(1119, 28);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(157, 57);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.btnexit);
            this.panel4.Controls.Add(this.btnback);
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Location = new System.Drawing.Point(12, 877);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1319, 142);
            this.panel4.TabIndex = 4;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexit.Location = new System.Drawing.Point(1143, 40);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(143, 70);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnback.Location = new System.Drawing.Point(971, 40);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(143, 70);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.Location = new System.Drawing.Point(790, 40);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(143, 70);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnupdate.Location = new System.Drawing.Point(599, 40);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(143, 70);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.Location = new System.Drawing.Point(407, 40);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(143, 70);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // BillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 1031);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label txtIDProduct;
        private Label txtIDBill;
        private TextBox txbIDBill;
        private TextBox txbIDProduct;
        private Label txtQuantity;
        private TextBox txbQuantity;
        private Button btnsearch;
        private TextBox txbsearch;
        private DataGridView dataGridView1;
        private Button btnadd;
        private Button btnupdate;
        private Button btnback;
        private Button btndelete;
        private Button btnexit;
    }
}