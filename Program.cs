using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace search_engine_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine Google = new Engine("raw_data.txt");
            Google.Search("machine learning");
        }
    }
}
