using System.Collections.Generic;

namespace PersonalPortfolioWebSite.Models;

public class ProjectModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ProjectType { get; set; } = string.Empty;
    public List<SkillModel> Technologies { get; set; } = new List<SkillModel>();
}
