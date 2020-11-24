using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MessageBoxDemo
{
    public partial class frmShowMessage : Form
    {
        public frmShowMessage()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.SkyBlue, Color.AliceBlue, 60);
            e.Graphics.FillRectangle(brush, rect);
            base.OnPaint(e);
        }


    }
}
