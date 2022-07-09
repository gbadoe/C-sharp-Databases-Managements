using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Base_De_Donnees
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database database = new Database();
            database.ShowDialog();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form= new Form1();
            form.ShowDialog();
        }
    }
}
