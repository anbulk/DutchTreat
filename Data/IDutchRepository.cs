using DutchTreat.Data.Entities;
using System.Collections.Generic;

namespace DutchTreat.Data
{
    public interface IDutchRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetAllProductsByCategory(string category);
        bool SaveAll();
    }
}