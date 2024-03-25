using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProductS());
            }
        }

        private static IEnumerable<Product> GetMyProductS()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "IPhone X",
                    Category = "Smart Phone",
                    Description = "This is description of IPhone X",
                    Image = "product-1.png",
                    Price = 950.00M
                },
                new Product()
                {
                    Name = "Samsung Galaxy S10",
                    Category = "Smart Phone",
                    Description = "This is description of Samsung Galaxy S10",
                    Image = "product-2.png",
                    Price = 840.00M
                },
                new Product()
                {
                    Name = "Huawei P30 Pro",
                    Category = "Smart Phone",
                    Description = "This is description of Huawei P30 Pro",
                    Image = "product-3.png",
                    Price = 750.00M
                }
            };
        }
    }
}
