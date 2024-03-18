namespace WinFormsApp1
{
    partial class SaleOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleOrder));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntype = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btndonban = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnhomepage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.numberamount = new System.Windows.Forms.NumericUpDown();
            this.txtamount = new System.Windows.Forms.Label();
            this.txtEP = new System.Windows.Forms.Label();
            this.txtidcustomer = new System.Windows.Forms.Label();
            this.txtidproduct = new System.Windows.Forms.Label();
            this.txbIdCus = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberamount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(17, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1751, 148);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(383, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALE ORDER INFORMATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btntype);
            this.panel1.Controls.Add(this.btncustomer);
            this.panel1.Controls.Add(this.btnsupplier);
            this.panel1.Controls.Add(this.btndonban);
            this.panel1.Controls.Add(this.btnproduct);
            this.panel1.Controls.Add(this.btnhomepage);
            this.panel1.Location = new System.Drawing.Point(17, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 658);
            this.panel1.TabIndex = 7;
            // 
            // btntype
            // 
            this.btntype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntype.ForeColor = System.Drawing.Color.DarkCyan;
            this.btntype.Image = ((System.Drawing.Image)(resources.GetObject("btntype.Image")));
            this.btntype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntype.Location = new System.Drawing.Point(57, 223);
            this.btntype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntype.Name = "btntype";
            this.btntype.Size = new System.Drawing.Size(211, 87);
            this.btntype.TabIndex = 12;
            this.btntype.Text = "PRODUCT TYPE";
            this.btntype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntype.UseVisualStyleBackColor = true;
            // 
            // btncustomer
            // 
            this.btncustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncustomer.ForeColor = System.Drawing.Color.DarkCyan;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(57, 548);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(211, 88);
            this.btncustomer.TabIndex = 10;
            this.btncustomer.Text = "CUSTOMER";
            this.btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnsupplier
            // 
            this.btnsupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsupplier.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnsupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnsupplier.Image")));
            this.btnsupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupplier.Location = new System.Drawing.Point(57, 439);
            this.btnsupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(211, 88);
            this.btnsupplier.TabIndex = 8;
            this.btnsupplier.Text = "SUPPLIER";
            this.btnsupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsupplier.UseVisualStyleBackColor = true;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // btndonban
            // 
            this.btndonban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndonban.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndonban.ForeColor = System.Drawing.Color.DarkCyan;
            this.btndonban.Image = ((System.Drawing.Image)(resources.GetObject("btndonban.Image")));
            this.btndonban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonban.Location = new System.Drawing.Point(57, 333);
            this.btndonban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndonban.Name = "btndonban";
            this.btndonban.Size = new System.Drawing.Size(211, 88);
            this.btndonban.TabIndex = 7;
            this.btndonban.Text = "SALES ORDER";
            this.btndonban.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndonban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndonban.UseVisualStyleBackColor = true;
            this.btndonban.Click += new System.EventHandler(this.btndonban_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnproduct.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnproduct.Image = ((System.Drawing.Image)(resources.GetObject("btnproduct.Image")));
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(57, 118);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(211, 87);
            this.btnproduct.TabIndex = 1;
            this.btnproduct.Text = "PRODUCT";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnhomepage
            // 
            this.btnhomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhomepage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnhomepage.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnhomepage.Image = ((System.Drawing.Image)(resources.GetObject("btnhomepage.Image")));
            this.btnhomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhomepage.Location = new System.Drawing.Point(57, 20);
            this.btnhomepage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhomepage.Name = "btnhomepage";
            this.btnhomepage.Size = new System.Drawing.Size(211, 88);
            this.btnhomepage.TabIndex = 0;
            this.btnhomepage.Text = "HOME PAGE";
            this.btnhomepage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhomepage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhomepage.UseVisualStyleBackColor = true;
            this.btnhomepage.Click += new System.EventHandler(this.btnhomepage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.txbID);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.numberamount);
            this.panel3.Controls.Add(this.txtamount);
            this.panel3.Controls.Add(this.txtEP);
            this.panel3.Controls.Add(this.txtidcustomer);
            this.panel3.Controls.Add(this.txtidproduct);
            this.panel3.Controls.Add(this.txbIdCus);
            this.panel3.Location = new System.Drawing.Point(381, 197);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1387, 197);
            this.panel3.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(661, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 33);
            this.comboBox1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 31);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(216, 20);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(233, 31);
            this.txbID.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Location = new System.Drawing.Point(77, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(70, 28);
            this.txtID.TabIndex = 24;
            this.txtID.Text = "ID Bill:";
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            // 
            // numberamount
            // 
            this.numberamount.Location = new System.Drawing.Point(1140, 108);
            this.numberamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberamount.Name = "numberamount";
            this.numberamount.Size = new System.Drawing.Size(213, 31);
            this.numberamount.TabIndex = 18;
            // 
            // txtamount
            // 
            this.txtamount.AutoSize = true;
            this.txtamount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtamount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtamount.Location = new System.Drawing.Point(1007, 117);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(91, 28);
            this.txtamount.TabIndex = 16;
            this.txtamount.Text = "Amount:";
            // 
            // txtEP
            // 
            this.txtEP.AutoSize = true;
            this.txtEP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEP.Location = new System.Drawing.Point(77, 117);
            this.txtEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEP.Name = "txtEP";
            this.txtEP.Size = new System.Drawing.Size(126, 28);
            this.txtEP.TabIndex = 14;
            this.txtEP.Text = "Export Price:";
            // 
            // txtidcustomer
            // 
            this.txtidcustomer.AutoSize = true;
            this.txtidcustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtidcustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtidcustomer.Location = new System.Drawing.Point(1007, 28);
            this.txtidcustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtidcustomer.Name = "txtidcustomer";
            this.txtidcustomer.Size = new System.Drawing.Size(132, 28);
            this.txtidcustomer.TabIndex = 12;
            this.txtidcustomer.Text = "ID Customer:";
            // 
            // txtidproduct
            // 
            this.txtidproduct.AutoSize = true;
            this.txtidproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtidproduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtidproduct.Location = new System.Drawing.Point(516, 30);
            this.txtidproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.Size = new System.Drawing.Size(114, 28);
            this.txtidproduct.TabIndex = 9;
            this.txtidproduct.Text = "ID Product:";
            // 
            // txbIdCus
            // 
            this.txbIdCus.Location = new System.Drawing.Point(1140, 28);
            this.txbIdCus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIdCus.Name = "txbIdCus";
            this.txbIdCus.Size = new System.Drawing.Size(211, 31);
            this.txbIdCus.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(17, 887);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 125);
            this.panel2.TabIndex = 20;
            // 
            // btnorder
            // 
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnorder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnorder.Location = new System.Drawing.Point(1128, 32);
            this.btnorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(143, 70);
            this.btnorder.TabIndex = 6;
            this.btnorder.Text = "ORDER";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexit.Location = new System.Drawing.Point(1545, 32);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(143, 70);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.Location = new System.Drawing.Point(1340, 32);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(143, 70);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.Location = new System.Drawing.Point(920, 32);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(143, 70);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(381, 433);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 422);
            this.panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(19, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 259);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID product";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // SaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 1038);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleOrder";
            this.Load += new System.EventHandler(this.SaleOrder_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberamount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel5;
        private Label label1;
        private Panel panel1;
        private Button btncustomer;
        private Button btnsupplier;
        private Button btndonban;
        private Button btnproduct;
        private Button btnhomepage;
        private Panel panel3;
        private NumericUpDown numberamount;
        private Label txtamount;
        private Label txtEP;
        private Label txtidcustomer;
        private Label txtidproduct;
        private TextBox txbIdCus;
        private Panel panel2;
        private Button btnexit;
        private Button btndelete;
        private Button btnadd;
        private Panel panel4;
        private Label txtID;
        private TextBox txbID;
        private Button btnorder;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btntype;
        private ComboBox comboBox1;
    }
}