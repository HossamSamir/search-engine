using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_engine_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engine Google = new Engine("Donald");
            Articles Data = new Articles();
            Data.AddToEnd("How many pyramids does it take to reach her head?", "Egypt");
            Data.AddToEnd("USA TODAY investigations underscore how potential conflicts make it look as if the Oval Office is for sale: Our view USA TODAY investigations show how potential conflicts make it looks as if the Oval Office is for sale: Our view There have always been ways to…", "wrong tag");
            Data.search("UsA");
        }
    }
}
