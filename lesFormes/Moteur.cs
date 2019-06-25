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
            nbCotes.SelectedIndex = 0;
            nbAnglesDroit.SelectedIndex = 0;
            nbCotesLongueur.SelectedIndex = 0;
            nbCotesParallele.SelectedIndex = 0;
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
            

            if (!baseFait.ExecuteQuery(nbCotesSelected, nbCotesLongueurSelected, nbAnglesDroitSelected, nbCotesParalleleSelected))
            {
                BaseDeRegle testForm = new BaseDeRegle(nbCotesSelected, nbCotesLongueurSelected, nbAnglesDroitSelected, nbCotesParalleleSelected);
                testForm.VerifyForm();
            }

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
