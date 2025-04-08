using System.Collections.Generic;

namespace PersonalPortfolioWebSite;

public class Project
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Skill> Technologies { get; set; } = new List<Skill>();
}
