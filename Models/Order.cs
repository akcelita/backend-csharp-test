using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkcelitaTest.Models;

public class Order
{
    [Key]
    public long Id { get; set; }

    public List<Product>? Products { get; set; }
    public double Total { get; set; }

    [ForeignKey("AddresId")]
    public long AddressId { get; set; }

    public Address? Address { get; set; }
}