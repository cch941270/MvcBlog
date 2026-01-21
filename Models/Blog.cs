using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBlog.Models;

public class Blog
{
    public int Id { get; set; }
    public required string Title { get; set; }

    public required string Content { get; set; }

    [Display(Name = "Create Date")]
    [DataType(DataType.Date)]
    public DateTime CreateDate { get; set; }

    [Display(Name = "Update Date")]
    [DataType(DataType.Date)]
    public DateTime UpdateDate { get; set; }
}