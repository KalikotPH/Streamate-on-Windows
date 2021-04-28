using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Streamate
{
    public class Cron
    {
        static readonly HttpClient s_client = new HttpClient
        {
            MaxResponseContentBufferSize = 1_000_000
        };

        static IEnumerable<string> s_urlList = null;

        //static Task Main() => SumPageSizesAsync();

        public static Menu curForm;
        public static void Init(Menu form)
        {
            curForm = form;
            SumPageSizesAsync();
        }

        public static async Task SumPageSizesAsync()
        {
            s_urlList = curForm.getUrls;


            var stopwatch = Stopwatch.StartNew();

            IEnumerable<Task<int>> downloadTasksQuery =
                from url in s_urlList
                select ProcessUrlAsync(url, s_client);

            List<Task<int>> downloadTasks = downloadTasksQuery.ToList();

            int total = 0;
            while (downloadTasks.Any())
            {
                Task<int> finishedTask = await Task.WhenAny(downloadTasks);
                downloadTasks.Remove(finishedTask);
                total += await finishedTask;
            }

            stopwatch.Stop();

            //Console.WriteLine($"\nTotal bytes returned:  {total:#,#}");
            //Console.WriteLine($"Elapsed time:          {stopwatch.Elapsed}\n");

            //Console.WriteLine("Total bytes returned:  "+ curForm.getInterval);
            //await Task.Delay(curForm.getInterval);
            await Task.Delay(10000);
            SumPageSizesAsync();
        }

        static async Task<int> ProcessUrlAsync(string url, HttpClient client)
        {
            byte[] content = await client.GetByteArrayAsync(url);
            Console.WriteLine($"{url,-60} {content.Length,10:#,#}");

            return content.Length;
        }
    }
}
