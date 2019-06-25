using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesFormes
{
    class BaseDeRegle
    {
        int cotes = 0;
        int nbCotesTaille = 0;
        int nbAnglesDroit = 0;
        int nbCotesParallele = 0;
        string forme = "";
        public BaseDeRegle(int p_nbCotes,int p_nbCotesTaille,int p_nbAnglesDroit,int p_nbCotesParallele)
        {
            cotes = p_nbCotes;
            nbCotesTaille = p_nbCotesTaille;
            nbAnglesDroit = p_nbAnglesDroit;
            nbCotesParallele = p_nbCotesParallele;
            
        }
        public void VerifyForm()
        {
            if (nbCotesParallele > cotes || nbAnglesDroit > cotes || nbCotesTaille > cotes) {
                global.resultRech = "Forme impossible";
            } else
            { 
                if (cotes == 3) forme = "Triangle";
                if (cotes == 4) forme = "Quadrilatère";
                if (cotes == 5) forme = "Pentagone";

                if (forme == "Triangle")
                {
                    if (nbCotesTaille == 3) forme += " equilatéral";
                    if (nbAnglesDroit == 1) forme += " rectangle";
                    if (nbCotesTaille == 2) forme += " isocele";
                    if (nbAnglesDroit == 2) forme = "Forme impossible";
                    if (nbCotesParallele == 1) forme = "Forme impossible";
                    if (nbCotesParallele == 2) forme = "Forme impossible";
                    if (nbCotesParallele == 3) forme = "Forme impossible";
                    if (forme == "Triangle") forme += " quelconque";
                }
                else
                if (forme == "Quadrilatère")
                {

                    if (nbCotesParallele == 2 && nbAnglesDroit == 0 && nbCotesTaille == 2) forme += " trapèze";
                    if (nbCotesParallele == 2 && nbCotesTaille == 2 && nbAnglesDroit == 0) forme += " parallélogramme";
                    if (nbCotesTaille == 4 && nbCotesParallele == 2 && nbAnglesDroit == 0) forme += " losange";
                    if (nbCotesTaille == 2 && nbAnglesDroit == 4 && nbCotesParallele == 2) forme += " rectangle";
                    if (nbCotesTaille == 4 && nbAnglesDroit == 4 && nbCotesParallele == 4) forme += " carré";
                    if (forme == "Quadrilatère") forme += " quelconque";
                }
                else
                if (forme == "Pentagone")
                {
                    if (nbCotesParallele == 0 && nbAnglesDroit == 0 && nbCotesTaille == 5) forme += " parfait";
                    if (forme == "Pentagone") forme += " quelconque";
                }

                global.resultRech = forme;
                string query = "INSERT INTO data (NbCotes,NbCotesPara,NbCotesEgaux,NbAnglesDroits,nomFigure) VALUES (" + cotes + "," + nbCotesParallele + "," + nbCotesTaille + "," + nbAnglesDroit + ",'" + forme + "' );";
                BddCaller bdd = new BddCaller();
                bdd.Connecter();
                MySqlCommand command = new MySqlCommand(query, bdd.connectionBdd);
                command.ExecuteNonQuery();
            }
        }
        
    }
}
