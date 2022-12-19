namespace VideoStore.UserControls
{
    partial class CustomerTerminal
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
            this.rtb_rentals = new System.Windows.Forms.RichTextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.tb_return_input = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_rentals
            // 
            this.rtb_rentals.Location = new System.Drawing.Point(72, 56);
            this.rtb_rentals.Name = "rtb_rentals";
            this.rtb_rentals.ReadOnly = true;
            this.rtb_rentals.Size = new System.Drawing.Size(215, 292);
            this.rtb_rentals.TabIndex = 0;
            this.rtb_rentals.Text = "";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(303, 216);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(129, 23);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "Return Movie";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // tb_return_input
            // 
            this.tb_return_input.Location = new System.Drawing.Point(438, 218);
            this.tb_return_input.Name = "tb_return_input";
            this.tb_return_input.Size = new System.Drawing.Size(59, 20);
            this.tb_return_input.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // CustomerTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_return_input);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.rtb_rentals);
            this.Name = "CustomerTerminal";
            this.Size = new System.Drawing.Size(520, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_rentals;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox tb_return_input;
        private System.Windows.Forms.Button btn_close;
    }
}
