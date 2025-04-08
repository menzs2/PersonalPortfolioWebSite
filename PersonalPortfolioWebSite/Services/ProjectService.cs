namespace PersonalPortfolioWebSite;
using PersonalPortfolioWebSite.Models;

public class ProjectService
{
    private readonly List<ProjectModel> _projects = new List<ProjectModel>
    {
        new ProjectModel
            {
                Name = "Project 1",
                Description = "Description of Project 1",
                Technologies = new List<SkillModel>{
                    new SkillModel { Name = "C#", Description = "C# programming language", Level = 9, YearsOfExperience = 11 },
                    new SkillModel { Name = "ASP.NET Core", Description = "Web framework for .NET", Level = 8, YearsOfExperience = 2 },
                    new SkillModel { Name = "Entity Framework Core", Description = "ORM for .NET",  Level = 7, YearsOfExperience = 2 },
                    new SkillModel { Name = "SQL Server", Description = "Relational database management system", Level = 8, YearsOfExperience = 2 }
                }
            },
        new ProjectModel
            {
                Name = "Project 2",
                Description = "Description of Project 2",
                Technologies = new List<SkillModel>{
                    new SkillModel { Name = "JavaScript", Description = "JavaScript programming language", Level = 4, YearsOfExperience = 1 },
                    new SkillModel { Name = "React", Description = "JavaScript library for building user interfaces" },
                    new SkillModel { Name = "Node.js", Description = "JavaScript runtime built on Chrome's V8 JavaScript engine" }
                }
            },
        new ProjectModel
            {
                Name = "Project 3",
                Description = "Description of Project 3",
                Technologies = new List<SkillModel>{
                    new SkillModel { Name = "Python", Description = "Python programming language" },
                    new SkillModel { Name = "Django", Description = "Web framework for Python" },
                    new SkillModel  { Name = "PostgreSQL", Description = "Relational database management system" }

                }
            }
    };

    public List<ProjectModel> GetProjects()
    {
        return _projects;
    }
    public ProjectModel GetProject(string name)
    {
        return _projects.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ?? new ProjectModel(){Name = "Project not found", Description = "No description available", Technologies = new List<SkillModel>() };
    }
}
