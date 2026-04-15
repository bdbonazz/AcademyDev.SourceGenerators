namespace ConsoleApp.Classes;

internal interface IBaseEntity
{
    long Id { get; set; }
    Guid Guid { get; set; }
}
