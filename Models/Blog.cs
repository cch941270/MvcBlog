using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBlog.Models;

public class Blog
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public required string Title { get; set; }

    [StringLength(300, MinimumLength = 15)]
    [Required]
    public required string Content { get; set; }

    [Display(Name = "Create Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime CreateDate { get; set; } = DateTime.Now;

    [Display(Name = "Update Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime? UpdateDate { get; set; }

    public string? Location {  get; set; }
}