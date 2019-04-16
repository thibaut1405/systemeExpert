using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesFormes
{
    class BaseDeRegle
    {
        int nbCotes = 0;
        int nbCotesTaille = 0;
        int nbAnglesDroit = 0;
        int nbCotesParallele = 0;
        public BaseDeRegle(int p_nbCotes,int p_nbCotesTaille,int p_nbAnglesDroit,int p_nbCotesParallele)
        {
            nbCotes = p_nbCotes;
            nbCotesTaille = p_nbCotesTaille;
            nbAnglesDroit = p_nbAnglesDroit;
            nbCotesParallele = p_nbCotesParallele;
            
        }
        public void testForme()
        {
            
        }
    }
}
