namespace WinFormsApp1
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnorder = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnsuplier = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(223, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO MY GROCERY STORE";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Teal;
            this.btnLogout.Location = new System.Drawing.Point(994, 563);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 62);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(1213, 563);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1401, 422);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnorder.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnorder.Image = ((System.Drawing.Image)(resources.GetObject("btnorder.Image")));
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.Location = new System.Drawing.Point(156, 369);
            this.btnorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(186, 91);
            this.btnorder.TabIndex = 11;
            this.btnorder.Text = "ORDER";
            this.btnorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnorder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click_1);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btncustomer.ForeColor = System.Drawing.Color.DarkCyan;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(1087, 194);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(186, 91);
            this.btncustomer.TabIndex = 12;
            this.btncustomer.Text = "CUSTOMER";
            this.btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click_1);
            // 
            // btnsuplier
            // 
            this.btnsuplier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsuplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnsuplier.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnsuplier.Image = ((System.Drawing.Image)(resources.GetObject("btnsuplier.Image")));
            this.btnsuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuplier.Location = new System.Drawing.Point(1087, 369);
            this.btnsuplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsuplier.Name = "btnsuplier";
            this.btnsuplier.Size = new System.Drawing.Size(186, 91);
            this.btnsuplier.TabIndex = 13;
            this.btnsuplier.Text = "SUPPLIER";
            this.btnsuplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsuplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsuplier.UseVisualStyleBackColor = false;
            this.btnsuplier.Click += new System.EventHandler(this.btnsuplier_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnproduct.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnproduct.Image = ((System.Drawing.Image)(resources.GetObject("btnproduct.Image")));
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(156, 194);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(186, 91);
            this.btnproduct.TabIndex = 15;
            this.btnproduct.Text = "PRODUCT";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click_1);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1399, 655);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btnsuplier);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btnLogout;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnorder;
        private Button btncustomer;
        private Button btnsuplier;
        private Button btnproduct;
    }
}