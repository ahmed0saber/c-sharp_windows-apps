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
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = counter.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }
    }
}
