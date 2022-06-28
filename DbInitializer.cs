using AkcelitaTest.Models;

namespace AkcelitaTest
{
    public class DbInitializer
    {
        private DatabaseContext _context;

        public DbInitializer(DatabaseContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Users.Count() > 0)
            {
                return;
            }

            var addresses = new List<Address>
        {
            new Address() { LineOne = "14200 Mulberry Street", Country="USA", City = "New York" },
            new Address() { LineOne = "200 West Street", Country="USA", City = "New York" },
            new Address() { LineOne = "100 North Avenue", Country="USA", City = "Atlanta" },
        };

            _context.Addresses.AddRange(addresses);
            _context.SaveChanges();

            var users = new List<User>
        {
            new User() { Email = "one@example.com", Name = "John Bryer" },
            new User() { Email = "two@example.com", Name = "Miguel Depth" },
            new User() { Email = "three@example.com", Name = "Thor Bein" },
            new User() { Email = "four@example.com", Name = "Mary Hopkins" },
            new User() { Email = "five@example.com", Name = "Julie Smith" },
        };

            _context.Users.AddRange(users);
            _context.SaveChanges();

            var products = new List<Product>
        {
            new Product() { Name="Coca-Cola 2 Liters", Price = 1.99 },
            new Product() { Name="Sprite 2 Liters", Price = 1.89 },
            new Product() { Name="Lunchables", Price = 4.49 },
            new Product() { Name="Apple Juice", Price = 0.99 },
            new Product() { Name="Pantene Pro-V", Price = 7.99 },
        };

            _context.Products.AddRange(products);
            _context.SaveChanges();

            var orders = new List<Order>
        {
            new Order {
                AddressId = addresses[0].Id,
                Products = new List<Product> {
                    products[0],
                    products[2],
                    products[1]
                },
                Total = 8.37,
                User = users[1]
            },
            new Order {
                AddressId = addresses[1].Id,
                Products = new List<Product> {
                    products[0],
                    products[2],
                    products[1]
                },
                Total = 8.37,
                User = users[0]
            },
            new Order {
                AddressId = addresses[1].Id,
                Products = new List<Product> {
                    products[0]
                },
                Total = 1.99,
                User = users[0]
            },
            new Order {
                AddressId = addresses[2].Id,
                Products = new List<Product> {
                    products[4]
                },
                Total = 7.99,
                User = users[0]
            },
            new Order {
                AddressId = addresses[1].Id,
                Products = new List<Product> {
                    products[4],
                    products[3],
                },
                Total = 8.98,
                User = users[1]
            }
        };
            _context.Orders.AddRange(orders);
            _context.SaveChanges();
        }
    }
}