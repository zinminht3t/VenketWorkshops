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
    public partial class VideoLookup : Form
    {
        public static string videocode = "";
        public static string movietitle = "";
        public VideoLookup()
        {
            InitializeComponent();
        }

        private void VideoLookup_Load(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            dataGridView1.DataSource = ctx.Movies.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            videocode = dataGridView1.Rows[e.RowIndex].Cells["VideoCode"].Value.ToString();
            movietitle = dataGridView1.Rows[e.RowIndex].Cells["MovieTitle"].Value.ToString();
            this.Close();
        }
    }
}
