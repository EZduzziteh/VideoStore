using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VideoStore.DataModels;

namespace VideoStore
{
    public partial class Container : UserControl
    {
        List<UserControl> UserControlList;

        int yAxis = 0;
        int movieCount = 0;


        public Container()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            UserControlList = new List<UserControl>();
        }


        public void AddMovie(ResultsData results)
        {
            movieCount++;
            MovieDisplay movieDisplay = new MovieDisplay(results);
            movieDisplay.Location=new Point(0, yAxis - panel1.VerticalScroll.Value);
            UserControlList.Add(movieDisplay);
            panel1.Controls.Add(movieDisplay);
            yAxis += movieDisplay.Height;
        }

        public void Clear()
        {
            
            while (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }

            UserControlList.Clear(); //new userlist
            yAxis = 0;
            movieCount = 0;
            
        }
    }
}
