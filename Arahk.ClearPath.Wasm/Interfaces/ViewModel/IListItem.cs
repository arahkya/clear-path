namespace Arahk.ClearPath.Wasm.Interfaces.ViewModel;

public interface IListItem
{
    Guid Id { get; set; }
    string Name { get; set; }
    DateTime CreatedOn { get; set; }
}