using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {

        string username = "admin";
        string password = "admin123";

        public Login()
        {
            InitializeComponent();
        }
        private void LogForm()
        {
            if(textBox1.Text == username  && textBox2.Text == password )
            {
               
                new Homepage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name or Password is incorrect", "Notification");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (checkLogin(txbUsername, Text, txbPassword, Text))
            {
                Homepage h = new Homepage();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Name or Password incorrect", "error");
                txbUsername.Focus();
            } */
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please complete all information", "Notification");
            }
            else
            {
                LogForm();
            }
           
                
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /*bool checkLogin(Label txbUsername, string username, Label txbPassword, string password)
        {
            if(username == this.username && password == this.password)
                return true;

            return false;
        }    */
    }
}
