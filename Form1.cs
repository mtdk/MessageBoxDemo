using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShowMessage.Show("这是我自定义的messagebox", "提示", frmShowMessage.enumMessageIcon.Question, frmShowMessage.enumMessageButton.YesNoCancel);
        }
    }
}
