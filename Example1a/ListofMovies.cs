using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1a
{
    public partial class ListofMovies : Form
    {
        public ListofMovies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";

            SqlConnection cn = new SqlConnection(conS);

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "Select * from movies";
            cm.Connection = cn;

            cn.Open();
            SqlDataReader rd = cm.ExecuteReader();
            while(rd.Read())
            {
                listBox1.Items.Add(rd["MovieTitle"]);
            }
           // listBox1.DataSource = rd;
            cn.Close();
        }
    }
}
