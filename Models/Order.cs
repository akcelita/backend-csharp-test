using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkcelitaTest.Models;

public class Order
{
    [Key]
    public long Id { get; set; }

    public ICollection<Product>? Products { get; set; }
    public double Total { get; set; }

    [ForeignKey("AddresId")]
    public long AddressId { get; set; }

    public Address? Address { get; set; }

    [ForeignKey("UserId")]
    public long UserId { get; set; }
    public User? User { get; set; }
}

public class NewOrderDTO
{
    public long UserId { get; set; }
    public List<long> ProductIds { get; set; }

    public Address Address { get; set; }
}