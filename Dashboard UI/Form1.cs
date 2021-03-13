using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard_UI;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnAnalytics_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalytics.Height;
            PnlNav.Top = BtnAnalytics.Top;
            PnlNav.Left = BtnAnalytics.Left;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.PnlFormLoader.Controls.Clear();
            frmAnalytics FrmDashboard_Vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnCalendar_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = BtnCalendar.Height;
            PnlNav.Top = BtnCalendar.Top;
            PnlNav.Left = BtnCalendar.Left;
            BtnCalendar.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calendar";
            this.PnlFormLoader.Controls.Clear();
            frmCalendar FrmDashboard_Vrb = new frmCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnContactus_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = BtnContactus.Height;
            PnlNav.Top = BtnContactus.Top;
            PnlNav.Left = BtnContactus.Left;
            BtnContactus.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Contact Us";
            this.PnlFormLoader.Controls.Clear();
            frmContactUs FrmDashboard_Vrb = new frmContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            PnlNav.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            frmSettings FrmDashboard_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Leave_1(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalendar_Leave(object sender, EventArgs e)
        {
            BtnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContactus_Leave(object sender, EventArgs e)
        {
            BtnContactus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
