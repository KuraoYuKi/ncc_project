using MySql.Data.MySqlClient;
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
    public partial class Welcome : Form
    {
        public static string book_menu_order;
        Controller.DB_Booking_System db_customer_book = new Controller.DB_Booking_System();
        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            acc_btn.Text = Login.name;
            acc_btn.FlatAppearance.BorderSize = 0;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Login login = new Booking_System_GUI.Login();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setA_order_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Booking bk = new Booking_System_GUI.Booking();
            book_menu_order = "Set A";
            bk.Show();
            this.Hide();
        }

        private void setB_order_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Booking bk = new Booking_System_GUI.Booking();
            book_menu_order = "Set B";
            bk.Show();
            this.Hide();
        }

        private void setC_order_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Booking bk = new Booking_System_GUI.Booking();
            book_menu_order = "Set C";
            bk.Show();
            this.Hide();
        }

        private void welcome_menu_bg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booking_update_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Booking bk = new Booking_System_GUI.Booking();
            bk.Show();
            this.Hide();
        }

        private void booking_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Booking bk = new Booking_System_GUI.Booking();
            bk.Show();
            this.Hide();
        }

        private void review_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Review rev = new Booking_System_GUI.Review();
            rev.Show();
        }

        private void acc_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
