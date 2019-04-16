using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesFormes
{
    class BaseDeFaits : Moteur
    {
        public void ExecuteQuery(int p_nbCotes, int p_nbCotesEgaux, int p_nbAnglesDroits, int p_nbCotesPara)
        {
            string query = "SELECT * FROM data WHERE NbCotes = "+ p_nbCotes +" AND NbCotesPara ="+ p_nbCotesPara + " AND NbCotesEgaux = "+ p_nbCotesEgaux + " AND NbAnglesDroits = "+ p_nbAnglesDroits + ";";
            BddCaller bdd = new BddCaller();
            bdd.Connecter();
            MySqlCommand command = new MySqlCommand(query, bdd.connectionBdd);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int nbCotes = reader.GetInt32(1);
                    int nbCotesPara = reader.GetInt32(2);
                    int nbCotesEgaux = reader.GetInt32(3);
                    int nbAnglesDroits = reader.GetInt32(4);
                    string nomFigure = reader.GetString(5);

                    global.resultRech = nomFigure;


                }
            } catch
            {
                // il faudra appeler la base de règle
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
