using System.ComponentModel.DataAnnotations;

namespace library_api.Models;

public class Publisher
{
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public required string Name { get; set; }

    // Navigation property: A publisher can have many books
    public ICollection<Book> Books { get; set; } = [];

    // --- Soft Delete Fields ---
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
}