using Supermarket.API.Domain.Models;
using System.Collections.Generic;

namespace Supermarket.API.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public IList<Product> Products {get; set;}
    }
}