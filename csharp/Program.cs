using System;
using Newtonsoft.Json;

namespace csharp {
    public class Account {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }

    class Program
    {
        static void Main (string[] args) {
            Account account = new Account {
                Name = "KK",
                Email = "kk@blood.com",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc)
            };

            string jsonStr = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(jsonStr);
        }
    }
}
