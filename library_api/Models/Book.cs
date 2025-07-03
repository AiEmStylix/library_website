using System.ComponentModel.DataAnnotations;

namespace library_api.Models;

public class Book
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Title { get; set; } = string.Empty;
    
    [MaxLength(20)]
    public string? Isbn { get; set; }
    public DateTime PublishedDate { get; set; }
    
    // --- Relationships ---
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;

    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; } = null!;

    // --- Soft Delete Fields ---
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
    
}