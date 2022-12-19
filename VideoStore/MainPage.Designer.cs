namespace VideoStore
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.input_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_search_go = new System.Windows.Forms.Button();
            this.tb_ResultsFound = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Get_Popular = new System.Windows.Forms.Button();
            this.cmb_age = new System.Windows.Forms.ComboBox();
            this.checkBox_filter_genre = new System.Windows.Forms.CheckBox();
            this.cmb_filter_by_genre = new System.Windows.Forms.ComboBox();
            this.checkBox_restrict_Age = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_currentlyLoggedin = new System.Windows.Forms.TextBox();
            this.employeeTerminal1 = new VideoStore.UserControls.EmployeeTerminal();
            this.storeDetails1 = new VideoStore.UserControls.StoreDetails();
            this.login1 = new VideoStore.UserControls.Login();
            this.Container_Movie_Search_Details = new VideoStore.Container();
            this.movieDetailDisplay1 = new VideoStore.MovieDetailDisplay();
            this.customerTerminal1 = new VideoStore.UserControls.CustomerTerminal();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_search
            // 
            this.input_search.Location = new System.Drawing.Point(67, 73);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(100, 20);
            this.input_search.TabIndex = 2;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(17, 76);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(44, 13);
            this.lbl_search.TabIndex = 3;
            this.lbl_search.Text = "Search:";
            // 
            // btn_search_go
            // 
            this.btn_search_go.Location = new System.Drawing.Point(173, 71);
            this.btn_search_go.Name = "btn_search_go";
            this.btn_search_go.Size = new System.Drawing.Size(75, 23);
            this.btn_search_go.TabIndex = 4;
            this.btn_search_go.Text = "Go!";
            this.btn_search_go.UseVisualStyleBackColor = true;
            this.btn_search_go.Click += new System.EventHandler(this.btn_search_go_Click);
            // 
            // tb_ResultsFound
            // 
            this.tb_ResultsFound.Location = new System.Drawing.Point(143, 174);
            this.tb_ResultsFound.Name = "tb_ResultsFound";
            this.tb_ResultsFound.ReadOnly = true;
            this.tb_ResultsFound.Size = new System.Drawing.Size(100, 20);
            this.tb_ResultsFound.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1269, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(50, 22);
            this.toolStripDropDownButton1.Text = "Login";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click_1);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButton2.Text = "Debug";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.storeToolStripMenuItem.Text = "StoreDetails";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(65, 22);
            this.toolStripDropDownButton3.Text = "Account";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.btn_Get_Popular);
            this.panel1.Controls.Add(this.cmb_age);
            this.panel1.Controls.Add(this.checkBox_filter_genre);
            this.panel1.Controls.Add(this.cmb_filter_by_genre);
            this.panel1.Controls.Add(this.checkBox_restrict_Age);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.input_search);
            this.panel1.Controls.Add(this.tb_ResultsFound);
            this.panel1.Controls.Add(this.btn_search_go);
            this.panel1.Controls.Add(this.lbl_search);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 204);
            this.panel1.TabIndex = 0;
            // 
            // btn_Get_Popular
            // 
            this.btn_Get_Popular.Location = new System.Drawing.Point(271, 71);
            this.btn_Get_Popular.Name = "btn_Get_Popular";
            this.btn_Get_Popular.Size = new System.Drawing.Size(123, 23);
            this.btn_Get_Popular.TabIndex = 16;
            this.btn_Get_Popular.Text = "Top 10 Movies";
            this.btn_Get_Popular.UseVisualStyleBackColor = true;
            this.btn_Get_Popular.Click += new System.EventHandler(this.btn_Get_Popular_Click);
            // 
            // cmb_age
            // 
            this.cmb_age.FormattingEnabled = true;
            this.cmb_age.Location = new System.Drawing.Point(109, 98);
            this.cmb_age.Name = "cmb_age";
            this.cmb_age.Size = new System.Drawing.Size(58, 21);
            this.cmb_age.TabIndex = 15;
            // 
            // checkBox_filter_genre
            // 
            this.checkBox_filter_genre.AutoSize = true;
            this.checkBox_filter_genre.Location = new System.Drawing.Point(173, 102);
            this.checkBox_filter_genre.Name = "checkBox_filter_genre";
            this.checkBox_filter_genre.Size = new System.Drawing.Size(94, 17);
            this.checkBox_filter_genre.TabIndex = 14;
            this.checkBox_filter_genre.Text = "Filter by Genre";
            this.checkBox_filter_genre.UseVisualStyleBackColor = true;
            this.checkBox_filter_genre.CheckedChanged += new System.EventHandler(this.checkBox_filter_genre_CheckedChanged);
            // 
            // cmb_filter_by_genre
            // 
            this.cmb_filter_by_genre.FormattingEnabled = true;
            this.cmb_filter_by_genre.Location = new System.Drawing.Point(273, 98);
            this.cmb_filter_by_genre.Name = "cmb_filter_by_genre";
            this.cmb_filter_by_genre.Size = new System.Drawing.Size(121, 21);
            this.cmb_filter_by_genre.TabIndex = 13;
            // 
            // checkBox_restrict_Age
            // 
            this.checkBox_restrict_Age.AutoSize = true;
            this.checkBox_restrict_Age.Location = new System.Drawing.Point(18, 102);
            this.checkBox_restrict_Age.Name = "checkBox_restrict_Age";
            this.checkBox_restrict_Age.Size = new System.Drawing.Size(84, 17);
            this.checkBox_restrict_Age.TabIndex = 9;
            this.checkBox_restrict_Age.Text = "Restrict Age";
            this.checkBox_restrict_Age.UseVisualStyleBackColor = true;
            this.checkBox_restrict_Age.CheckedChanged += new System.EventHandler(this.checkBox_restrict_Age_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search For A Movie!";
            // 
            // tb_currentlyLoggedin
            // 
            this.tb_currentlyLoggedin.Location = new System.Drawing.Point(858, 28);
            this.tb_currentlyLoggedin.Name = "tb_currentlyLoggedin";
            this.tb_currentlyLoggedin.ReadOnly = true;
            this.tb_currentlyLoggedin.Size = new System.Drawing.Size(262, 20);
            this.tb_currentlyLoggedin.TabIndex = 16;
            this.tb_currentlyLoggedin.Text = "Not Logged In";
            // 
            // employeeTerminal1
            // 
            this.employeeTerminal1.Location = new System.Drawing.Point(0, 25);
            this.employeeTerminal1.Name = "employeeTerminal1";
            this.employeeTerminal1.Size = new System.Drawing.Size(497, 363);
            this.employeeTerminal1.TabIndex = 18;
            // 
            // storeDetails1
            // 
            this.storeDetails1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.storeDetails1.Location = new System.Drawing.Point(0, 25);
            this.storeDetails1.Name = "storeDetails1";
            this.storeDetails1.Size = new System.Drawing.Size(626, 399);
            this.storeDetails1.TabIndex = 17;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.RosyBrown;
            this.login1.Location = new System.Drawing.Point(0, 25);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(527, 328);
            this.login1.TabIndex = 15;
            // 
            // Container_Movie_Search_Details
            // 
            this.Container_Movie_Search_Details.Location = new System.Drawing.Point(45, 255);
            this.Container_Movie_Search_Details.Name = "Container_Movie_Search_Details";
            this.Container_Movie_Search_Details.Size = new System.Drawing.Size(300, 659);
            this.Container_Movie_Search_Details.TabIndex = 9;
            // 
            // movieDetailDisplay1
            // 
            this.movieDetailDisplay1.Location = new System.Drawing.Point(496, 113);
            this.movieDetailDisplay1.Name = "movieDetailDisplay1";
            this.movieDetailDisplay1.Size = new System.Drawing.Size(600, 600);
            this.movieDetailDisplay1.TabIndex = 8;
            // 
            // customerTerminal1
            // 
            this.customerTerminal1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.customerTerminal1.Location = new System.Drawing.Point(0, 25);
            this.customerTerminal1.Name = "customerTerminal1";
            this.customerTerminal1.Size = new System.Drawing.Size(520, 405);
            this.customerTerminal1.TabIndex = 19;
            this.customerTerminal1.Load += new System.EventHandler(this.customerTerminal1_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1269, 926);
            this.Controls.Add(this.customerTerminal1);
            this.Controls.Add(this.employeeTerminal1);
            this.Controls.Add(this.storeDetails1);
            this.Controls.Add(this.tb_currentlyLoggedin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Container_Movie_Search_Details);
            this.Controls.Add(this.movieDetailDisplay1);
            this.Name = "MainPage";
            this.Text = "Movie App";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_search_go;
        private System.Windows.Forms.TextBox tb_ResultsFound;
        private MovieDetailDisplay movieDetailDisplay1;
        private Container Container_Movie_Search_Details;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private UserControls.Login login1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_currentlyLoggedin;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private UserControls.StoreDetails storeDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_restrict_Age;
        private System.Windows.Forms.CheckBox checkBox_filter_genre;
        private System.Windows.Forms.ComboBox cmb_filter_by_genre;
        private System.Windows.Forms.ComboBox cmb_age;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private UserControls.EmployeeTerminal employeeTerminal1;
        private System.Windows.Forms.Button btn_Get_Popular;
        private UserControls.CustomerTerminal customerTerminal1;
    }
}

