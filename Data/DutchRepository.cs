using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext dutchContext;

        public DutchRepository(DutchContext dutchContext)
        {
            this.dutchContext = dutchContext;
        }

        public List<Product> GetAllProducts()
        {
            return dutchContext.Products.ToList();

        }

        public List<Product> GetAllProductsByCategory(string category)
        {
            return dutchContext.Products.Where(p => p.Category.Equals(category))
                .ToList();

        }

        public bool SaveAll()
        {
            return dutchContext.SaveChanges() > 0;
        }
    }
}
