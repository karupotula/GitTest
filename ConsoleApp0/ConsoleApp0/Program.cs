using DataLibrary;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp0
{
    class Program
    {
        static RatnigSvc.RatingServicePortTypeClient.EndpointConfiguration endpointConfiguration = new RatnigSvc.RatingServicePortTypeClient.EndpointConfiguration();
        static RatnigSvc.RatingServicePortTypeClient svcClient = new RatnigSvc.RatingServicePortTypeClient(endpointConfiguration);
        static int count = 0;
        static void Main(string[] args)
        {
            AlgorithmData algData = new AlgorithmData();
            var l_algoList = algData.GetBlocks();

            //Task.Run(async () =>
            //{
            //    // Do any async anything you need here without worry
            //    List<string> l_lsit = new List<string>();
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();

            //    //Parallel.For(0, 2500, (e) =>
            //    //{
            //    //    ReadFile();
            //    //});

            //    SaveFiles();

            //    //string str = ReadFile1();
            //    //var test = await svcClient.getRateAsync(str);

            //    stopwatch.Stop();
            //    Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            //    Console.ReadKey();
            //}).GetAwaiter().GetResult();
        }
        public static bool CheckString(string exp)
        {
            bool res = true;
            char[] charArray = exp.ToCharArray();
            Stack<string> st = new Stack<string>();

            foreach (char i in charArray)
            {

                string item = i.ToString();
                if (item == "(")
                {

                    st.Push(item);
                }
                else if (st.Count > 0)
                {
                    if (item == ")")
                    {
                        if (st.Peek().ToString() == "(")
                        {

                            st.Pop();
                        }
                        else
                        {
                            res = false;
                        }
                    }
                }
                else
                {
                    res = false;
                }

            }//for


            return res;
        }


        static Random rnd = new Random();
        static string ReadFile1()
        {
            string l_lines = string.Empty;
            try
            {
                List<string> l_lsit = new List<string>();

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                string path = @"M:\WahtifRequests\Request" + rnd.Next(1, 5) + ".xml";
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        l_lines += line;
                    }
                }
                //await WriteFile(l_lsit);

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return l_lines;
        }

        static async Task ReadFile()
        {
            try
            {
                List<string> l_lsit = new List<string>();
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"M:\perform\Request.xml"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        l_lsit.Add(line);
                        Console.WriteLine(line);
                    }
                }
                //await WriteFile(l_lsit);
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            //Console.ReadKey();
        }
        static async Task WriteFile(List<string> l_lsit)
        {
            //int milliseconds = 2000;
            //Thread.Sleep(milliseconds);

            string guid = Guid.NewGuid().ToString();
            using (StreamWriter sw = new StreamWriter($"M:\\perform\\{guid}.xml"))
            {
                foreach (string s in l_lsit)
                {
                    await sw.WriteLineAsync(s);
                }
            }
        }
        protected static async void SaveFiles()
        {
            await ProcessXMlFile(SetUpURLList(500));

        }
        private static List<string> SetUpURLList(int No)
        {
            List<string> urls = new List<string>
            {
            };

            for (int i = 1; i <= No; i++)
                urls.Add("http://ifserver1:8073/api/exptemplate/templates");

            return urls;
        }

        static void WriteLinesToFile(List<string> l_lsit)
        {
            //int milliseconds = 2000;
            //Thread.Sleep(milliseconds);

            string guid = Guid.NewGuid().ToString();
            using (StreamWriter sw = new StreamWriter($"M:\\perform\\{guid}.xml"))
            {
                foreach (string s in l_lsit)
                {
                    sw.WriteLine(s);
                }
            }
        }
        private static async Task ProcessXMlFile(List<string> fileList)
        {
            //ServicePointManager.UseNagleAlgorithm = true;
            //ServicePointManager.Expect100Continue = true;
            //ServicePointManager.CheckCertificateRevocationList = true;
            //ServicePointManager.MaxServicePointIdleTime = 10000;
            //ServicePointManager.DefaultConnectionLimit = 1000;
            var bag = new ConcurrentBag<object>();
            var tasks = fileList.Select(async item =>
            {
                // some pre stuff
                await CallURLAsync(item);
                //bag.Add(response);
                // some post stuff
            });
            await Task.WhenAll(tasks);

            //    var CallingTasksQuery = Parallel.ForEach(fileList, (i) =>
            //{

            //});
            // from lines in fileList select CallURLAsync(lines);


            //Task[] CallingTasks = CallingTasksQuery.ToArray();

            //await Task.WhenAll(CallingTasks);
        }
        private static async Task CallURLAsync(string url)
        {
            //int milliseconds = 2000;
            //Thread.Sleep(milliseconds);
            //await ReadFile();
            //var content = new MemoryStream();
            //var webReq = (HttpWebRequest)WebRequest.Create(url);
            //using (WebResponse response = await webReq.GetResponseAsync())
            //{

            //}

            string str = ReadFile1();
            svcClient.getRateAsync(str);
            Console.WriteLine(count++);
            await WriteFile(new List<string> { "response" + count.ToString() });
        }

    }
}
