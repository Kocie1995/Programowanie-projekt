using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Start_butt_Click(object sender, EventArgs e)
        {
            
            Form2 frm = new Form2();
            frm.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pomoc_Click(object sender, EventArgs e)
        {
            //bedzie wyswietlac pomoc
        }

        private void Ranking_Click(object sender, EventArgs e)
        {
            //wyswietlenie wynikow z bazy danych w ktorej beda trzymane wyniki
        }

        private void Exit_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
