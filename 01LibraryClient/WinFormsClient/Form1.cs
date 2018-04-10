using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLibrary;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context ctx = new Context();
            label1.Text = ctx.Computer;
            label2.Text = ctx.User;
            label3.Text = ctx.Today.ToShortDateString();

        }
    }
}
