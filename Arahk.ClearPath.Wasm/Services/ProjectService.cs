using Arahk.ClearPath.Wasm.Interfaces.Service;
using Arahk.ClearPath.Wasm.ViewModels.Project;

namespace Arahk.ClearPath.Wasm.Services;

public class ProjectService : IProjectService
{
    public Task<List<ProjectListItemViewModel>> GetProjectsAsync()
    {
        var projects = new List<ProjectListItemViewModel>();
        for (var i = 1; i <= 100; i++)
        {
            projects.Add(new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = $"Project {i}",
                CreatedOn = DateTime.UtcNow
            });
        }
        return Task.FromResult(projects);
    }
}

