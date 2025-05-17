using Arahk.ClearPath.Wasm.Interfaces.ViewModel;

namespace Arahk.ClearPath.Wasm.ViewModels.Project;

public class ProjectListItemViewModel : IListItem
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; }
}