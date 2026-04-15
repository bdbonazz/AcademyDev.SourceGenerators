namespace ConsoleApp.Classes.Abstract;

internal abstract class BaseEntity : IBaseEntity
{
    public long Id { get; set; }
    public Guid Guid { get; set; }
}
