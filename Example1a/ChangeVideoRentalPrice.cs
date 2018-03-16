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
    public partial class ChangeVideoRentalPrice : Form
    {
        public ChangeVideoRentalPrice()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.ToString();
            string price = txtPrice.Text.ToString();

            if (code == "" || price == "")
            {
                MessageBox.Show("Fill all the input box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string conS = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
                SqlConnection cn = new SqlConnection(conS);

                SqlCommand cm = new SqlCommand();
                cm.CommandText = "Update movies set rentalprice = '" + price + "' where videocode = '" + code + "'";
                cm.Connection = cn;

                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show( "Update Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
