using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityModels
{
    public partial class Form1 : Form
    {
        DafestyEntities context;
        public Form1()
        {
            context = new DafestyEntities();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Movies.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            Movie a;
            try
            {
                id = Convert.ToInt32(txtID.Text);
                var query = from x in context.Movies where x.VideoCode == id select x.MovieTitle;

                a = new Movie
                {
                    MovieTitle = query.First()
                };
                label1.Text = a.MovieTitle;

                label1.Text = query.GetType().ToString();
            }
            catch
            {
                label1.Text = "Not found";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
