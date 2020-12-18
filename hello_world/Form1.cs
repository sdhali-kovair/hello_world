using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_world
{
    public partial class Hello_World : Form
    {
        public Hello_World()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("hello World");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
