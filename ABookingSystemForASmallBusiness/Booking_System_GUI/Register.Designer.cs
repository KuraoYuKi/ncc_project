namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    partial class Register
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
            this.login_label = new System.Windows.Forms.LinkLabel();
            this.register_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.LoginHead = new System.Windows.Forms.Panel();
            this.registertext = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmps_textbox = new System.Windows.Forms.Label();
            this.LoginHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(168, 417);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(162, 16);
            this.login_label.TabIndex = 13;
            this.login_label.TabStop = true;
            this.login_label.Text = "Already have an account?";
            this.login_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_label_LinkClicked);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_button.Location = new System.Drawing.Point(86, 457);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(244, 44);
            this.register_button.TabIndex = 12;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(86, 271);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(244, 24);
            this.password_textbox.TabIndex = 11;
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(86, 185);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(244, 24);
            this.username_textbox.TabIndex = 10;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(82, 233);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(81, 20);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(82, 143);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(86, 20);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Username";
            // 
            // LoginHead
            // 
            this.LoginHead.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginHead.Controls.Add(this.registertext);
            this.LoginHead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginHead.Location = new System.Drawing.Point(-3, 0);
            this.LoginHead.Name = "LoginHead";
            this.LoginHead.Size = new System.Drawing.Size(426, 88);
            this.LoginHead.TabIndex = 7;
            // 
            // registertext
            // 
            this.registertext.AutoSize = true;
            this.registertext.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registertext.Location = new System.Drawing.Point(149, 26);
            this.registertext.Name = "registertext";
            this.registertext.Size = new System.Drawing.Size(134, 32);
            this.registertext.TabIndex = 0;
            this.registertext.Text = "Register";
            this.registertext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(244, 24);
            this.textBox1.TabIndex = 15;
            // 
            // confirmps_textbox
            // 
            this.confirmps_textbox.AutoSize = true;
            this.confirmps_textbox.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmps_textbox.Location = new System.Drawing.Point(82, 325);
            this.confirmps_textbox.Name = "confirmps_textbox";
            this.confirmps_textbox.Size = new System.Drawing.Size(148, 20);
            this.confirmps_textbox.TabIndex = 14;
            this.confirmps_textbox.Text = "Confirm Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 560);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmps_textbox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.LoginHead);
            this.Name = "Register";
            this.Text = "Register";
            this.LoginHead.ResumeLayout(false);
            this.LoginHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel login_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Panel LoginHead;
        private System.Windows.Forms.Label registertext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label confirmps_textbox;
    }
}