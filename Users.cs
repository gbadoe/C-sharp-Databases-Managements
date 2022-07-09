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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-D7RUA3Q\SQLEXPRESS;Initial Catalog=Managements;Integrated Security=True");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        void View()
        {
            try
            {
                Con.Open();
                string query = " select * from Utilisateurs";
                SqlDataAdapter sql = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sql);
                var ds = new DataSet();
                sql.Fill(ds);
                Dataview.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (Txtusername.Text == "" || Txtfullname.Text == "" || Txtpassword.Text == "" || Txttelephone.Text == "")
                {
                    MessageBox.Show("Veuillez entrer les champs sont vides");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand
                    ("insert into Utilisateurs values('" + Txtusername.Text + "', '" + Txtfullname.Text + "','" + Txtpassword.Text + "','" + Txttelephone.Text + "')", Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateurs ajouté avec succès");
                    Con.Close();
                    View();
                    Txtusername.Text = "";
                    Txtfullname.Text = "";
                    Txtpassword.Text = "";
                    Txttelephone.Text = "";

                }
            }


            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            View();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Txttelephone.Text == "")
            {
                MessageBox.Show("Entrez le numero de telephone");
            }

            else
            {
                Con.Open();
                string myquery = "delete from utilisateurs where Uphone='" + Txttelephone.Text + "'; ";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("utilisateur supprimé avec succes");
                Con.Close();
                View();
                Txtusername.Text = "";
                Txtfullname.Text = "";
                Txtpassword.Text = "";
                Txttelephone.Text = "";

            }
        }

        private void Dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dataview.Rows[e.RowIndex];
                Txtusername.Text = row.Cells[0].Value.ToString();
                Txtfullname.Text = row.Cells[1].Value.ToString();
                Txtpassword.Text = row.Cells[2].Value.ToString();
                Txttelephone.Text = row.Cells[3].Value.ToString();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtusername.Text == "" || Txtfullname.Text == "" || Txtpassword.Text == "" || Txttelephone.Text == "")
                {
                    MessageBox.Show("Veuillez entrer les informations");
                }

                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update utilisateurs set Uname='" + Txtusername.Text + "', Ufullname='" + Txtfullname.Text + "', " + "Upassword='" + Txtpassword.Text + "' where Uphone='" + Txttelephone.Text + "'", Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateurs modifié avec succès");
                    Con.Close();
                    View();
                    Txtusername.Text = "";
                    Txtfullname.Text = "";
                    Txtpassword.Text = "";
                    Txttelephone.Text = "";
                }
            }


            catch
            {

            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}