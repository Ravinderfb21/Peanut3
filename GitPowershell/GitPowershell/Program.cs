
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitPowershell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Download();
           
            Console.ReadLine();
        }
        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStreamAsync("https://www.hollisterco.com/shop/ca/br/0");
            Console.WriteLine(data);

            //to do : store each line of the webpage into an entry in a list
            //List myList = new  List() also see assignment1 for futher help.
        }

        class Network
        {
            static public Task Download() {
                return Task.Run(() =>Thread.Sleep(3000));
            }
        }
       
           
        }

    }

    

