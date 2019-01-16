using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprinkle
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //to read the about html page
            aboutBrowser.DocumentText = System.IO.File.ReadAllText("About/about.html");
        }
    }
}
