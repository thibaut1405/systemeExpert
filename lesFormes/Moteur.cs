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
    public partial class Moteur : Form
    {
        public Moteur()
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
            int nbCotesSelected = Convert.ToInt32(nbCotes.SelectedItem);
            int nbCotesLongueurSelected = Convert.ToInt32(nbCotesLongueur.SelectedItem);
            int nbAnglesDroitSelected = Convert.ToInt32(nbAnglesDroit.SelectedItem);
            int nbCotesParalleleSelected = Convert.ToInt32(nbCotesParallele.SelectedItem);

            BaseDeRegle compare = new BaseDeRegle(nbCotesSelected,nbCotesLongueurSelected, nbAnglesDroitSelected, nbCotesParalleleSelected);

            BaseDeFaits baseFait = new BaseDeFaits();
            baseFait.ExecuteQuery(nbCotesSelected, nbCotesLongueurSelected, nbAnglesDroitSelected, nbCotesParalleleSelected);

            resultRech.Text = global.resultRech;
        }

        

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Moteur_Load(object sender, EventArgs e)
        {

        }
    }
}
