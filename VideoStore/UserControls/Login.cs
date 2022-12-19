using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStore.UserControls
{
    public partial class Login : UserControl
    {
        public MainPage mainPage;
        public bool isSetToRegister = false;
        public Login()
        {
            InitializeComponent();
            lbl_name.Visible = false;
            tb_name.Visible = false;
            checkbox_employee.Visible = false;
            tb_position.Visible = false;
            lbl_Position.Visible = false;
            datePicker_birthday.Visible = false;
            lbl_Birthdate.Visible = false;

           

        }

        private void btn_go_Click(object sender, EventArgs e)
        {

            mainPage = (MainPage)Application.OpenForms[0];

            if (isSetToRegister)
            {

                
                mainPage.CreateAccount(tb_username.Text, tb_password.Text, checkbox_employee.Checked, datePicker_birthday.Value,tb_position.Text, tb_name.Text);
            }
            else
            {

                mainPage.HandleLogin(tb_username.Text, tb_password.Text);

            }
            mainPage.CloseWindows();
            closeButton_Click( sender, e);
            
        }


        internal void ClearInfo()
        {
            tb_password.Text = "";
            tb_username.Text = "";
            tb_position.Text = "";
            tb_name.Text = "";
            checkbox_employee.Checked = false;
            
        }
        public void SwitchRegister()
        {
            if (isSetToRegister)
            {
                BackColor = Color.RosyBrown;
                lbl_Login.Text = "Login";
                btn_go.Text = "Sign In!";
                isSetToRegister = false;
                checkbox_employee.Visible = false;
                btn_SwitchToRegister.Text = "Switch To Register";
                lbl_name.Visible = false;
                tb_name.Visible = false;
                checkbox_employee.Visible = false;
                tb_position.Visible = false;
                lbl_Position.Visible = false;
                datePicker_birthday.Visible = false;
                lbl_Birthdate.Visible = false;



            }
            else
            {
                BackColor = Color.BlanchedAlmond;
                lbl_Login.Text = "Register";
                btn_SwitchToRegister.Text = "Switch To Login";
                btn_go.Text = "Sign Up!";
                isSetToRegister = true;
                lbl_name.Visible = true;
                tb_name.Visible = true;
                checkbox_employee.Visible = true;

                if (checkbox_employee.Checked)
                {
                    tb_position.Visible = true;
                    lbl_Position.Visible = true;
                }
                else
                {
                    tb_position.Visible = false;
                    lbl_Position.Visible = false;
                }

                datePicker_birthday.Visible = true;
                lbl_Birthdate.Visible = true;
            }
        }
        private void btn_SwitchToRegister_Click(object sender, EventArgs e)
        {
            SwitchRegister();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_employee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_employee.Checked)
            {
                tb_position.Visible = true;
                lbl_Position.Visible = true;
            }
            else
            {
                tb_position.Visible = false;
                lbl_Position.Visible = false;
            }
        }

      

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearInfo();
        }
    }
}
