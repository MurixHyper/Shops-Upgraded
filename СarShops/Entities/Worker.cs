using System;
using System.Collections.Generic;
using System.Text;

namespace СarShops.Entities
{
    public class Worker: BaseEntity
    {
        public string Surname { get; set; }
        public double Salary { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public Position Position { get; set; }        
        public Education Education { get; set; }
        public string Code { get; set; } 
        public int Age { get; set; }
        public void NewCode()
        {
            var rand = new Random();
            Code = rand.Next(1, 9).ToString();
            for (int i = 0; i < 9; i++)
                Code += rand.Next(0, 9).ToString();
        }
    }

    public enum Position { Director, HR, OlderSeller, Seller, Security}
    public enum Education { None, Technic, Liberal, Financial, Legal}
}