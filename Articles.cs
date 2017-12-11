using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_engine_project
{
    class Articles {
        Article Head;
        public Articles()
        {
            Head = null;
        }
        public void AddToEnd(string title, string keyword)
        {
            if (Head == null)
                Head = new Article(title, keyword);
            else
            {
                Head.AddToEnd(title, keyword);
            }
        }
        // a method to seacrh for articles using a string `query` and should prints the seacrh results
        public void search(string query) {
            Console.WriteLine("showing " + 8 + " results for `" + query + "`");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            if (Head != null)
                Head.search(query);
        }
        public void print()
        {
            if (Head != null)
                Head.print();
        }
       
    }
}
