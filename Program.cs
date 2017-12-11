using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace search_engine_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engine Google = new Engine("Donald");
            Articles Data = new Articles();
            //Data.search("UsA");

            string RAW_DATA = File.ReadAllText(@"M:\Github\search-engine\raw_data.txt", Encoding.UTF8);
            string[] RAW_ARTICLE = RAW_DATA.Split('.');
            foreach (var item in RAW_ARTICLE)
            {
                string[] title = item.Split(',');
                Data.AddToEnd(title[0], title[1]);
            }
            Data.print();

        }
    }
}
