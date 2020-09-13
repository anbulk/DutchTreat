using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _dutchContext;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DutchSeeder(DutchContext dutchContext,IHostingEnvironment hostingEnvironment)
        {
            _dutchContext = dutchContext;
            _hostingEnvironment = hostingEnvironment;
        }

        //this can be used to seed lookup data
        public void Seed()
        {
            _dutchContext.Database.EnsureCreated();
            var filePath = Path.Combine(_hostingEnvironment.ContentRootPath + @"\Data\art.json");

            if(!_dutchContext.Products.Any())
            {
                var json = File.ReadAllText(filePath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _dutchContext.Products.AddRange(products);

                var order = _dutchContext.Orders.Where(o => o.Id == 2).FirstOrDefault();

                if (order != null)
                {
                    order.Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            Product = products.First(),
                            Quantity = 1,
                            UnitPrice = products.First().Price
                        }

                    };
                }

                _dutchContext.SaveChanges();

               
            }
        }
    }
}
