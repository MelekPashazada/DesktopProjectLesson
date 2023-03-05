using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjectLesson
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            ComboBox combo=new ComboBox();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar2.Maximum = 1000;
            progressBar1.Value = progressBar1.Value+100;
            timer1.Enabled = true;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ComboBox_Load_1(object sender, EventArgs e)
        {
            //label1.Text=timer1.Interval.ToString();

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Gray,
                                                                       Color.Black,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation=openFileDialog1.FileName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sekli deyisdirmek ucun import duymesine klikleyin!!!");
        }
    }
}
