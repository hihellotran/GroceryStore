namespace WinFormsApp1
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntype = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btndonban = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnhomepage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbstatus = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.Label();
            this.txtgiamua = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            this.cbbtype = new System.Windows.Forms.ComboBox();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbgiamua = new System.Windows.Forms.TextBox();
            this.txbgiaban = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(17, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 719);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btntype
            // 
            this.btntype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntype.ForeColor = System.Drawing.Color.DarkCyan;
            this.btntype.Image = ((System.Drawing.Image)(resources.GetObject("btntype.Image")));
            this.btntype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntype.Location = new System.Drawing.Point(57, 254);
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
            this.btncustomer.Location = new System.Drawing.Point(57, 609);
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
            this.btnsupplier.Location = new System.Drawing.Point(57, 490);
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
            this.btndonban.Location = new System.Drawing.Point(57, 373);
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
            this.btnproduct.Location = new System.Drawing.Point(57, 135);
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
            this.btnhomepage.Location = new System.Drawing.Point(57, 18);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(17, 841);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 114);
            this.panel2.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexit.Location = new System.Drawing.Point(1564, 25);
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
            this.btndelete.Location = new System.Drawing.Point(1356, 25);
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
            this.btnupdate.Location = new System.Drawing.Point(1145, 25);
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
            this.btnadd.Location = new System.Drawing.Point(935, 25);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(143, 70);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.txbquantity);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbstatus);
            this.panel3.Controls.Add(this.txtstatus);
            this.panel3.Controls.Add(this.txttype);
            this.panel3.Controls.Add(this.txtgiaban);
            this.panel3.Controls.Add(this.txtgiamua);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.cbbtype);
            this.panel3.Controls.Add(this.txbname);
            this.panel3.Controls.Add(this.txbgiamua);
            this.panel3.Controls.Add(this.txbgiaban);
            this.panel3.Controls.Add(this.txbid);
            this.panel3.Location = new System.Drawing.Point(356, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1408, 310);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txbquantity
            // 
            this.txbquantity.Location = new System.Drawing.Point(216, 236);
            this.txbquantity.Name = "txbquantity";
            this.txbquantity.Size = new System.Drawing.Size(233, 31);
            this.txbquantity.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(73, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity";
            // 
            // txbstatus
            // 
            this.txbstatus.Location = new System.Drawing.Point(1142, 135);
            this.txbstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbstatus.Name = "txbstatus";
            this.txbstatus.Size = new System.Drawing.Size(211, 31);
            this.txbstatus.TabIndex = 18;
            // 
            // txtstatus
            // 
            this.txtstatus.AutoSize = true;
            this.txtstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtstatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtstatus.Location = new System.Drawing.Point(955, 135);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(177, 28);
            this.txtstatus.TabIndex = 17;
            this.txtstatus.Text = "Status Of Product:";
            // 
            // txttype
            // 
            this.txttype.AutoSize = true;
            this.txttype.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txttype.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttype.Location = new System.Drawing.Point(971, 58);
            this.txttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(137, 28);
            this.txttype.TabIndex = 15;
            this.txttype.Text = "Type Product:";
            // 
            // txtgiaban
            // 
            this.txtgiaban.AutoSize = true;
            this.txtgiaban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtgiaban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtgiaban.Location = new System.Drawing.Point(526, 140);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(104, 28);
            this.txtgiaban.TabIndex = 14;
            this.txtgiaban.Text = "Sale Price:";
            // 
            // txtgiamua
            // 
            this.txtgiamua.AutoSize = true;
            this.txtgiamua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtgiamua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtgiamua.Location = new System.Drawing.Point(44, 143);
            this.txtgiamua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtgiamua.Name = "txtgiamua";
            this.txtgiamua.Size = new System.Drawing.Size(149, 28);
            this.txtgiamua.TabIndex = 13;
            this.txtgiamua.Text = "Purchase Price:";
            this.txtgiamua.Click += new System.EventHandler(this.txtgiamua_Click);
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Location = new System.Drawing.Point(526, 58);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 28);
            this.txtname.TabIndex = 12;
            this.txtname.Text = "Name Product:";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtid.Location = new System.Drawing.Point(99, 58);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 28);
            this.txtid.TabIndex = 9;
            this.txtid.Text = "ID Product:";
            // 
            // cbbtype
            // 
            this.cbbtype.FormattingEnabled = true;
            this.cbbtype.Items.AddRange(new object[] {
            "Cake-Candy",
            "Food",
            "Drink",
            "Seasoning",
            "Stationery"});
            this.cbbtype.Location = new System.Drawing.Point(1140, 58);
            this.cbbtype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbtype.Name = "cbbtype";
            this.cbbtype.Size = new System.Drawing.Size(211, 33);
            this.cbbtype.TabIndex = 7;
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(676, 48);
            this.txbname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(211, 31);
            this.txbname.TabIndex = 5;
            // 
            // txbgiamua
            // 
            this.txbgiamua.Location = new System.Drawing.Point(216, 143);
            this.txbgiamua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbgiamua.Name = "txbgiamua";
            this.txbgiamua.Size = new System.Drawing.Size(233, 31);
            this.txbgiamua.TabIndex = 3;
            // 
            // txbgiaban
            // 
            this.txbgiaban.Location = new System.Drawing.Point(676, 137);
            this.txbgiaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbgiaban.Name = "txbgiaban";
            this.txbgiaban.Size = new System.Drawing.Size(211, 31);
            this.txbgiaban.TabIndex = 1;
            // 
            // txbid
            // 
            this.txbid.Location = new System.Drawing.Point(216, 48);
            this.txbid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(233, 31);
            this.txbid.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.txbsearch);
            this.panel4.Controls.Add(this.btnsearch);
            this.panel4.Location = new System.Drawing.Point(356, 432);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1408, 399);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 249);
            this.dataGridView1.TabIndex = 8;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(17, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1751, 87);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(755, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(733, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1786, 966);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnexit;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label txttype;
        private Label txtgiaban;
        private Label txtgiamua;
        private Label txtname;
        private Label txtid;
        private TextBox txbname;
        private TextBox txbgiamua;
        private TextBox txbgiaban;
        private TextBox txbid;
        private TextBox txbsearch;
        private Button btnsearch;
        private Label txtstatus;
        private Button btnproduct;
        private Button btnhomepage;
        private Button btncustomer;
        private Button btnsupplier;
        private Button btndonban;
        private DataGridView dataGridView1;
        private TextBox txbstatus;
        private ComboBox cbbtype;
        private Label label2;
        private Button btntype;
        private TextBox txbquantity;
        private Button button1;
    }
}