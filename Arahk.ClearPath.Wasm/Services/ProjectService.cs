using Arahk.ClearPath.Wasm.Interfaces.Service;
using Arahk.ClearPath.Wasm.ViewModels.Project;

namespace Arahk.ClearPath.Wasm.Services;

public class ProjectService : IProjectService
{
    public Task<List<ProjectListItemViewModel>> GetProjects()
    {
        var projects = new List<ProjectListItemViewModel>
        {
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 1",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 2",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 3",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 4",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 5",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 6",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 7",
                Created = DateTime.UtcNow
            },
            new ProjectListItemViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Project 8",
                Created = DateTime.UtcNow
            },
        };

        return Task.FromResult(projects);
    }
}