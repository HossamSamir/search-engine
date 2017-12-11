using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_engine_project
{
    class Article
    {
        public string title;
        public string keyword;
        public Article next;
        public Article(string title, string keyword)
        {
            this.title = title;
            this.keyword = keyword;
            next = null;
        }
        public void AddToEnd(string title, string keyword)
        {
            if (next == null)
                next = new Article(title, keyword);
            else
            {
                next.AddToEnd(title, keyword);
            }
        }
        public void print()
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine(keyword);
            Console.WriteLine();
            if (next != null)
                next.print();
        }
        public void search(string query)
        {
            Console.WriteLine();
            if(keyword.ToLower().Contains(query.ToLower()) || title.ToLower().Contains(query.ToLower())) {
                Console.WriteLine(title);
                Console.WriteLine();
            }
            if (next != null)
                next.search(query);
        }
    }
}
