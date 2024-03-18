namespace WinFormsApp1
{
    partial class ImportOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportOrder));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.textIDip = new System.Windows.Forms.TextBox();
            this.txtIDip = new System.Windows.Forms.Label();
            this.numberamount = new System.Windows.Forms.NumericUpDown();
            this.txbidsupplier = new System.Windows.Forms.TextBox();
            this.txtloinhuan = new System.Windows.Forms.Label();
            this.txtgiamua = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtidsupplier = new System.Windows.Forms.Label();
            this.txtidproduct = new System.Windows.Forms.Label();
            this.txbidproduct = new System.Windows.Forms.TextBox();
            this.txbgiamua = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberamount)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(401, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1111, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORT ORDER INFORMATION";
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
            this.panel1.Location = new System.Drawing.Point(17, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 713);
            this.panel1.TabIndex = 6;
            // 
            // btntype
            // 
            this.btntype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntype.ForeColor = System.Drawing.Color.DarkCyan;
            this.btntype.Image = ((System.Drawing.Image)(resources.GetObject("btntype.Image")));
            this.btntype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntype.Location = new System.Drawing.Point(57, 262);
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
            this.btncustomer.Location = new System.Drawing.Point(57, 605);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(211, 88);
            this.btncustomer.TabIndex = 10;
            this.btncustomer.Text = "CUSTOMER";
            this.btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = true;
            // 
            // btnsupplier
            // 
            this.btnsupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsupplier.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnsupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnsupplier.Image")));
            this.btnsupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupplier.Location = new System.Drawing.Point(57, 492);
            this.btnsupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(211, 88);
            this.btnsupplier.TabIndex = 8;
            this.btnsupplier.Text = "SUPPLIER";
            this.btnsupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsupplier.UseVisualStyleBackColor = true;
            // 
            // btndonban
            // 
            this.btndonban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndonban.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndonban.ForeColor = System.Drawing.Color.DarkCyan;
            this.btndonban.Image = ((System.Drawing.Image)(resources.GetObject("btndonban.Image")));
            this.btndonban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonban.Location = new System.Drawing.Point(57, 381);
            this.btndonban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndonban.Name = "btndonban";
            this.btndonban.Size = new System.Drawing.Size(211, 88);
            this.btndonban.TabIndex = 7;
            this.btndonban.Text = "SALE ORDER";
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
            this.btnproduct.Location = new System.Drawing.Point(57, 137);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(17, 953);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 125);
            this.panel2.TabIndex = 7;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexit.Location = new System.Drawing.Point(1574, 32);
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
            this.btndelete.Location = new System.Drawing.Point(1371, 32);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(143, 70);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnupdate.Location = new System.Drawing.Point(1159, 32);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(143, 70);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.Location = new System.Drawing.Point(949, 32);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(143, 70);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.textIDip);
            this.panel3.Controls.Add(this.txtIDip);
            this.panel3.Controls.Add(this.numberamount);
            this.panel3.Controls.Add(this.txbidsupplier);
            this.panel3.Controls.Add(this.txtloinhuan);
            this.panel3.Controls.Add(this.txtgiamua);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtidsupplier);
            this.panel3.Controls.Add(this.txtidproduct);
            this.panel3.Controls.Add(this.txbidproduct);
            this.panel3.Controls.Add(this.txbgiamua);
            this.panel3.Controls.Add(this.txbid);
            this.panel3.Location = new System.Drawing.Point(381, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1387, 218);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textIDip
            // 
            this.textIDip.Location = new System.Drawing.Point(216, 145);
            this.textIDip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textIDip.Name = "textIDip";
            this.textIDip.Size = new System.Drawing.Size(233, 31);
            this.textIDip.TabIndex = 20;
            // 
            // txtIDip
            // 
            this.txtIDip.AutoSize = true;
            this.txtIDip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDip.Location = new System.Drawing.Point(37, 147);
            this.txtIDip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIDip.Name = "txtIDip";
            this.txtIDip.Size = new System.Drawing.Size(165, 28);
            this.txtIDip.TabIndex = 19;
            this.txtIDip.Text = "ID Import Order:";
            // 
            // numberamount
            // 
            this.numberamount.Location = new System.Drawing.Point(1140, 137);
            this.numberamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberamount.Name = "numberamount";
            this.numberamount.Size = new System.Drawing.Size(213, 31);
            this.numberamount.TabIndex = 18;
            // 
            // txbidsupplier
            // 
            this.txbidsupplier.Location = new System.Drawing.Point(1140, 57);
            this.txbidsupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbidsupplier.Name = "txbidsupplier";
            this.txbidsupplier.Size = new System.Drawing.Size(211, 31);
            this.txbidsupplier.TabIndex = 17;
            // 
            // txtloinhuan
            // 
            this.txtloinhuan.AutoSize = true;
            this.txtloinhuan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtloinhuan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtloinhuan.Location = new System.Drawing.Point(1031, 147);
            this.txtloinhuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtloinhuan.Name = "txtloinhuan";
            this.txtloinhuan.Size = new System.Drawing.Size(91, 28);
            this.txtloinhuan.TabIndex = 16;
            this.txtloinhuan.Text = "Amount:";
            // 
            // txtgiamua
            // 
            this.txtgiamua.AutoSize = true;
            this.txtgiamua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtgiamua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtgiamua.Location = new System.Drawing.Point(526, 150);
            this.txtgiamua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtgiamua.Name = "txtgiamua";
            this.txtgiamua.Size = new System.Drawing.Size(130, 28);
            this.txtgiamua.TabIndex = 13;
            this.txtgiamua.Text = "Import Price:";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Location = new System.Drawing.Point(141, 57);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(37, 28);
            this.txtID.TabIndex = 12;
            this.txtID.Text = "ID:";
            // 
            // txtidsupplier
            // 
            this.txtidsupplier.AutoSize = true;
            this.txtidsupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtidsupplier.Location = new System.Drawing.Point(1007, 57);
            this.txtidsupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtidsupplier.Name = "txtidsupplier";
            this.txtidsupplier.Size = new System.Drawing.Size(117, 28);
            this.txtidsupplier.TabIndex = 11;
            this.txtidsupplier.Text = "ID Supplier:";
            // 
            // txtidproduct
            // 
            this.txtidproduct.AutoSize = true;
            this.txtidproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtidproduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtidproduct.Location = new System.Drawing.Point(526, 58);
            this.txtidproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.Size = new System.Drawing.Size(114, 28);
            this.txtidproduct.TabIndex = 9;
            this.txtidproduct.Text = "ID Product:";
            // 
            // txbidproduct
            // 
            this.txbidproduct.Location = new System.Drawing.Point(676, 48);
            this.txbidproduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbidproduct.Name = "txbidproduct";
            this.txbidproduct.Size = new System.Drawing.Size(211, 31);
            this.txbidproduct.TabIndex = 5;
            // 
            // txbgiamua
            // 
            this.txbgiamua.Location = new System.Drawing.Point(676, 140);
            this.txbgiamua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbgiamua.Name = "txbgiamua";
            this.txbgiamua.Size = new System.Drawing.Size(211, 31);
            this.txbgiamua.TabIndex = 3;
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
            this.panel4.Controls.Add(this.txbsearch);
            this.panel4.Controls.Add(this.btnsearch);
            this.panel4.Location = new System.Drawing.Point(381, 462);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 452);
            this.panel4.TabIndex = 9;
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
            // 
            // ImportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1786, 1098);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportOrder";
            this.Load += new System.EventHandler(this.ImportOrder_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberamount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private Panel panel2;
        private Button btnexit;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private Panel panel3;
        private Label txtloinhuan;
        private Label txtgiamua;
        private Label txtID;
        private Label txtidsupplier;
        private Label txtidproduct;
        private TextBox txbidproduct;
        private TextBox txbgiamua;
        private TextBox txbid;
        private Panel panel4;
        private TextBox txbsearch;
        private Button btnsearch;
        private TextBox txbidsupplier;
        private NumericUpDown numberamount;
        private Label txtIDip;
        private TextBox textIDip;
        private Button btntype;
    }
}