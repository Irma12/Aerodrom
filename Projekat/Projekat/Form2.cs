using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dodajLetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Let l = new Let();
            l.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Let l = new Let();
            l.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}