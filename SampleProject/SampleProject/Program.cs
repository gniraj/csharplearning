using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            asyncawaits e = new asyncawaits();
            e.entrypoint1();
            e.entrypoint2();
        }
    }
}
