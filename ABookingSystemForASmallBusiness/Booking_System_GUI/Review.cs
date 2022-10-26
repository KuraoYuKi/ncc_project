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
    public partial class Review : Form
    {
        Controller.DB_Booking_System db_customer_review = new Controller.DB_Booking_System();
        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Review()
        {
            InitializeComponent();
        }

        private void Review_Load(object sender, EventArgs e)
        {
            review_name_txt.Text = Login.name;
        }

        private void review_submit_Click(object sender, EventArgs e)
        {
            string query = "Insert into review(customer_name,review_text) values('" + review_name_txt.Text + "','" + review_txt.Text + "')";
            db_customer_review.connection_open();
            adapter.InsertCommand = new MySqlCommand(query, db_customer_review.MySqlConnection);
            adapter.InsertCommand.ExecuteNonQuery();

            command = new MySqlCommand(query, db_customer_review.MySqlConnection);
            command.Dispose();
            MessageBox.Show("Review Success");

            Booking_System_GUI.Welcome wp = new Booking_System_GUI.Welcome();
            wp.Show();
            this.Hide();
        }

        private void review_cancel_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Welcome wp = new Booking_System_GUI.Welcome();
            wp.Show();
            this.Hide();
        }
    }
}
