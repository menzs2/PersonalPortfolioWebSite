namespace PersonalPortfolioWebSite.Models;

using System.ComponentModel.DataAnnotations;

public class SkillModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;

    [Range(1, 10, ErrorMessage = "Level must be between 1 and 10.")]
    public int Level { get; set; } = 1;

    public string Category { get; set; } = string.Empty;
    [Range(0, 30, ErrorMessage = "Years of experience must be between 0 and 30.")]
    public int YearsOfExperience { get; set; } = 1;
}
