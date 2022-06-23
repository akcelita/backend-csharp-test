using System.ComponentModel.DataAnnotations;

namespace AkcelitaTest.Models;

public class Address
{
    [Key]
    public long Id { get; set; }
    public string? LineOne { get; set; }
    public string? LineTwo { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

}