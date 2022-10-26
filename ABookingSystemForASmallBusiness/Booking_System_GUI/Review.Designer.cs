namespace ABookingSystemForASmallBusiness.Booking_System_GUI
{
    partial class Review
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
            this.review_name = new System.Windows.Forms.Panel();
            this.review_name_txt = new System.Windows.Forms.Label();
            this.review_txt = new System.Windows.Forms.RichTextBox();
            this.review_submit = new System.Windows.Forms.Button();
            this.review_cancel = new System.Windows.Forms.Button();
            this.review_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // review_name
            // 
            this.review_name.Controls.Add(this.review_name_txt);
            this.review_name.Font = new System.Drawing.Font("Tekton Pro Ext", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_name.Location = new System.Drawing.Point(12, 0);
            this.review_name.Name = "review_name";
            this.review_name.Size = new System.Drawing.Size(238, 48);
            this.review_name.TabIndex = 0;
            // 
            // review_name_txt
            // 
            this.review_name_txt.AutoSize = true;
            this.review_name_txt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_name_txt.Location = new System.Drawing.Point(3, 14);
            this.review_name_txt.Name = "review_name_txt";
            this.review_name_txt.Size = new System.Drawing.Size(64, 22);
            this.review_name_txt.TabIndex = 0;
            this.review_name_txt.Text = "label1";
            // 
            // review_txt
            // 
            this.review_txt.Location = new System.Drawing.Point(12, 54);
            this.review_txt.Name = "review_txt";
            this.review_txt.Size = new System.Drawing.Size(601, 268);
            this.review_txt.TabIndex = 1;
            this.review_txt.Text = "";
            // 
            // review_submit
            // 
            this.review_submit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.review_submit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.review_submit.Location = new System.Drawing.Point(343, 328);
            this.review_submit.Name = "review_submit";
            this.review_submit.Size = new System.Drawing.Size(132, 46);
            this.review_submit.TabIndex = 2;
            this.review_submit.Text = "Submit";
            this.review_submit.UseVisualStyleBackColor = false;
            this.review_submit.Click += new System.EventHandler(this.review_submit_Click);
            // 
            // review_cancel
            // 
            this.review_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.review_cancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.review_cancel.Location = new System.Drawing.Point(481, 328);
            this.review_cancel.Name = "review_cancel";
            this.review_cancel.Size = new System.Drawing.Size(132, 46);
            this.review_cancel.TabIndex = 3;
            this.review_cancel.Text = "Cancel";
            this.review_cancel.UseVisualStyleBackColor = false;
            this.review_cancel.Click += new System.EventHandler(this.review_cancel_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 386);
            this.Controls.Add(this.review_cancel);
            this.Controls.Add(this.review_submit);
            this.Controls.Add(this.review_txt);
            this.Controls.Add(this.review_name);
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.review_name.ResumeLayout(false);
            this.review_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel review_name;
        private System.Windows.Forms.RichTextBox review_txt;
        private System.Windows.Forms.Button review_submit;
        private System.Windows.Forms.Button review_cancel;
        private System.Windows.Forms.Label review_name_txt;
    }
}