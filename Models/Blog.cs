using System.ComponentModel.DataAnnotations;

namespace MvcBlog.Models;

public class Blog
{
    public int Id { get; set; }
    public required string Title { get; set; }

    public required string Content { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreateDate { get; set; }

    [DataType(DataType.Date)]
    public DateTime UpdateDate { get; set; }
}