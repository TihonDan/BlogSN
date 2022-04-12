using Microsoft.AspNetCore.Mvc;

namespace BlogSN.Models;

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    
    public User? User { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public ICollection<Category>? Categories { get; set; }

}