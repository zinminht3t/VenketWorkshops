using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCRUDwithEntity
{
    public partial class Form1 : Form
    {
        DafestyEntities context;
        int count = 0;
        List<Movie> movielist;
        int listcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new DafestyEntities();
            movielist = context.Movies1.ToList();
            listcount = movielist.Count() - 1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PopulateTextBox();
        }

        private void PopulateTextBox()
        {
            txtID.Text = movielist[count].VideoCode.ToString();
            txtName.Text = movielist[count].MovieTitle.ToString();
            txtPrice.Text = movielist[count].RentalPrice.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count < listcount)
                count++;

            PopulateTextBox();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (count > 0)
                count--;
            PopulateTextBox();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            count = 0;
            PopulateTextBox();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            count = listcount;
            PopulateTextBox();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();
            newMovie.VideoCode = Convert.ToInt16(txtID.Text);
            newMovie.MovieTitle = txtName.Text.ToString();
            newMovie.RentalPrice = float.Parse(txtPrice.Text);
            context.Movies1.Add(newMovie);
            context.SaveChanges();
            listcount++;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            movielist[count].MovieTitle = txtName.Text.ToString();
            movielist[count].RentalPrice = float.Parse(txtPrice.Text);
            context.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            context.Movies1.Remove(movielist[count]);
            context.SaveChanges();
            listcount--;
        }
    }
}
