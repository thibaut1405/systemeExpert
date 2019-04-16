using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace lesFormes
{
    class BddCaller
    {
        private string connectionString = "Data Source=127.0.0.1;Database=formes;User ID=root;Password='';";
        public MySqlConnection connectionBdd;

        public void Connecter()
        {
            this.connectionBdd = new MySqlConnection(this.connectionString);
            this.connectionBdd.Open();
        }

        public void Deconnecter()
        {
            this.connectionBdd.Close();
        }
        
       
    }
}
