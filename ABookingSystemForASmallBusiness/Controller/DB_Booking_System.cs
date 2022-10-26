using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABookingSystemForASmallBusiness.Controller
{
    class DB_Booking_System
    {
        public MySqlConnection MySqlConnection;
        private string connection = "server = localhost; uid = root; pwd = ; database = booking_system";
        public void connection_open()
        {
            try
            {
                MySqlConnection = new MySqlConnection(connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlConnection.Open();
            }
            catch (Exception error_message)
            {
                MessageBox.Show($"error occur : {error_message.Message}");
            }
        }
    }
}
