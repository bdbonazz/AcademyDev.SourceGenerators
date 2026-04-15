namespace ConsoleApp.Classes.Abstract;
internal abstract class VersionInfoEntity : IVersionInfoEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
