namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    partial class Welcome
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
            this.welcome_menu_bg = new System.Windows.Forms.Panel();
            this.view_review = new System.Windows.Forms.Button();
            this.review = new System.Windows.Forms.Button();
            this.check_out = new System.Windows.Forms.Button();
            this.booking = new System.Windows.Forms.Button();
            this.booking_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.acc_icon = new System.Windows.Forms.PictureBox();
            this.acc_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.order_heading = new System.Windows.Forms.Label();
            this.setA_order = new System.Windows.Forms.Button();
            this.setB_order = new System.Windows.Forms.Button();
            this.setC_order = new System.Windows.Forms.Button();
            this.setC = new System.Windows.Forms.PictureBox();
            this.setB = new System.Windows.Forms.PictureBox();
            this.setA = new System.Windows.Forms.PictureBox();
            this.welcome_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_menu_bg.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setA)).BeginInit();
            this.welcome_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_menu_bg
            // 
            this.welcome_menu_bg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome_menu_bg.Controls.Add(this.view_review);
            this.welcome_menu_bg.Controls.Add(this.review);
            this.welcome_menu_bg.Controls.Add(this.check_out);
            this.welcome_menu_bg.Controls.Add(this.booking);
            this.welcome_menu_bg.Controls.Add(this.booking_update);
            this.welcome_menu_bg.Controls.Add(this.panel1);
            this.welcome_menu_bg.Controls.Add(this.logo);
            this.welcome_menu_bg.Location = new System.Drawing.Point(0, 0);
            this.welcome_menu_bg.Name = "welcome_menu_bg";
            this.welcome_menu_bg.Size = new System.Drawing.Size(295, 785);
            this.welcome_menu_bg.TabIndex = 0;
            this.welcome_menu_bg.Paint += new System.Windows.Forms.PaintEventHandler(this.welcome_menu_bg_Paint);
            // 
            // view_review
            // 
            this.view_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_review.Font = new System.Drawing.Font("Tekton Pro Ext", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_review.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view_review.Location = new System.Drawing.Point(22, 457);
            this.view_review.Name = "view_review";
            this.view_review.Size = new System.Drawing.Size(254, 38);
            this.view_review.TabIndex = 6;
            this.view_review.Text = "Customer\'s  Review";
            this.view_review.UseVisualStyleBackColor = true;
            // 
            // review
            // 
            this.review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.review.Font = new System.Drawing.Font("Tekton Pro Ext", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.review.Location = new System.Drawing.Point(22, 400);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(254, 38);
            this.review.TabIndex = 5;
            this.review.Text = "Write  Review";
            this.review.UseVisualStyleBackColor = true;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // check_out
            // 
            this.check_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_out.Font = new System.Drawing.Font("Tekton Pro Ext", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_out.Location = new System.Drawing.Point(22, 346);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(254, 38);
            this.check_out.TabIndex = 4;
            this.check_out.Text = "Checkout";
            this.check_out.UseVisualStyleBackColor = true;
            // 
            // booking
            // 
            this.booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booking.Font = new System.Drawing.Font("Tekton Pro Ext", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.booking.Location = new System.Drawing.Point(22, 233);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(254, 38);
            this.booking.TabIndex = 3;
            this.booking.Text = "Book  Now";
            this.booking.UseVisualStyleBackColor = true;
            this.booking.Click += new System.EventHandler(this.booking_Click);
            // 
            // booking_update
            // 
            this.booking_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booking_update.Font = new System.Drawing.Font("Tekton Pro Ext", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.booking_update.Location = new System.Drawing.Point(22, 289);
            this.booking_update.Name = "booking_update";
            this.booking_update.Size = new System.Drawing.Size(254, 38);
            this.booking_update.TabIndex = 2;
            this.booking_update.Text = "Update  Booking";
            this.booking_update.UseVisualStyleBackColor = true;
            this.booking_update.Click += new System.EventHandler(this.booking_update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.acc_icon);
            this.panel1.Controls.Add(this.acc_btn);
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 77);
            this.panel1.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::ABookingSystemForASmallBusiness.Properties.Resources.logoutic;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(22, 23);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(31, 31);
            this.logout.TabIndex = 2;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // acc_icon
            // 
            this.acc_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acc_icon.Image = global::ABookingSystemForASmallBusiness.Properties.Resources.accicon;
            this.acc_icon.Location = new System.Drawing.Point(225, 13);
            this.acc_icon.Name = "acc_icon";
            this.acc_icon.Size = new System.Drawing.Size(51, 51);
            this.acc_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acc_icon.TabIndex = 1;
            this.acc_icon.TabStop = false;
            // 
            // acc_btn
            // 
            this.acc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acc_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acc_btn.Location = new System.Drawing.Point(22, 13);
            this.acc_btn.Name = "acc_btn";
            this.acc_btn.Size = new System.Drawing.Size(254, 49);
            this.acc_btn.TabIndex = 1;
            this.acc_btn.UseVisualStyleBackColor = true;
            this.acc_btn.Click += new System.EventHandler(this.acc_btn_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = global::ABookingSystemForASmallBusiness.Properties.Resources.logowhite;
            this.logo.Location = new System.Drawing.Point(35, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(224, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // order_heading
            // 
            this.order_heading.AutoSize = true;
            this.order_heading.Font = new System.Drawing.Font("Tekton Pro Ext", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_heading.Location = new System.Drawing.Point(679, 400);
            this.order_heading.Name = "order_heading";
            this.order_heading.Size = new System.Drawing.Size(126, 45);
            this.order_heading.TabIndex = 2;
            this.order_heading.Text = "Menu";
            // 
            // setA_order
            // 
            this.setA_order.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setA_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setA_order.Font = new System.Drawing.Font("Tekton Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setA_order.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setA_order.Location = new System.Drawing.Point(399, 721);
            this.setA_order.Name = "setA_order";
            this.setA_order.Size = new System.Drawing.Size(75, 35);
            this.setA_order.TabIndex = 4;
            this.setA_order.Text = "Set A";
            this.setA_order.UseVisualStyleBackColor = false;
            this.setA_order.Click += new System.EventHandler(this.setA_order_Click);
            // 
            // setB_order
            // 
            this.setB_order.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setB_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setB_order.Font = new System.Drawing.Font("Tekton Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setB_order.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setB_order.Location = new System.Drawing.Point(698, 721);
            this.setB_order.Name = "setB_order";
            this.setB_order.Size = new System.Drawing.Size(75, 35);
            this.setB_order.TabIndex = 7;
            this.setB_order.Text = "Set B";
            this.setB_order.UseVisualStyleBackColor = false;
            this.setB_order.Click += new System.EventHandler(this.setB_order_Click);
            // 
            // setC_order
            // 
            this.setC_order.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setC_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setC_order.Font = new System.Drawing.Font("Tekton Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setC_order.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setC_order.Location = new System.Drawing.Point(999, 721);
            this.setC_order.Name = "setC_order";
            this.setC_order.Size = new System.Drawing.Size(75, 35);
            this.setC_order.TabIndex = 9;
            this.setC_order.Text = "Set C";
            this.setC_order.UseVisualStyleBackColor = false;
            this.setC_order.Click += new System.EventHandler(this.setC_order_Click);
            // 
            // setC
            // 
            this.setC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setC.Image = global::ABookingSystemForASmallBusiness.Properties.Resources.buffetset;
            this.setC.Location = new System.Drawing.Point(908, 461);
            this.setC.Name = "setC";
            this.setC.Size = new System.Drawing.Size(267, 254);
            this.setC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setC.TabIndex = 8;
            this.setC.TabStop = false;
            // 
            // setB
            // 
            this.setB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setB.Image = global::ABookingSystemForASmallBusiness.Properties.Resources._2peopleset;
            this.setB.Location = new System.Drawing.Point(607, 461);
            this.setB.Name = "setB";
            this.setB.Size = new System.Drawing.Size(267, 254);
            this.setB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setB.TabIndex = 6;
            this.setB.TabStop = false;
            // 
            // setA
            // 
            this.setA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setA.Image = global::ABookingSystemForASmallBusiness.Properties.Resources.Allyoucaneatset;
            this.setA.Location = new System.Drawing.Point(308, 461);
            this.setA.Name = "setA";
            this.setA.Size = new System.Drawing.Size(267, 254);
            this.setA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setA.TabIndex = 3;
            this.setA.TabStop = false;
            // 
            // welcome_panel
            // 
            this.welcome_panel.BackgroundImage = global::ABookingSystemForASmallBusiness.Properties.Resources.banner;
            this.welcome_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcome_panel.Controls.Add(this.label1);
            this.welcome_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_panel.Location = new System.Drawing.Point(295, -1);
            this.welcome_panel.Name = "welcome_panel";
            this.welcome_panel.Size = new System.Drawing.Size(895, 385);
            this.welcome_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(76, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Mito\r\nMake Your Own Reservation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 778);
            this.Controls.Add(this.setC_order);
            this.Controls.Add(this.setC);
            this.Controls.Add(this.setB_order);
            this.Controls.Add(this.setB);
            this.Controls.Add(this.setA_order);
            this.Controls.Add(this.setA);
            this.Controls.Add(this.order_heading);
            this.Controls.Add(this.welcome_panel);
            this.Controls.Add(this.welcome_menu_bg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.welcome_menu_bg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acc_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setA)).EndInit();
            this.welcome_panel.ResumeLayout(false);
            this.welcome_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel welcome_menu_bg;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel welcome_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label order_heading;
        private System.Windows.Forms.PictureBox setA;
        private System.Windows.Forms.Button setA_order;
        private System.Windows.Forms.Button setB_order;
        private System.Windows.Forms.PictureBox setB;
        private System.Windows.Forms.Button setC_order;
        private System.Windows.Forms.PictureBox setC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox acc_icon;
        private System.Windows.Forms.Button acc_btn;
        private System.Windows.Forms.Button booking_update;
        private System.Windows.Forms.Button booking;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button check_out;
        private System.Windows.Forms.Button view_review;
    }
}