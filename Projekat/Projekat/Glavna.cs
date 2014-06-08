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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void dodajLetToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (polaziste.SelectedIndex == destinacija.SelectedIndex)
            {
                errorProvider1.SetError(destinacija, "Greska");
                trakaGreske.Text = "Polaziste i destinacija su iste!";
            }
            else if(polijetanje.Value > slijetanje.Value)
            {
                errorProvider1.SetError(polijetanje, "Greska");
                trakaGreske.Text = "Nije moguće slijetanje prije polijetanja";
            }
            else
            {
                Let let1 = new Let(polaziste.SelectedText,destinacija.SelectedText,Convert.ToDateTime(polijetanje.Value), Convert.ToDateTime(slijetanje.Value),gatebox.Text);
            }
        }

        
    }
}