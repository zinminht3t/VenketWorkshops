using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrans
{
    public partial class CustomerLookup : Form
    {
        public static string customerid;
        public static string customername;
        public CustomerLookup()
        {
            InitializeComponent();
        }

        private void CustomerLookup_Load(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            dataGridView1.DataSource = ctx.Customers.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customerid = dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            customername = dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            this.Close();
        }
    }
}
