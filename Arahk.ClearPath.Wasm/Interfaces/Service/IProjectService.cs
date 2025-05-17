using Arahk.ClearPath.Wasm.ViewModels.Project;

namespace Arahk.ClearPath.Wasm.Interfaces.Service;

public interface IProjectService
{
    Task<List<ProjectListItemViewModel>> GetProjectsAsync();
}