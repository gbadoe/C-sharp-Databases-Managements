using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Management_Base_De_Donnees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-D7RUA3Q\SQLEXPRESS;Initial Catalog=Managements;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                TxtPass.PasswordChar = '\0';
            }
            else
            {
                TxtPass.PasswordChar = '*';
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtPass.Text = "";
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            string username = TxtName.Text;
            string password = TxtPass.Text;
            SqlCommand cmd = new SqlCommand("select Uname,Upassword from Utilisateurs where Uname='" + TxtName.Text + "'and Upassword='" + TxtPass.Text + "'",Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            Con.Close();
            MessageBox.Show("Invalid username or password");

            Con.Close();
        }
    }
}
