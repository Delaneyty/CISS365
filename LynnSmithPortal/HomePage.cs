using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LynnSmithPortal
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        //student link label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LoginForm loginForm = new LoginForm(1);
            loginForm.ShowDialog();
        }

        private void adminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(4);
            loginForm.ShowDialog();
        }

        private void facultyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(3);
            loginForm.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
