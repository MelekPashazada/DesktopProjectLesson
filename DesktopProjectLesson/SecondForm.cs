using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjectLesson
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i=0;i< checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i].ToString());
            }  
             
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Emine");
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  listBox2.Items.Clear();
        }
    }
}
