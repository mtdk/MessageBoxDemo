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

        private void setMessage(string messageText)
        {
            int number = Math.Abs(messageText.Length / 30);
            if (number != 0)
                this.lblMessageText.Height = number * 25;
            this.lblMessageText.Text = messageText;
        }

        private void addButton(enumMessageButton MessageButton)
        {
            switch(MessageButton)
            {
                case enumMessageButton.OK:
                    {
                        Button btnOk = new Button();
                        btnOk.Text = "OK";
                        btnOk.DialogResult = DialogResult.OK;
                        btnOk.FlatStyle = FlatStyle.Popup;
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.SetBounds(pnlShowMessage.ClientSize.Width - 80, 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnOk);
                    }
                    break;
                case enumMessageButton.OKCancel:
                    {
                        Button btnOk = new Button();
                        btnOk.Text = "OK";
                        btnOk.DialogResult = DialogResult.OK;
                        btnOk.FlatStyle = FlatStyle.Popup;
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.SetBounds((pnlShowMessage.ClientSize.Width - 70), 5, 65, 25);
                        pnlShowMessage.Controls.Add(btnOk);

                        Button btnCancel = new Button();
                        btnCancel.Text = "Cancel";
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Popup;
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - (btnOk.ClientSize.Width + 5 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnCancel);
                    }
                    break;
                case enumMessageButton.YesNo:
                    {
                        Button btnNo = new Button();
                        btnNo.Text = "No";
                        btnNo.DialogResult = DialogResult.No;
                        btnNo.FlatStyle = FlatStyle.Popup;
                        btnNo.FlatAppearance.BorderSize = 0;
                        btnNo.SetBounds((pnlShowMessage.ClientSize.Width - 70), 5, 65, 25);
                        pnlShowMessage.Controls.Add(btnNo);

                        Button btnYes = new Button();
                        btnYes.Text = "Yes";
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Popup;
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnNo.ClientSize.Width + 5 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnYes);
                    }
                    break;
                case enumMessageButton.YesNoCancel:
                    {
                        Button btnCancel = new Button();
                        btnCancel.Text = "Cancel";
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Popup;
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - 70), 5, 65, 25);
                        pnlShowMessage.Controls.Add(btnCancel);

                        Button btnNo = new Button();
                        btnNo.Text = "No";
                        btnNo.DialogResult = DialogResult.No;
                        btnNo.FlatStyle = FlatStyle.Popup;
                        btnNo.FlatAppearance.BorderSize = 0;
                        btnNo.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + 5 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnNo);

                        Button btnYes = new Button();
                        btnYes.Text = "Yes";
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Popup;
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + btnNo.ClientSize.Width + 10 + 80)), 5, 75, 25);
                        pnlShowMessage.Controls.Add(btnYes);
                    }
                    break;
            }
        }

        private void addIconImage(enumMessageIcon MessageIcon)
        {
            switch (MessageIcon)
            {
                case enumMessageIcon.Error:
                    pictureBox1.Image = imageList1.Images["Error"];
                    break;
                case enumMessageIcon.Warning:
                    pictureBox1.Image = imageList1.Images["Warning"];
                    break;
                case enumMessageIcon.Information:
                    pictureBox1.Image = imageList1.Images["Information"];
                    break;
                case enumMessageIcon.Question:
                    pictureBox1.Image = imageList1.Images["Question"];
                    break;
            }
        }

        internal static void Show(string messageText)
        {
            frmShowMessage frmMessage = new frmShowMessage();
            frmMessage.setMessage(messageText);
            frmMessage.addIconImage(enumMessageIcon.Information);
            frmMessage.addButton(enumMessageButton.OK);
            frmMessage.ShowDialog();
        }

        internal static void Show(string messageText,string messageTitle)
        {
            frmShowMessage frmMessage = new frmShowMessage();
            frmMessage.Text = messageTitle;
            frmMessage.setMessage(messageText);
            frmMessage.addIconImage(enumMessageIcon.Information);
            frmMessage.addButton(enumMessageButton.OK);
            frmMessage.ShowDialog();
        }

        internal static void Show(string messageText,string messageTitle,enumMessageIcon messageIcon,enumMessageButton messageButton)
        {
            frmShowMessage frmMessage = new frmShowMessage();
            frmMessage.Text = messageTitle;
            frmMessage.setMessage(messageText);
            frmMessage.addIconImage(messageIcon);
            frmMessage.addButton(messageButton);
            frmMessage.ShowDialog();
        }

        internal enum enumMessageIcon
        {
            Error,
            Warning,
            Information,
            Question,
        }

        internal enum enumMessageButton
        {
            OK,
            YesNo,
            YesNoCancel,
            OKCancel
        }

    }
}
