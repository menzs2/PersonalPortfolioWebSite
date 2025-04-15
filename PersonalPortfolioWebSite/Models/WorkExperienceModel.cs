namespace PersonalPortfolioWebSite.Models;

public class WorkExperienceModel
{
    public string CompanyName { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<SkillModel> Technologies { get; set; } = new List<SkillModel>();
    public string Location { get; set; } = string.Empty;
}
