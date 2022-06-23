namespace AkcelitaTest.Models;

public class SalesPerCityDTO
{
    public string? City { get; set; }
    public double MinOrderValue { get; set; }

    public double MaxOrderValue { get; set; }

    public double TotalOrderValue { get; set; }
}

public class OrdersPerUserDTO
{
    public long UserId { get; set; }
    public double Total { get; set; }
}

public class ProductsSoldDTO
{
    public long ProductId { get; set; }
    public Product? Product { get; set; }
    public int Total { get; set; }
}