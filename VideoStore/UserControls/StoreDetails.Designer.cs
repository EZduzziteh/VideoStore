namespace VideoStore.UserControls
{
    partial class StoreDetails
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
            this.rtb_details = new System.Windows.Forms.RichTextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_details
            // 
            this.rtb_details.Location = new System.Drawing.Point(75, 35);
            this.rtb_details.Name = "rtb_details";
            this.rtb_details.ReadOnly = true;
            this.rtb_details.Size = new System.Drawing.Size(460, 323);
            this.rtb_details.TabIndex = 0;
            this.rtb_details.Text = "";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(0, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // StoreDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.rtb_details);
            this.Name = "StoreDetails";
            this.Size = new System.Drawing.Size(626, 399);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_details;
        private System.Windows.Forms.Button btn_Close;
    }
}
