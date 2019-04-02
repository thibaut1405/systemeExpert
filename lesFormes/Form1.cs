using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesFormes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nbCotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nbAnglesDroit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nbCotesLongueur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nbCotesParallele_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           string test = nbCotes.SelectedIndex.ToString();
            Console.WriteLine(test);
        }
    }
}
