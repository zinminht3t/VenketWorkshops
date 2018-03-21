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
    public partial class Form1 : Form
    {
        DafestyEntities ctx;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerLookup clfrm = new CustomerLookup();
            clfrm.ShowDialog();

            txtCusID.Text = CustomerLookup.customerid;
            txtRCusID.Text = CustomerLookup.customername;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx = new DafestyEntities();
            SetDates();
        }

        private void SetDates()
        {
            dtpIssue.MinDate = DateTime.Today;
            dtpDue.MinDate = DateTime.Today.AddDays(20);
        }

        private void btnVideoFrm_Click(object sender, EventArgs e)
        {
            VideoLookup vlfrm = new VideoLookup();
            vlfrm.ShowDialog();

            txtRVideoCode.Text = VideoLookup.movietitle;
            txtVideoCode.Text = VideoLookup.videocode;
        }

        private void dtpIssue_ValueChanged(object sender, EventArgs e)
        {
            dtpDue.MinDate = dtpIssue.Value.AddDays(20);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtRCusID.Text == "" || txtRVideoCode.Text == "")
            {
                MessageBox.Show("There is no customer or video in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    IssueTran newtrans = new IssueTran();
                    newtrans.CustomerID = txtCusID.Text;
                    newtrans.VideoCode = Convert.ToInt16(txtVideoCode.Text);
                    newtrans.DateIssue = dtpIssue.Value;
                    newtrans.DateDue = dtpDue.Value;
                    newtrans.DateActualReturn = null;
                    newtrans.RentalStatus = "IN";
                    newtrans.Remarks = textBox1.Text;
                    ctx.IssueTrans.Add(newtrans);
                    ctx.SaveChanges();
                    MessageBox.Show("Transaction Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTextBox();
                }
                catch
                {
                    MessageBox.Show("Error Occurred! Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetTextBox();
                }


            }
        }

        public void ResetTextBox()
        {
            txtCusID.Text = "";
            txtRCusID.Text = "";
            txtVideoCode.Text = "";
            txtRVideoCode.Text = "";
            SetDates();
            textBox1.Text = "";
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cusid = txtCusID.Text;
                txtRCusID.Text = ctx.Customers.First(x => x.CustomerID == cusid).CustomerName.ToString();
            }
            catch
            {
                txtRCusID.Text = "";
            }
        }

        private void txtVideoCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int vid = Convert.ToInt16(txtVideoCode.Text);
                txtRVideoCode.Text = ctx.Movies.First(x => x.VideoCode == vid).MovieTitle.ToString();
            }
            catch
            {
                txtRVideoCode.Text = "";
            }
        }
    }
}
