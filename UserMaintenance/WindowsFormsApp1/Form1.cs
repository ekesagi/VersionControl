using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName; // label1
            lblFirstName.Text = Resource1.FirstName; // label2
            btnAdd.Text = Resource1.Add; // button1
        }
    }
}
