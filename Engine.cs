using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_engine_project
{
    class Engine
    {
        public Engine(string query) {
            Articles myarticles = new Articles();
            myarticles.AddToEnd("Donald J. Trump isn't following Colin Kaepernick and Stephen Curry for being dark. He's following them for slighting America. Tail me on Twitter", "Donald");
            myarticles.AddToEnd("title2", "tag2");
            //myarticles.print();
            myarticles.search(query);
        }

    }
}
