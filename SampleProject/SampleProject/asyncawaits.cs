using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject
{
    class asyncawaits
    {
        public void entrypoint()
        {
            Console.WriteLine("here1");
            string result = DownloadContent().Result;
            Console.WriteLine("here1");
            Console.WriteLine(result);
            Console.WriteLine("here2");
            Console.Read();
        }

        public async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("here3");
                await task1();
                Console.WriteLine("here4");
                return "done";
            }
        }

        public async Task task1()
        {
            Thread.Sleep(1000000);
        }
    }
}
