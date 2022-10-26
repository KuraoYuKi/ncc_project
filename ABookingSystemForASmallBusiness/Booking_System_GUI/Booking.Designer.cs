namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.booking_heading = new System.Windows.Forms.Label();
            this.booking_bg = new System.Windows.Forms.Panel();
            this.book_time = new System.Windows.Forms.ComboBox();
            this.time_label = new System.Windows.Forms.Label();
            this.book_date = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.book_table = new System.Windows.Forms.ComboBox();
            this.tabel_label = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.book_persons = new System.Windows.Forms.ComboBox();
            this.person_label = new System.Windows.Forms.Label();
            this.customer_book_data = new System.Windows.Forms.DataGridView();
            this.cancel_book = new System.Windows.Forms.Button();
            this.show_book = new System.Windows.Forms.Button();
            this.reserve_book = new System.Windows.Forms.Button();
            this.book_contact_txt = new System.Windows.Forms.TextBox();
            this.contact_label = new System.Windows.Forms.Label();
            this.book_address_txt = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.book_name_txt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.book_menu = new System.Windows.Forms.ComboBox();
            this.menu_label = new System.Windows.Forms.Label();
            this.update_book = new System.Windows.Forms.Button();
            this.delete_book = new System.Windows.Forms.Button();
            this.booking_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_book_data)).BeginInit();
            this.SuspendLayout();
            // 
            // booking_heading
            // 
            this.booking_heading.AutoSize = true;
            this.booking_heading.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_heading.Location = new System.Drawing.Point(485, 12);
            this.booking_heading.Name = "booking_heading";
            this.booking_heading.Size = new System.Drawing.Size(129, 34);
            this.booking_heading.TabIndex = 0;
            this.booking_heading.Text = "Booking";
            // 
            // booking_bg
            // 
            this.booking_bg.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.booking_bg.Controls.Add(this.delete_book);
            this.booking_bg.Controls.Add(this.update_book);
            this.booking_bg.Controls.Add(this.menu_label);
            this.booking_bg.Controls.Add(this.book_menu);
            this.booking_bg.Controls.Add(this.book_time);
            this.booking_bg.Controls.Add(this.time_label);
            this.booking_bg.Controls.Add(this.book_date);
            this.booking_bg.Controls.Add(this.date_label);
            this.booking_bg.Controls.Add(this.book_table);
            this.booking_bg.Controls.Add(this.tabel_label);
            this.booking_bg.Controls.Add(this.note);
            this.booking_bg.Controls.Add(this.book_persons);
            this.booking_bg.Controls.Add(this.person_label);
            this.booking_bg.Controls.Add(this.customer_book_data);
            this.booking_bg.Controls.Add(this.cancel_book);
            this.booking_bg.Controls.Add(this.show_book);
            this.booking_bg.Controls.Add(this.reserve_book);
            this.booking_bg.Controls.Add(this.book_contact_txt);
            this.booking_bg.Controls.Add(this.contact_label);
            this.booking_bg.Controls.Add(this.book_address_txt);
            this.booking_bg.Controls.Add(this.address_label);
            this.booking_bg.Controls.Add(this.book_name_txt);
            this.booking_bg.Controls.Add(this.name_label);
            this.booking_bg.ForeColor = System.Drawing.Color.DarkRed;
            this.booking_bg.Location = new System.Drawing.Point(12, 57);
            this.booking_bg.Name = "booking_bg";
            this.booking_bg.Size = new System.Drawing.Size(1070, 434);
            this.booking_bg.TabIndex = 1;
            // 
            // book_time
            // 
            this.book_time.FormattingEnabled = true;
            this.book_time.Items.AddRange(new object[] {
            "10 : 00 AM",
            "10 : 30 AM",
            "11 : 00 AM",
            "11 : 30 AM",
            "12 : 00 PM",
            "12 : 30 PM",
            "1 : 00 PM",
            "1 : 30 PM",
            "2 : 00 PM",
            "2 : 30 PM",
            "3 : 00 PM",
            "3 : 30 PM",
            "4 : 00 PM",
            "4 : 30 PM",
            "5 : 00 PM",
            "5 : 30 PM",
            "6 : 00 PM",
            "6 : 30 PM",
            "7 : 00 PM",
            "7 : 30 PM",
            "8 : 00 PM"});
            this.book_time.Location = new System.Drawing.Point(805, 123);
            this.book_time.Name = "book_time";
            this.book_time.Size = new System.Drawing.Size(249, 24);
            this.book_time.TabIndex = 21;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_label.Location = new System.Drawing.Point(801, 90);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(54, 22);
            this.time_label.TabIndex = 20;
            this.time_label.Text = "Time";
            // 
            // book_date
            // 
            this.book_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_date.Location = new System.Drawing.Point(544, 125);
            this.book_date.Name = "book_date";
            this.book_date.Size = new System.Drawing.Size(249, 22);
            this.book_date.TabIndex = 19;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.date_label.Location = new System.Drawing.Point(540, 90);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(53, 22);
            this.date_label.TabIndex = 16;
            this.date_label.Text = "Date";
            // 
            // book_table
            // 
            this.book_table.FormattingEnabled = true;
            this.book_table.Items.AddRange(new object[] {
            "1 Tabel",
            "2 Tabels",
            "3 Tabels",
            "4 Tabels",
            "5 Tabels"});
            this.book_table.Location = new System.Drawing.Point(280, 125);
            this.book_table.Name = "book_table";
            this.book_table.Size = new System.Drawing.Size(249, 24);
            this.book_table.TabIndex = 15;
            // 
            // tabel_label
            // 
            this.tabel_label.AutoSize = true;
            this.tabel_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabel_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabel_label.Location = new System.Drawing.Point(277, 90);
            this.tabel_label.Name = "tabel_label";
            this.tabel_label.Size = new System.Drawing.Size(59, 22);
            this.tabel_label.TabIndex = 14;
            this.tabel_label.Text = "Table";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(15, 164);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(1033, 32);
            this.note.TabIndex = 13;
            this.note.Text = resources.GetString("note.Text");
            // 
            // book_persons
            // 
            this.book_persons.FormattingEnabled = true;
            this.book_persons.Items.AddRange(new object[] {
            "1 Person",
            "2 Persons",
            "3 Persons",
            "4 Persons",
            "5 Persons",
            "6 Persons",
            "7 Persons",
            "8 Persons",
            "9 Persons",
            "10 Persons",
            "10 Persons Above"});
            this.book_persons.Location = new System.Drawing.Point(18, 125);
            this.book_persons.Name = "book_persons";
            this.book_persons.Size = new System.Drawing.Size(249, 24);
            this.book_persons.TabIndex = 12;
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.person_label.Location = new System.Drawing.Point(14, 90);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(73, 22);
            this.person_label.TabIndex = 11;
            this.person_label.Text = "Person";
            // 
            // customer_book_data
            // 
            this.customer_book_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_book_data.Location = new System.Drawing.Point(18, 260);
            this.customer_book_data.Name = "customer_book_data";
            this.customer_book_data.RowHeadersWidth = 51;
            this.customer_book_data.RowTemplate.Height = 24;
            this.customer_book_data.Size = new System.Drawing.Size(1036, 151);
            this.customer_book_data.TabIndex = 10;
            // 
            // cancel_book
            // 
            this.cancel_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_book.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_book.Location = new System.Drawing.Point(646, 209);
            this.cancel_book.Name = "cancel_book";
            this.cancel_book.Size = new System.Drawing.Size(199, 36);
            this.cancel_book.TabIndex = 9;
            this.cancel_book.Text = "Cancel";
            this.cancel_book.UseVisualStyleBackColor = false;
            this.cancel_book.Click += new System.EventHandler(this.cancel_book_Click);
            // 
            // show_book
            // 
            this.show_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.show_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_book.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_book.Location = new System.Drawing.Point(855, 209);
            this.show_book.Name = "show_book";
            this.show_book.Size = new System.Drawing.Size(199, 36);
            this.show_book.TabIndex = 7;
            this.show_book.Text = "Show";
            this.show_book.UseVisualStyleBackColor = false;
            this.show_book.Click += new System.EventHandler(this.show_book_Click);
            // 
            // reserve_book
            // 
            this.reserve_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reserve_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_book.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reserve_book.Location = new System.Drawing.Point(18, 209);
            this.reserve_book.Name = "reserve_book";
            this.reserve_book.Size = new System.Drawing.Size(199, 36);
            this.reserve_book.TabIndex = 6;
            this.reserve_book.Text = "Book";
            this.reserve_book.UseVisualStyleBackColor = false;
            this.reserve_book.Click += new System.EventHandler(this.reserve_book_Click);
            // 
            // book_contact_txt
            // 
            this.book_contact_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_contact_txt.Location = new System.Drawing.Point(281, 51);
            this.book_contact_txt.Name = "book_contact_txt";
            this.book_contact_txt.Size = new System.Drawing.Size(248, 24);
            this.book_contact_txt.TabIndex = 5;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contact_label.Location = new System.Drawing.Point(277, 16);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(158, 22);
            this.contact_label.TabIndex = 4;
            this.contact_label.Text = "Contact Number";
            // 
            // book_address_txt
            // 
            this.book_address_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_address_txt.Location = new System.Drawing.Point(544, 51);
            this.book_address_txt.Name = "book_address_txt";
            this.book_address_txt.Size = new System.Drawing.Size(249, 24);
            this.book_address_txt.TabIndex = 3;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.address_label.Location = new System.Drawing.Point(540, 16);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(81, 22);
            this.address_label.TabIndex = 2;
            this.address_label.Text = "Address";
            // 
            // book_name_txt
            // 
            this.book_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name_txt.Location = new System.Drawing.Point(18, 51);
            this.book_name_txt.Name = "book_name_txt";
            this.book_name_txt.Size = new System.Drawing.Size(249, 24);
            this.book_name_txt.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_label.Location = new System.Drawing.Point(14, 16);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(63, 22);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // book_menu
            // 
            this.book_menu.FormattingEnabled = true;
            this.book_menu.Items.AddRange(new object[] {
            "Set A",
            "Set B",
            "Set C"});
            this.book_menu.Location = new System.Drawing.Point(805, 51);
            this.book_menu.Name = "book_menu";
            this.book_menu.Size = new System.Drawing.Size(249, 24);
            this.book_menu.TabIndex = 23;
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_label.Location = new System.Drawing.Point(801, 16);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(61, 22);
            this.menu_label.TabIndex = 24;
            this.menu_label.Text = "Menu";
            // 
            // update_book
            // 
            this.update_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_book.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_book.Location = new System.Drawing.Point(228, 209);
            this.update_book.Name = "update_book";
            this.update_book.Size = new System.Drawing.Size(199, 36);
            this.update_book.TabIndex = 25;
            this.update_book.Text = "Update";
            this.update_book.UseVisualStyleBackColor = false;
            this.update_book.Click += new System.EventHandler(this.update_book_Click);
            // 
            // delete_book
            // 
            this.delete_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_book.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_book.Location = new System.Drawing.Point(437, 209);
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(199, 36);
            this.delete_book.TabIndex = 26;
            this.delete_book.Text = "Delete";
            this.delete_book.UseVisualStyleBackColor = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 507);
            this.Controls.Add(this.booking_bg);
            this.Controls.Add(this.booking_heading);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.booking_bg.ResumeLayout(false);
            this.booking_bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_book_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label booking_heading;
        private System.Windows.Forms.Panel booking_bg;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox book_contact_txt;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.TextBox book_address_txt;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox book_name_txt;
        private System.Windows.Forms.DataGridView customer_book_data;
        private System.Windows.Forms.Button cancel_book;
        private System.Windows.Forms.Button show_book;
        private System.Windows.Forms.Button reserve_book;
        private System.Windows.Forms.ComboBox book_persons;
        private System.Windows.Forms.Label person_label;
        private System.Windows.Forms.ComboBox book_table;
        private System.Windows.Forms.Label tabel_label;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker book_date;
        private System.Windows.Forms.ComboBox book_time;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.ComboBox book_menu;
        private System.Windows.Forms.Button update_book;
        private System.Windows.Forms.Button delete_book;
    }
}