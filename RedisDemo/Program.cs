using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            IDatabase db = redis.GetDatabase();
            string clientId = db.StringGet("ClientId");
            string clientSecrete = db.StringGet("ClientScrete");
            Console.WriteLine(string.Format("ClientSecrete = {0}     ClientId = {1}", clientSecrete, clientId));
            Console.ReadLine();
        }
    }
}
