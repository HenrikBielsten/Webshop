using System;
namespace WebApp.Project.Core.Models
{
    public class CheckoutModel
    {
        public string CartId { get; set; }

        public int id { get; set; }

        public int price { get; set; }

        public string adress { get; set; }

        public string email { get; set; }

        public string name { get; set; }
    }
}
