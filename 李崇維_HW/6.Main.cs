using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 李崇維_HW
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogOn l = new LogOn();
            l.Show();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCategoryProducts fp = new FrmCategoryProducts();
            fp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProducts fr = new FrmProducts();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAdventureWork fw = new FrmAdventureWork();
            fw.Show();
        }
    }
}
