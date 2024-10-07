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
    public partial class AdminDashboard : Form
    {
        private Admin admin;

        public AdminDashboard(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
