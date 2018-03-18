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

namespace MovieCRUD
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;

        int count = 0;
        int lastrow = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.CommandText = "Select videocode, movietitle, rentalprice from movies";
            cm.Connection = cn;
            da = new SqlDataAdapter(cm);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Movies");
            lastrow = ds.Tables[0].Rows.Count - 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            count = lastrow;
            FillTextBox();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(count < lastrow)
                count++;
            FillTextBox();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (count == 0) { }
            else
            {
                count--;
            }
            FillTextBox();
        }
        
        private void FillTextBox()
        {
            txtID.Text = ds.Tables[0].Rows[count]["videocode"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[count]["movietitle"].ToString();
            txtPrice.Text = ds.Tables[0].Rows[count]["rentalprice"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            count = 0;
            FillTextBox();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows[count]["videocode"] = txtID.Text;
            ds.Tables[0].Rows[count]["movietitle"] = txtTitle.Text;
            ds.Tables[0].Rows[count]["rentalprice"] = txtPrice.Text;
            cmb.GetUpdateCommand();
            da.Update(ds, "Movies");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables[0].NewRow();
            r["videocode"] = txtID.Text;
            r["movietitle"] = txtTitle.Text;
            r["rentalprice"] = txtPrice.Text;
            ds.Tables[0].Rows.Add(r);
            da.Update(ds, "Movies");
            lastrow++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables[0].Rows[count];
            r.Delete();
            da.Update(ds, "Movies");
            lastrow--;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable table = ds.Tables["Movies"];
            table.PrimaryKey = new DataColumn[] { table.Columns["VideoCode"] };
            DataRow r = table.Rows.Find(txtFind.Text);
            if (r == null)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                txtID.Text = r[0].ToString();
                txtTitle.Text = r[1].ToString();
                txtPrice.Text = r[2].ToString();
            }

        }
    }
}
