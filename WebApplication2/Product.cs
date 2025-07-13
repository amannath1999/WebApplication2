using System;
using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(255)]
    public string Description { get; set; }

    [Required]
    [Range(0, 9999999999999999.99)]
    public decimal Price { get; set; }

    public DateTime CreatedDate { get; set; }
}
