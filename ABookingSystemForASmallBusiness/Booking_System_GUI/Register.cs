using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    public partial class Register : Form
    {
        public static Register rg;
        public string username, password, confirm_password;

        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Controller.DB_Booking_System db_bs = new Controller.DB_Booking_System();

        //check username length 
        bool check_un_length()
        {
            bool rt = false;
            username = username_textbox.Text;
            if (username.Length >= 4)
            {
                rt = true;
            }
            else
            {
                MessageBox.Show("Username must be at least 4 letters");
            }
            return rt;
        }

        //password and confirm password equality
        bool ps_sme_cps() //pwd_sme_cmpwd = password same with confirm password
        {
            bool rt = false;
            password = password_textbox.Text;
            confirm_password = textBox1.Text;
            if (password == confirm_password)
            {
                rt = true;
            }
            else
            {
                MessageBox.Show("Confirm Password isn't same with Password");
            }
            return rt;
        }

        //check password length 
        bool check_ps_length()
        {
            bool rt = false;
            password = password_textbox.Text;
            if (password.Length >= 6)
            {
                rt = true;
            }
            else
            {
                MessageBox.Show("Invalid Password Lenght" + "\n" + "Please put 6 characters");
            }
            return rt;
        }

        public Register()
        {
            InitializeComponent();
        }

        private void login_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var lg = new Login();
            Login.lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (check_un_length() && check_ps_length() && ps_sme_cps())
            {
                string query = "Insert into account(username, password) values('" + username_textbox.Text + "','" + password_textbox.Text + "')";

                db_bs.connection_open();
                adapter = new MySqlDataAdapter();
                adapter.InsertCommand = new MySqlCommand(query, db_bs.MySqlConnection);
                adapter.InsertCommand.ExecuteNonQuery();

                command = new MySqlCommand(query, db_bs.MySqlConnection);
                command.Dispose();
                MessageBox.Show("Registration Successful");

                Booking_System_GUI.Login lg = new Booking_System_GUI.Login();
                lg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration Unsuccessful");
            }
        }
    }
}
