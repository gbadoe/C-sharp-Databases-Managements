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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

     SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-D7RUA3Q\SQLEXPRESS;Initial Catalog=Managements;Integrated Security=True");

        void View()
        {
            try
            {
                Conn.Open();
                string query = " select * from Database";
                SqlDataAdapter sql = new SqlDataAdapter(query, Conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sql);
                var ds = new DataSet();
                sql.Fill(ds);
                DataView1.DataSource = ds.Tables[0];
                Conn.Close();

            }
            catch
            {

            }
        }

        void View1()
        {
            try
            {
                Conn.Open();
                string query = " select * from Table";
                SqlDataAdapter sql = new SqlDataAdapter(query, Conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sql);
                var ds = new DataSet();
                sql.Fill(ds);
                DataView2.DataSource = ds.Tables[0];
                Conn.Close();

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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                databaseBindingSource.AddNew();
                


            }


            catch
            {
                MessageBox.Show("Internal server error");
            }
        }



        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Txtid.Text == "" || TxtName.Text == "" || TxtDescription.Text == "")
            {
                MessageBox.Show("Empty please");
            }
            else
            {
                databaseBindingSource.EndEdit();
                databaseTableAdapter.Update(managementsDataSet3.Database);
                MessageBox.Show("Success added");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            databaseBindingSource.RemoveCurrent();
            MessageBox.Show("Success deleted");
        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'managementsDataSet4.Table'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tableTableAdapter.Fill(this.managementsDataSet4.Table);
           
            // TODO: cette ligne de code charge les données dans la table 'managementsDataSet3.Database'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.databaseTableAdapter.Fill(this.managementsDataSet3.Database);

            View();

        }

        private void DataView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataView1.Rows[e.RowIndex];
                Txtid.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();
                TxtDescription.Text = row.Cells[2].Value.ToString();

            }
        }

        private void DataView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataView2.Rows[e.RowIndex];
                Tableid.Text = row.Cells[0].Value.ToString();
                Databasetable.Text = row.Cells[1].Value.ToString();
                TxtDescription.Text = row.Cells[2].Value.ToString();

            }
        }

        private void BtnEdit1_Click(object sender, EventArgs e)
        {
            if (TxtName.Text=="" || Table.Text=="")
            {
                MessageBox.Show("veuillez remplir");
            }
            else
            {
                tableBindingSource.EndEdit();
                tableTableAdapter.Update(managementsDataSet4.Table);
                MessageBox.Show("Success Add");
            }
        }

        private void BtnCreate1_Click(object sender, EventArgs e)
        {
            tableBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseBindingSource.RemoveCurrent();
            MessageBox.Show("Success deleted");
        }
    }
}
