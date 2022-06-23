using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkcelitaTest;

public class User
{
    [Key]
    public long Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
