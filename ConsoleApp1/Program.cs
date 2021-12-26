using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        /*
        record API_Input(string label, string file_numbers);

        static void api()
        {
            var api_input = new API_Input("0", "0,32,64");
            var json = JsonConvert.SerializeObject(api_input);

            var url = "https://charrecognitionfunctions20211201.azurewebsites.net/api/StandardizeImages?code=mXdAHKAdsLY7gbAtr62bUCaamWE8FG9BiVJjxBM3LN0a7lByuogMfw==";

            var client = new HttpClient();
            var response = client.PostAsync(url,
                new StringContent(json, Encoding.UTF8, "application/json"));

            response.Wait();

            string result = response.Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        */





        public static void Main()
        {
            string s1 = "A";
            string s2 = "A";

            if (s1 == s2)
                Console.WriteLine("s1 == s2");

            if (s1 != s2)
                Console.WriteLine("s1 != s2");

            if (String.Compare(s1, s2) == 0)
                Console.WriteLine("String.Compare(s1, s2) == 0");

        }



    }



}
