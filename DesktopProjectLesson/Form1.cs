namespace DesktopProjectLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm f = new SecondForm();
            f.Show();
            this.Hide();
            //if (radioButton1.)
            //{
            //    checkBox1.Checked = true;
            //}
            //else
            //{
            //    checkBox1.Checked = false;
            //}
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboBox combo=new ComboBox();
            combo.Show();
            

        }
    }
}