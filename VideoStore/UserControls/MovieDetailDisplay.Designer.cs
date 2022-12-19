namespace VideoStore
{
    partial class MovieDetailDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_backdrop = new System.Windows.Forms.PictureBox();
            this.lbl_release_date = new System.Windows.Forms.Label();
            this.tb_release_date = new System.Windows.Forms.TextBox();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.tb_rating = new System.Windows.Forms.TextBox();
            this.btn_RentNow = new System.Windows.Forms.Button();
            this.tb_run_time = new System.Windows.Forms.TextBox();
            this.lbl_runtime = new System.Windows.Forms.Label();
            this.btn_AddToLibrary = new System.Windows.Forms.Button();
            this.tb_rentalPeriod = new System.Windows.Forms.TextBox();
            this.btn_Decrease = new System.Windows.Forms.Button();
            this.btn_Increase = new System.Windows.Forms.Button();
            this.lbl_rental = new System.Windows.Forms.Label();
            this.container1 = new VideoStore.Container();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_tagline = new System.Windows.Forms.RichTextBox();
            this.tb_budget = new System.Windows.Forms.TextBox();
            this.tb_popularity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_trailer = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.picture_backdrop)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_backdrop
            // 
            this.picture_backdrop.Location = new System.Drawing.Point(0, 0);
            this.picture_backdrop.Name = "picture_backdrop";
            this.picture_backdrop.Size = new System.Drawing.Size(731, 367);
            this.picture_backdrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_backdrop.TabIndex = 1;
            this.picture_backdrop.TabStop = false;
            // 
            // lbl_release_date
            // 
            this.lbl_release_date.AutoSize = true;
            this.lbl_release_date.Location = new System.Drawing.Point(37, 433);
            this.lbl_release_date.Name = "lbl_release_date";
            this.lbl_release_date.Size = new System.Drawing.Size(78, 13);
            this.lbl_release_date.TabIndex = 2;
            this.lbl_release_date.Text = "Release Date: ";
            // 
            // tb_release_date
            // 
            this.tb_release_date.Location = new System.Drawing.Point(121, 430);
            this.tb_release_date.Name = "tb_release_date";
            this.tb_release_date.Size = new System.Drawing.Size(100, 20);
            this.tb_release_date.TabIndex = 3;
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Location = new System.Drawing.Point(37, 467);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(44, 13);
            this.lbl_rating.TabIndex = 4;
            this.lbl_rating.Text = "Rating: ";
            // 
            // tb_rating
            // 
            this.tb_rating.Location = new System.Drawing.Point(121, 464);
            this.tb_rating.Name = "tb_rating";
            this.tb_rating.Size = new System.Drawing.Size(100, 20);
            this.tb_rating.TabIndex = 5;
            // 
            // btn_RentNow
            // 
            this.btn_RentNow.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_RentNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RentNow.Location = new System.Drawing.Point(529, 446);
            this.btn_RentNow.Name = "btn_RentNow";
            this.btn_RentNow.Size = new System.Drawing.Size(142, 49);
            this.btn_RentNow.TabIndex = 6;
            this.btn_RentNow.Text = "Rent Now!";
            this.btn_RentNow.UseVisualStyleBackColor = false;
            this.btn_RentNow.Click += new System.EventHandler(this.btn_RentNow_Click);
            // 
            // tb_run_time
            // 
            this.tb_run_time.Location = new System.Drawing.Point(121, 501);
            this.tb_run_time.Name = "tb_run_time";
            this.tb_run_time.Size = new System.Drawing.Size(100, 20);
            this.tb_run_time.TabIndex = 7;
            // 
            // lbl_runtime
            // 
            this.lbl_runtime.AutoSize = true;
            this.lbl_runtime.Location = new System.Drawing.Point(37, 501);
            this.lbl_runtime.Name = "lbl_runtime";
            this.lbl_runtime.Size = new System.Drawing.Size(46, 13);
            this.lbl_runtime.TabIndex = 8;
            this.lbl_runtime.Text = "Length: ";
            // 
            // btn_AddToLibrary
            // 
            this.btn_AddToLibrary.BackColor = System.Drawing.Color.Khaki;
            this.btn_AddToLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToLibrary.Location = new System.Drawing.Point(487, 543);
            this.btn_AddToLibrary.Name = "btn_AddToLibrary";
            this.btn_AddToLibrary.Size = new System.Drawing.Size(234, 62);
            this.btn_AddToLibrary.TabIndex = 9;
            this.btn_AddToLibrary.Text = "Request to be added store library!";
            this.btn_AddToLibrary.UseVisualStyleBackColor = false;
            this.btn_AddToLibrary.Click += new System.EventHandler(this.btn_AddToLibrary_Click);
            // 
            // tb_rentalPeriod
            // 
            this.tb_rentalPeriod.Location = new System.Drawing.Point(554, 419);
            this.tb_rentalPeriod.Name = "tb_rentalPeriod";
            this.tb_rentalPeriod.ReadOnly = true;
            this.tb_rentalPeriod.Size = new System.Drawing.Size(100, 20);
            this.tb_rentalPeriod.TabIndex = 10;
            // 
            // btn_Decrease
            // 
            this.btn_Decrease.Location = new System.Drawing.Point(487, 417);
            this.btn_Decrease.Name = "btn_Decrease";
            this.btn_Decrease.Size = new System.Drawing.Size(61, 23);
            this.btn_Decrease.TabIndex = 11;
            this.btn_Decrease.Text = "Decrease";
            this.btn_Decrease.UseVisualStyleBackColor = true;
            this.btn_Decrease.Click += new System.EventHandler(this.btn_Decrease_Click);
            // 
            // btn_Increase
            // 
            this.btn_Increase.Location = new System.Drawing.Point(660, 416);
            this.btn_Increase.Name = "btn_Increase";
            this.btn_Increase.Size = new System.Drawing.Size(61, 23);
            this.btn_Increase.TabIndex = 12;
            this.btn_Increase.Text = "Increase";
            this.btn_Increase.UseVisualStyleBackColor = true;
            this.btn_Increase.Click += new System.EventHandler(this.btn_Increase_Click);
            // 
            // lbl_rental
            // 
            this.lbl_rental.AutoSize = true;
            this.lbl_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rental.Location = new System.Drawing.Point(538, 382);
            this.lbl_rental.Name = "lbl_rental";
            this.lbl_rental.Size = new System.Drawing.Size(133, 24);
            this.lbl_rental.TabIndex = 13;
            this.lbl_rental.Text = "Rental Period: ";
            // 
            // container1
            // 
            this.container1.Location = new System.Drawing.Point(0, 0);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(731, 649);
            this.container1.TabIndex = 0;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(117, 382);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(129, 24);
            this.lbl_Info.TabIndex = 16;
            this.lbl_Info.Text = "Movie details: ";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(37, 592);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 17;
            this.lbl_Description.Text = "Description:";
            // 
            // rtb_desc
            // 
            this.rtb_desc.Location = new System.Drawing.Point(121, 589);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.ReadOnly = true;
            this.rtb_desc.Size = new System.Drawing.Size(311, 43);
            this.rtb_desc.TabIndex = 19;
            this.rtb_desc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tagline: ";
            // 
            // rtb_tagline
            // 
            this.rtb_tagline.Location = new System.Drawing.Point(121, 527);
            this.rtb_tagline.Name = "rtb_tagline";
            this.rtb_tagline.ReadOnly = true;
            this.rtb_tagline.Size = new System.Drawing.Size(311, 43);
            this.rtb_tagline.TabIndex = 21;
            this.rtb_tagline.Text = "";
            // 
            // tb_budget
            // 
            this.tb_budget.Location = new System.Drawing.Point(332, 430);
            this.tb_budget.Name = "tb_budget";
            this.tb_budget.Size = new System.Drawing.Size(100, 20);
            this.tb_budget.TabIndex = 22;
            // 
            // tb_popularity
            // 
            this.tb_popularity.Location = new System.Drawing.Point(332, 464);
            this.tb_popularity.Name = "tb_popularity";
            this.tb_popularity.Size = new System.Drawing.Size(100, 20);
            this.tb_popularity.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Popularity: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Budget: ";
            // 
            // btn_trailer
            // 
            this.btn_trailer.Location = new System.Drawing.Point(332, 373);
            this.btn_trailer.Name = "btn_trailer";
            this.btn_trailer.Size = new System.Drawing.Size(100, 35);
            this.btn_trailer.TabIndex = 26;
            this.btn_trailer.Text = "Play Trailer";
            this.btn_trailer.UseVisualStyleBackColor = true;
            this.btn_trailer.Click += new System.EventHandler(this.btn_trailer_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(138, 75);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(460, 270);
            this.webBrowser1.TabIndex = 27;
            // 
            // MovieDetailDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_trailer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_popularity);
            this.Controls.Add(this.tb_budget);
            this.Controls.Add(this.rtb_tagline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_desc);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_rental);
            this.Controls.Add(this.btn_Increase);
            this.Controls.Add(this.btn_Decrease);
            this.Controls.Add(this.tb_rentalPeriod);
            this.Controls.Add(this.btn_AddToLibrary);
            this.Controls.Add(this.lbl_runtime);
            this.Controls.Add(this.tb_run_time);
            this.Controls.Add(this.btn_RentNow);
            this.Controls.Add(this.tb_rating);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.tb_release_date);
            this.Controls.Add(this.lbl_release_date);
            this.Controls.Add(this.picture_backdrop);
            this.Controls.Add(this.container1);
            this.Name = "MovieDetailDisplay";
            this.Size = new System.Drawing.Size(731, 647);
            ((System.ComponentModel.ISupportInitialize)(this.picture_backdrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Container container1;
        private System.Windows.Forms.PictureBox picture_backdrop;
        private System.Windows.Forms.Label lbl_release_date;
        private System.Windows.Forms.TextBox tb_release_date;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.TextBox tb_rating;
        private System.Windows.Forms.Button btn_RentNow;
        private System.Windows.Forms.TextBox tb_run_time;
        private System.Windows.Forms.Label lbl_runtime;
        private System.Windows.Forms.Button btn_AddToLibrary;
        private System.Windows.Forms.TextBox tb_rentalPeriod;
        private System.Windows.Forms.Button btn_Decrease;
        private System.Windows.Forms.Button btn_Increase;
        private System.Windows.Forms.Label lbl_rental;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.RichTextBox rtb_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_tagline;
        private System.Windows.Forms.TextBox tb_budget;
        private System.Windows.Forms.TextBox tb_popularity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_trailer;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
