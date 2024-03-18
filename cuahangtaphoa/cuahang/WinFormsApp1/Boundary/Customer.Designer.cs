namespace WinFormsApp1
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
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
            this.cbbsex = new System.Windows.Forms.ComboBox();
            this.txtsex = new System.Windows.Forms.Label();
            this.txbphone = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(17, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1751, 106);
            this.panel5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(728, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER";
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
            this.panel1.Location = new System.Drawing.Point(17, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 725);
            this.panel1.TabIndex = 8;
            // 
            // btntype
            // 
            this.btntype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntype.ForeColor = System.Drawing.Color.DarkCyan;
            this.btntype.Image = ((System.Drawing.Image)(resources.GetObject("btntype.Image")));
            this.btntype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntype.Location = new System.Drawing.Point(57, 242);
            this.btntype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntype.Name = "btntype";
            this.btntype.Size = new System.Drawing.Size(211, 87);
            this.btntype.TabIndex = 12;
            this.btntype.Text = "PRODUCT TYPE";
            this.btntype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntype.UseVisualStyleBackColor = true;
            this.btntype.Click += new System.EventHandler(this.btntype_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncustomer.ForeColor = System.Drawing.Color.DarkCyan;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(57, 595);
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
            this.btnsupplier.Location = new System.Drawing.Point(57, 472);
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
            this.btndonban.Location = new System.Drawing.Point(57, 359);
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
            this.btnproduct.Location = new System.Drawing.Point(57, 132);
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
            this.panel3.Controls.Add(this.cbbsex);
            this.panel3.Controls.Add(this.txtsex);
            this.panel3.Controls.Add(this.txbphone);
            this.panel3.Controls.Add(this.txbemail);
            this.panel3.Controls.Add(this.txbaddress);
            this.panel3.Controls.Add(this.txbname);
            this.panel3.Controls.Add(this.txbid);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Controls.Add(this.txtaddress);
            this.panel3.Controls.Add(this.txtphone);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Location = new System.Drawing.Point(356, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1412, 289);
            this.panel3.TabIndex = 10;
            // 
            // cbbsex
            // 
            this.cbbsex.FormattingEnabled = true;
            this.cbbsex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbbsex.Location = new System.Drawing.Point(671, 205);
            this.cbbsex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbsex.Name = "cbbsex";
            this.cbbsex.Size = new System.Drawing.Size(217, 33);
            this.cbbsex.TabIndex = 11;
            this.cbbsex.Text = "Female";
            // 
            // txtsex
            // 
            this.txtsex.AutoSize = true;
            this.txtsex.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtsex.Location = new System.Drawing.Point(606, 208);
            this.txtsex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(47, 28);
            this.txtsex.TabIndex = 10;
            this.txtsex.Text = "Sex:";
            // 
            // txbphone
            // 
            this.txbphone.Location = new System.Drawing.Point(1136, 205);
            this.txbphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbphone.Name = "txbphone";
            this.txbphone.Size = new System.Drawing.Size(217, 31);
            this.txbphone.TabIndex = 9;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(203, 205);
            this.txbemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(217, 31);
            this.txbemail.TabIndex = 8;
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(1136, 70);
            this.txbaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(217, 31);
            this.txbaddress.TabIndex = 7;
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(682, 70);
            this.txbname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(217, 31);
            this.txbname.TabIndex = 6;
            // 
            // txbid
            // 
            this.txbid.Location = new System.Drawing.Point(203, 70);
            this.txbid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(217, 31);
            this.txbid.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtemail.Location = new System.Drawing.Point(127, 205);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(68, 28);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "Email:";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(511, 73);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 28);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "Name Customer:";
            // 
            // txtaddress
            // 
            this.txtaddress.AutoSize = true;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtaddress.Location = new System.Drawing.Point(1024, 73);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(86, 28);
            this.txtaddress.TabIndex = 2;
            this.txtaddress.Text = "Address:";
            // 
            // txtphone
            // 
            this.txtphone.AutoSize = true;
            this.txtphone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtphone.Location = new System.Drawing.Point(957, 205);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(153, 28);
            this.txtphone.TabIndex = 1;
            this.txtphone.Text = "Phone Number:";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(65, 73);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 28);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "ID Customer:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(13, 877);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 113);
            this.panel2.TabIndex = 11;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexit.Location = new System.Drawing.Point(1549, 18);
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
            this.btndelete.Location = new System.Drawing.Point(1306, 18);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(143, 70);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnupdate.Location = new System.Drawing.Point(1050, 18);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(143, 70);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.Location = new System.Drawing.Point(801, 18);
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
            this.panel4.Controls.Add(this.txbsearch);
            this.panel4.Controls.Add(this.btnsearch);
            this.panel4.Location = new System.Drawing.Point(356, 429);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1412, 426);
            this.panel4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1336, 282);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txbsearch
            // 
            this.txbsearch.Location = new System.Drawing.Point(711, 20);
            this.txbsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbsearch.Multiline = true;
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(437, 54);
            this.txbsearch.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsearch.Location = new System.Drawing.Point(1196, 20);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(157, 57);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1786, 1004);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private TextBox txbphone;
        private TextBox txbemail;
        private TextBox txbaddress;
        private TextBox txbname;
        private TextBox txbid;
        private Label txtemail;
        private Label txtname;
        private Label txtaddress;
        private Label txtphone;
        private Label txtid;
        private Panel panel2;
        private Button btnexit;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private ComboBox cbbsex;
        private Label txtsex;
        private Panel panel4;
        private TextBox txbsearch;
        private Button btnsearch;
        private DataGridView dataGridView1;
        private Button btntype;
    }
}