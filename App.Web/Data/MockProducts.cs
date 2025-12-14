using App.Web.Models;

namespace App.Web.Data
{
    public class MockProducts
    {
        private static readonly Lazy<MockProducts> _instance =
            new Lazy<MockProducts>(() => new MockProducts());

        private readonly List<Product> _products;
        private MockProducts()
        {
            _products = GenerateProducts(10); // создаём один раз
        }

        public static MockProducts Instance => _instance.Value;

        public List<Product> Products => _products;

        private List<Product> GenerateProducts(int count)
        {
            var products = new List<Product>();
            for (int i = 1; i <= count; i++)
            {
                products.Add(new Product
                {
                    Id = Guid.NewGuid(),
                    Name = $"Phone Model {i}",
                    Description = $"Description for Phone Model {i}"
                });
            }
            return products;
        }
    }
}
