namespace VideoStore.UserControls
{
    partial class Login
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
            this.btn_go = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_SwitchToRegister = new System.Windows.Forms.Button();
            this.checkbox_employee = new System.Windows.Forms.CheckBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.datePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go.Location = new System.Drawing.Point(347, 108);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(136, 57);
            this.btn_go.TabIndex = 0;
            this.btn_go.Text = "Sign In!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(208, 107);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(133, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(208, 145);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(133, 20);
            this.tb_password.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(98, 103);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(107, 24);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username: ";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(98, 141);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(97, 24);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Black;
            this.lbl_Login.Location = new System.Drawing.Point(200, 25);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(90, 36);
            this.lbl_Login.TabIndex = 5;
            this.lbl_Login.Text = "Login";
            // 
            // btn_SwitchToRegister
            // 
            this.btn_SwitchToRegister.Location = new System.Drawing.Point(335, 36);
            this.btn_SwitchToRegister.Name = "btn_SwitchToRegister";
            this.btn_SwitchToRegister.Size = new System.Drawing.Size(127, 23);
            this.btn_SwitchToRegister.TabIndex = 6;
            this.btn_SwitchToRegister.Text = "Switch To Register";
            this.btn_SwitchToRegister.UseVisualStyleBackColor = true;
            this.btn_SwitchToRegister.Click += new System.EventHandler(this.btn_SwitchToRegister_Click);
            // 
            // checkbox_employee
            // 
            this.checkbox_employee.AutoSize = true;
            this.checkbox_employee.Location = new System.Drawing.Point(208, 237);
            this.checkbox_employee.Name = "checkbox_employee";
            this.checkbox_employee.Size = new System.Drawing.Size(115, 17);
            this.checkbox_employee.TabIndex = 7;
            this.checkbox_employee.Text = "Employee Account";
            this.checkbox_employee.UseVisualStyleBackColor = true;
            this.checkbox_employee.CheckedChanged += new System.EventHandler(this.checkbox_employee_CheckedChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(208, 181);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(133, 20);
            this.tb_name.TabIndex = 8;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(98, 176);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 24);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.Black;
            this.lbl_Position.Location = new System.Drawing.Point(98, 259);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(81, 24);
            this.lbl_Position.TabIndex = 10;
            this.lbl_Position.Text = "Position:";
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(208, 264);
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(133, 20);
            this.tb_position.TabIndex = 11;
            // 
            // datePicker_birthday
            // 
            this.datePicker_birthday.Location = new System.Drawing.Point(206, 211);
            this.datePicker_birthday.Name = "datePicker_birthday";
            this.datePicker_birthday.Size = new System.Drawing.Size(133, 20);
            this.datePicker_birthday.TabIndex = 12;
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthdate.ForeColor = System.Drawing.Color.Black;
            this.lbl_Birthdate.Location = new System.Drawing.Point(98, 211);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(88, 24);
            this.lbl_Birthdate.TabIndex = 13;
            this.lbl_Birthdate.Text = "Birthdate:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Birthdate);
            this.Controls.Add(this.datePicker_birthday);
            this.Controls.Add(this.tb_position);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.checkbox_employee);
            this.Controls.Add(this.btn_SwitchToRegister);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_go);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(527, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_SwitchToRegister;
        private System.Windows.Forms.CheckBox checkbox_employee;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.DateTimePicker datePicker_birthday;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.Button button1;
    }
}
