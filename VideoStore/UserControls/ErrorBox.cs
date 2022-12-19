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
    
    public partial class ErrorBox : UserControl
    {
        public ControlCollection owningCollection;

        public ErrorBox()
        {
            InitializeComponent();
        }

        public void SetText(string text, bool isError)
        {
            textBox.Text = "";
            if (isError)
            {
                textBox.Text += "Error: ";
            }
            textBox.Text +=text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            owningCollection.Remove(this);
        }

       
    }
}
