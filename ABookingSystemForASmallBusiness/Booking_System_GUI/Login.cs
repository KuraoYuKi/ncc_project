using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    public partial class Login : Form
    {
        public static string name, pwd;

        Controller.DB_Booking_System db_bs = new Controller.DB_Booking_System();
        public Login()
        {
            InitializeComponent();
        }

        MySqlCommand command;
        MySqlDataReader reader;
        public static Login lg;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void register_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rg = new Register();
            Register.rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void LoginHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            name=username_textbox.Text;
            db_bs.connection_open();
            var user_account = new Login();
            string query = "Select username,password from account where username = '" + username_textbox.Text + "' and password='" + password_textbox.Text + "'";
            command = new MySqlCommand(query, db_bs.MySqlConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                name = reader.GetValue(0).ToString();
                pwd = reader.GetValue(1).ToString();
                break;
            }

            if (name == "Admin" && pwd == "admin")
            {
                Booking_System_GUI.Admin_Booking admin_book = new Booking_System_GUI.Admin_Booking();
                admin_book.Show();
                this.Hide();
            }
            else if (name == username_textbox.Text && pwd == password_textbox.Text)
            {
                Booking_System_GUI.Welcome wp = new Booking_System_GUI.Welcome();
                wp.Show();
                this.Hide();
            }
            else if (username_textbox.Text=="Admin")
            {
                Welcome wp = new Welcome();
                wp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
