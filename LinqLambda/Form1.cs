using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLambda
{
    public partial class Form1 : Form
    {
        DafestyEntities context;
        List<Movie> m;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context = new DafestyEntities();
            

            switch(comboBox1.SelectedItem)
            {
                case "Question 2":
                    Question2();
                    break;
                case "Question 3":
                    Question3();
                    break;
                case "Question 4":
                    Question4();
                    break;
                case "Question 5":
                    Question5();
                    break;
                case "Question 6":
                    Question6();
                    break;
                case "Question 7":
                    Question7();
                    break;
                case "Question 8":
                    Question8();
                    break;
                case "Question 9":
                    Question8();
                    break;
                case "Question 10":
                    Question8();
                    break;
                case "Question 11":
                    Question8();
                    break;
                case "Question 12":
                    Question8();
                    break;
                case "Question 13":
                    Question8();
                    break;
            }
        }

        private void Question2()
        {
            m = context.Movies.OrderBy(x => x.MovieTitle).ToList();
            dataGridView1.DataSource = m;
            var q = from x in context.Movies orderby x.MovieTitle select x;
            dataGridView2.DataSource = q.ToList();
        }

        private void Question3()
        {
            //linq
            var q = from x in context.Movies orderby x.RentalPrice descending select x;
            dataGridView1.DataSource = q.ToList();
            //lambda
            m = context.Movies.OrderByDescending(x => x.RentalPrice).ToList();
            dataGridView2.DataSource = m;


        }

        private void Question4()
        {
            //linq
            var q = from x in context.Movies where x.Rating == "R" select x;
            dataGridView1.DataSource = q.ToList();
            //lambda
            m = context.Movies.Where(x => x.Rating == "R").ToList();
            dataGridView2.DataSource = m;
        }

        private void Question5()
        {
            //linq
            var q = from x in context.Movies where x.MovieType == "Sci-fi" && x.ProducerID == "Warner" select x;
            dataGridView1.DataSource = q.ToList();
            //lambda
            m = context.Movies.Where(x => x.MovieType == "Sci-fi" && x.ProducerID == "Warner").ToList();
            dataGridView2.DataSource = m;
        }

        private void Question6()
        {
            //linq
            var q = (from x in context.Movies where x.MovieType == "Action" select x).Count();
            label1.Text = q.ToString();
            //lambda
            label2.Text = context.Movies.Where(x => x.MovieType == "Action").Count().ToString();
        }

        private void Question7()
        {
            //linq
            m = (from x in context.Movies where x.MovieType == "Action" select x).ToList();
            int total = 0;
            foreach (var q in m)
            {
                total += (int)q.TotalStock;
            }
            label1.Text = total.ToString();
            // q.Sum(x.totalstock);

            //lambda
            label2.Text = context.Movies.Where(x => x.MovieType == "Action").Sum(x => x.TotalStock).ToString();

        }

        private void Question8()
        {
            //linq
            m = (from x in context.Movies where x.MovieType == "Comedy" select x).ToList();
            double total = 0;
            int count = 0;
            foreach (var q in m)
            {
                total += (double)q.RentalPrice;
                count++;
            }
            label1.Text = (total / count).ToString();


            //lambda
            label2.Text = context.Movies.Where(x => x.MovieType == "Comedy").Average(x => x.RentalPrice).ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
