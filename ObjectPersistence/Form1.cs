using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectPersistence
{
    public partial class Form1 : Form
    {
        DafestyEntities ctx;
        List<Movie> m;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void Question1()
        {

        }
        private void Question2()
        {

        }
        private void Question3()
        {

        }
        private void Question4a()
        {
           // Movie m = new Movie();
            m = new List<Movie>();
            m.Add(ctx.Movies.First(x => x.VideoCode == 5));
            dataGridView1.DataSource = m;
        }
        private void Question4b() 
        {
            ctx.Movies.First(x => x.VideoCode == 5).RentalCost = (float) 1.8;
            ctx.SaveChanges();
        }
        private void Question4c()
        {
            Movie newm = new Movie();
            newm.VideoCode = 400;
            newm.MovieTitle = "Sully";
            newm.ProducerID = "Warner";
            newm.RentalCost = (float)2.50;
            newm.Rating = "U";
            newm.TotalStock = 4;
            ctx.Movies.Add(newm);
            ctx.SaveChanges();
        }
        private void Question4d()
        {

        }
        private void Question4e()
        {

        }
        private void Question4f()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx = new DafestyEntities();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Question 1":
                    Question1();
                    break;
                case "Question 2":
                    Question2();
                    break;
                case "Question 3":
                    Question3();
                    break;
                case "Question 4 a":
                    Question4a();
                    break;
                case "Question 4 b":
                    Question4b();
                    break;
                case "Question 4c":
                    Question4c();
                    break;
                case "Question 4 d":
                    Question4d();
                    break;
                case "Question 4 e":
                    Question4e();
                    break;
                case "Question 4 f":
                    Question4f();
                    break;
            }

        }
    }
}
