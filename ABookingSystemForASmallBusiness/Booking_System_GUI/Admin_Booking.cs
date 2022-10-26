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
    public partial class Admin_Booking : Form
    {
        public Admin_Booking()
        {
            InitializeComponent();
        }

        Controller.DB_Booking_System db_admin_book = new Controller.DB_Booking_System();
        MySqlCommand command;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void person_label_Click(object sender, EventArgs e)
        {

        }

        private void admin_book_Click(object sender, EventArgs e)
        {
            string query = "Insert into booking_order(name,contact,address,menu,person,table,date,time) values('" + name_adminbook_txt.Text + "','" + contact_adminbook_txt.Text + "','" + address_adminbook_txt.Text + "','" + menu_adminbook.Text + "','" + person_adminbook.Text + "','" + table_adminbook.Text + "','" + date_adminbook.Text + "','" + time_adminbook.Text + "')";
            adapter.InsertCommand = new MySqlCommand(query, db_admin_book.MySqlConnection);
            adapter.InsertCommand.ExecuteNonQuery();
            command = new MySqlCommand(query, db_admin_book.MySqlConnection);
            command.Dispose();
            MessageBox.Show("Booking Success");
        }

        private void admin_show_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BindingSource bindingSource = new BindingSource();
            admin_customer_book_data.DataSource = bindingSource;

            string query = "Select * from booking";
            db_admin_book.connection_open();
            adapter.SelectCommand = new MySqlCommand(query, db_admin_book.MySqlConnection);
            adapter.Fill(dt);

            bindingSource.DataSource = dt;
            admin_customer_book_data.DataSource = bindingSource;
        }

        private void admin_cancel_Click(object sender, EventArgs e)
        {
            int rowindex = admin_customer_book_data.CurrentCell.RowIndex;
            admin_customer_book_data.Rows.RemoveAt(rowindex);
            MessageBox.Show("Booking Cancel Successful");
        }
    }
}
