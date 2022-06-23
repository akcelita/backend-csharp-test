using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkcelitaTest.Models;

public class Product
{
    [Key]
    public long Id { get; set; }

    public string? Name { get; set; }
    public double Price { get; set; }
}