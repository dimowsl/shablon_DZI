using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aboutUs1.Hide();
            vhod1.Hide();
            register1.Hide();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs1.Hide();
           vhod1.Show();
            vhod1.BringToFront();
            register1.Hide();
        }

        private void галерияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gallery = new Gallery();
            gallery.Closed += (s, args) => this.Close();
            gallery.Show();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs1.Show();
            aboutUs1.BringToFront();
            vhod1.Hide();
            register1.Hide();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutUs1_Load(object sender, EventArgs e)
        {

        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs1.Hide();
            vhod1.Hide();
            register1.Hide();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs1.Hide();
            vhod1.Hide();
            register1.Show();
            register1.BringToFront();
        }
    }
}
