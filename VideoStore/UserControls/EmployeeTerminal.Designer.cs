namespace VideoStore.UserControls
{
    partial class EmployeeTerminal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Customers = new System.Windows.Forms.Label();
            this.rtb_customers = new System.Windows.Forms.RichTextBox();
            this.btn_removeMovie = new System.Windows.Forms.Button();
            this.tb_id_input = new System.Windows.Forms.TextBox();
            this.lbl_available = new System.Windows.Forms.Label();
            this.rtb_inventory = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label_Customers);
            this.panel1.Controls.Add(this.rtb_customers);
            this.panel1.Controls.Add(this.btn_removeMovie);
            this.panel1.Controls.Add(this.tb_id_input);
            this.panel1.Controls.Add(this.lbl_available);
            this.panel1.Controls.Add(this.rtb_inventory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 491);
            this.panel1.TabIndex = 0;
            // 
            // label_Customers
            // 
            this.label_Customers.AutoSize = true;
            this.label_Customers.Location = new System.Drawing.Point(84, 29);
            this.label_Customers.Name = "label_Customers";
            this.label_Customers.Size = new System.Drawing.Size(59, 13);
            this.label_Customers.TabIndex = 5;
            this.label_Customers.Text = "Customers:";
            // 
            // rtb_customers
            // 
            this.rtb_customers.Location = new System.Drawing.Point(34, 59);
            this.rtb_customers.Name = "rtb_customers";
            this.rtb_customers.Size = new System.Drawing.Size(179, 261);
            this.rtb_customers.TabIndex = 4;
            this.rtb_customers.Text = "";
            // 
            // btn_removeMovie
            // 
            this.btn_removeMovie.Location = new System.Drawing.Point(302, 326);
            this.btn_removeMovie.Name = "btn_removeMovie";
            this.btn_removeMovie.Size = new System.Drawing.Size(107, 23);
            this.btn_removeMovie.TabIndex = 3;
            this.btn_removeMovie.Text = "Remove Movie:";
            this.btn_removeMovie.UseVisualStyleBackColor = true;
            this.btn_removeMovie.Click += new System.EventHandler(this.btn_removeMovie_Click);
            // 
            // tb_id_input
            // 
            this.tb_id_input.Location = new System.Drawing.Point(415, 328);
            this.tb_id_input.Name = "tb_id_input";
            this.tb_id_input.Size = new System.Drawing.Size(66, 20);
            this.tb_id_input.TabIndex = 2;
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(365, 29);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(57, 13);
            this.lbl_available.TabIndex = 1;
            this.lbl_available.Text = "Inventory: ";
            // 
            // rtb_inventory
            // 
            this.rtb_inventory.Location = new System.Drawing.Point(302, 59);
            this.rtb_inventory.Name = "rtb_inventory";
            this.rtb_inventory.Size = new System.Drawing.Size(179, 261);
            this.rtb_inventory.TabIndex = 0;
            this.rtb_inventory.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // EmployeeTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeTerminal";
            this.Size = new System.Drawing.Size(642, 494);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_customers;
        private System.Windows.Forms.Button btn_removeMovie;
        private System.Windows.Forms.TextBox tb_id_input;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.RichTextBox rtb_inventory;
        private System.Windows.Forms.Label label_Customers;
        private System.Windows.Forms.Button btn_close;
    }
}
