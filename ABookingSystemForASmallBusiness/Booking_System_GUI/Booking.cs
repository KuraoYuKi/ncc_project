using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        Controller.DB_Booking_System db_customer_book = new Controller.DB_Booking_System();
        MySqlCommand command;
        MySqlDataReader reader;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void ordered_set_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void reserve_book_Click(object sender, EventArgs e)
        {
            string query = "Insert into booking(name,contact,address,menu,person,book_table,date,time) values('" + book_name_txt.Text + "','" + book_contact_txt.Text + "','" + book_address_txt.Text + "','" + book_menu.Text + "','" + book_persons.Text + "','" + book_table.Text + "','" + book_date.Text + "','" + book_time.Text + "')";
            db_customer_book.connection_open();
            adapter.InsertCommand = new MySqlCommand(query, db_customer_book.MySqlConnection);
            adapter.InsertCommand.ExecuteNonQuery();
            
            command = new MySqlCommand(query, db_customer_book.MySqlConnection);
            command.Dispose();
            MessageBox.Show("Booking Success");
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            book_name_txt.Text = Login.name;
            book_menu.Text = Welcome.book_menu_order;

            string query = "Select * from booking where name = '" + Login.name + "'";
            db_customer_book.connection_open();
            command = new MySqlCommand(query, db_customer_book.MySqlConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                book_name_txt.Text = reader["name"].ToString();
                book_contact_txt.Text = reader["contact"].ToString();
                book_address_txt.Text = reader["address"].ToString();
                book_menu.Text = reader["menu"].ToString();
                book_persons.Text = reader["person"].ToString();
                book_table.Text = reader["book_table"].ToString();
                book_date.Text = reader["date"].ToString();
                book_time.Text = reader["time"].ToString();
            }
            command.Dispose();
            db_customer_book.MySqlConnection.Close();

        }

        private void lbl_menu_order_Click(object sender, EventArgs e)
        {

        }

        private void show_book_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BindingSource bindingSource = new BindingSource();
            customer_book_data.DataSource = bindingSource;

            string query = "Select * from booking where name = '" + book_name_txt.Text + "'";
            db_customer_book.connection_open();
            adapter.SelectCommand = new MySqlCommand(query, db_customer_book.MySqlConnection);
            adapter.Fill(dt);

            bindingSource.DataSource = dt;
            customer_book_data.DataSource = bindingSource;
        }

        private void cancel_book_Click(object sender, EventArgs e)
        {
            Booking_System_GUI.Welcome wp = new Booking_System_GUI.Welcome();
            wp.Show();
            this.Hide();
        }

        private void update_book_Click(object sender, EventArgs e)
        {
            MessageBox.Show(book_menu.Text);
            //string query = "Update booking set contact = '" + book_contact_txt.Text + "' ,  address = '" + book_address_txt.Text +
            //    "',  menu = '" + book_menu.Text + "', person = '" + book_persons.Text + "' , book_table = '" + book_table.Text +
            //    "' , date = '" + book_date.Text + "' , time = '" + book_time.Text + "' where name = '" + Login.name + "'";
            string query="update booking set contact = '"+"091234444444444"+"' , menu = '"+"Set Y"+"' where name = '"+"aunt_mary"+"'";
            //MessageBox.Show(Login.name); 
            try
            {
                command = new MySqlCommand(query, db_customer_book.MySqlConnection);
                //adapter.UpdateCommand = new MySqlCommand(query, db_customer_book.MySqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Updating Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
