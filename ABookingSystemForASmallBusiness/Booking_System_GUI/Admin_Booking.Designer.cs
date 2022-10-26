namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    partial class Admin_Booking
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_adminbook_txt = new System.Windows.Forms.TextBox();
            this.contact_adminbook_txt = new System.Windows.Forms.TextBox();
            this.contact_label = new System.Windows.Forms.Label();
            this.address_adminbook_txt = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.person_label = new System.Windows.Forms.Label();
            this.person_adminbook = new System.Windows.Forms.ComboBox();
            this.table_adminbook = new System.Windows.Forms.ComboBox();
            this.table_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.time_adminbook = new System.Windows.Forms.ComboBox();
            this.time_label = new System.Windows.Forms.Label();
            this.menu_adminbook = new System.Windows.Forms.ComboBox();
            this.menu_label = new System.Windows.Forms.Label();
            this.date_adminbook = new System.Windows.Forms.DateTimePicker();
            this.admin_cancel = new System.Windows.Forms.Button();
            this.admin_update = new System.Windows.Forms.Button();
            this.admin_show = new System.Windows.Forms.Button();
            this.admin_book = new System.Windows.Forms.Button();
            this.admin_customer_book_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.admin_customer_book_data)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(12, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(56, 18);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // name_adminbook_txt
            // 
            this.name_adminbook_txt.Location = new System.Drawing.Point(15, 39);
            this.name_adminbook_txt.Name = "name_adminbook_txt";
            this.name_adminbook_txt.Size = new System.Drawing.Size(194, 22);
            this.name_adminbook_txt.TabIndex = 1;
            // 
            // contact_adminbook_txt
            // 
            this.contact_adminbook_txt.Location = new System.Drawing.Point(245, 39);
            this.contact_adminbook_txt.Name = "contact_adminbook_txt";
            this.contact_adminbook_txt.Size = new System.Drawing.Size(194, 22);
            this.contact_adminbook_txt.TabIndex = 3;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.Location = new System.Drawing.Point(242, 9);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(141, 18);
            this.contact_label.TabIndex = 2;
            this.contact_label.Text = "Contact Number";
            // 
            // address_adminbook_txt
            // 
            this.address_adminbook_txt.Location = new System.Drawing.Point(478, 39);
            this.address_adminbook_txt.Name = "address_adminbook_txt";
            this.address_adminbook_txt.Size = new System.Drawing.Size(194, 22);
            this.address_adminbook_txt.TabIndex = 5;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(475, 9);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(75, 18);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_label.Location = new System.Drawing.Point(9, 81);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(65, 18);
            this.person_label.TabIndex = 6;
            this.person_label.Text = "Person";
            this.person_label.Click += new System.EventHandler(this.person_label_Click);
            // 
            // person_adminbook
            // 
            this.person_adminbook.FormattingEnabled = true;
            this.person_adminbook.Items.AddRange(new object[] {
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
            this.person_adminbook.Location = new System.Drawing.Point(12, 113);
            this.person_adminbook.Name = "person_adminbook";
            this.person_adminbook.Size = new System.Drawing.Size(197, 24);
            this.person_adminbook.TabIndex = 7;
            // 
            // table_adminbook
            // 
            this.table_adminbook.FormattingEnabled = true;
            this.table_adminbook.Items.AddRange(new object[] {
            "1 Tabel",
            "2 Tabels",
            "3 Tabels",
            "4 Tabels",
            "5 Tabels"});
            this.table_adminbook.Location = new System.Drawing.Point(245, 113);
            this.table_adminbook.Name = "table_adminbook";
            this.table_adminbook.Size = new System.Drawing.Size(194, 24);
            this.table_adminbook.TabIndex = 9;
            // 
            // table_label
            // 
            this.table_label.AutoSize = true;
            this.table_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_label.Location = new System.Drawing.Point(245, 81);
            this.table_label.Name = "table_label";
            this.table_label.Size = new System.Drawing.Size(52, 18);
            this.table_label.TabIndex = 8;
            this.table_label.Text = "Table";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(478, 81);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(47, 18);
            this.date_label.TabIndex = 10;
            this.date_label.Text = "Date";
            // 
            // time_adminbook
            // 
            this.time_adminbook.FormattingEnabled = true;
            this.time_adminbook.Items.AddRange(new object[] {
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
            this.time_adminbook.Location = new System.Drawing.Point(707, 113);
            this.time_adminbook.Name = "time_adminbook";
            this.time_adminbook.Size = new System.Drawing.Size(197, 24);
            this.time_adminbook.TabIndex = 13;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(707, 81);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(48, 18);
            this.time_label.TabIndex = 12;
            this.time_label.Text = "Time";
            // 
            // menu_adminbook
            // 
            this.menu_adminbook.FormattingEnabled = true;
            this.menu_adminbook.Items.AddRange(new object[] {
            "Set A",
            "Set B",
            "Set C"});
            this.menu_adminbook.Location = new System.Drawing.Point(707, 37);
            this.menu_adminbook.Name = "menu_adminbook";
            this.menu_adminbook.Size = new System.Drawing.Size(197, 24);
            this.menu_adminbook.TabIndex = 15;
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label.Location = new System.Drawing.Point(707, 9);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(52, 18);
            this.menu_label.TabIndex = 14;
            this.menu_label.Text = "Menu";
            // 
            // date_adminbook
            // 
            this.date_adminbook.Location = new System.Drawing.Point(478, 113);
            this.date_adminbook.Name = "date_adminbook";
            this.date_adminbook.Size = new System.Drawing.Size(194, 22);
            this.date_adminbook.TabIndex = 16;
            // 
            // admin_cancel
            // 
            this.admin_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_cancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_cancel.Location = new System.Drawing.Point(478, 157);
            this.admin_cancel.Name = "admin_cancel";
            this.admin_cancel.Size = new System.Drawing.Size(194, 36);
            this.admin_cancel.TabIndex = 20;
            this.admin_cancel.Text = "Delete";
            this.admin_cancel.UseVisualStyleBackColor = false;
            this.admin_cancel.Click += new System.EventHandler(this.admin_cancel_Click);
            // 
            // admin_update
            // 
            this.admin_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_update.Location = new System.Drawing.Point(245, 157);
            this.admin_update.Name = "admin_update";
            this.admin_update.Size = new System.Drawing.Size(194, 36);
            this.admin_update.TabIndex = 19;
            this.admin_update.Text = "Update";
            this.admin_update.UseVisualStyleBackColor = false;
            // 
            // admin_show
            // 
            this.admin_show.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_show.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_show.Location = new System.Drawing.Point(707, 157);
            this.admin_show.Name = "admin_show";
            this.admin_show.Size = new System.Drawing.Size(197, 36);
            this.admin_show.TabIndex = 18;
            this.admin_show.Text = "Show";
            this.admin_show.UseVisualStyleBackColor = false;
            this.admin_show.Click += new System.EventHandler(this.admin_show_Click);
            // 
            // admin_book
            // 
            this.admin_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_book.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_book.Location = new System.Drawing.Point(12, 157);
            this.admin_book.Name = "admin_book";
            this.admin_book.Size = new System.Drawing.Size(197, 36);
            this.admin_book.TabIndex = 17;
            this.admin_book.Text = "Book";
            this.admin_book.UseVisualStyleBackColor = false;
            this.admin_book.Click += new System.EventHandler(this.admin_book_Click);
            // 
            // admin_customer_book_data
            // 
            this.admin_customer_book_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_customer_book_data.Location = new System.Drawing.Point(12, 216);
            this.admin_customer_book_data.Name = "admin_customer_book_data";
            this.admin_customer_book_data.RowHeadersWidth = 51;
            this.admin_customer_book_data.RowTemplate.Height = 24;
            this.admin_customer_book_data.Size = new System.Drawing.Size(892, 302);
            this.admin_customer_book_data.TabIndex = 21;
            // 
            // Admin_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 540);
            this.Controls.Add(this.admin_customer_book_data);
            this.Controls.Add(this.admin_cancel);
            this.Controls.Add(this.admin_update);
            this.Controls.Add(this.admin_show);
            this.Controls.Add(this.admin_book);
            this.Controls.Add(this.date_adminbook);
            this.Controls.Add(this.menu_adminbook);
            this.Controls.Add(this.menu_label);
            this.Controls.Add(this.time_adminbook);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.table_adminbook);
            this.Controls.Add(this.table_label);
            this.Controls.Add(this.person_adminbook);
            this.Controls.Add(this.person_label);
            this.Controls.Add(this.address_adminbook_txt);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.contact_adminbook_txt);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.name_adminbook_txt);
            this.Controls.Add(this.name_label);
            this.Name = "Admin_Booking";
            this.Text = "Admin_Booking";
            ((System.ComponentModel.ISupportInitialize)(this.admin_customer_book_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_adminbook_txt;
        private System.Windows.Forms.TextBox contact_adminbook_txt;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.TextBox address_adminbook_txt;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label person_label;
        private System.Windows.Forms.ComboBox person_adminbook;
        private System.Windows.Forms.ComboBox table_adminbook;
        private System.Windows.Forms.Label table_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ComboBox time_adminbook;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.ComboBox menu_adminbook;
        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.DateTimePicker date_adminbook;
        private System.Windows.Forms.Button admin_cancel;
        private System.Windows.Forms.Button admin_update;
        private System.Windows.Forms.Button admin_show;
        private System.Windows.Forms.Button admin_book;
        private System.Windows.Forms.DataGridView admin_customer_book_data;
    }
}