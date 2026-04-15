namespace ConsoleApp.Classes;
internal interface IVersionInfoEntity
{
    DateTime CreatedDate { get; set; }
    DateTime UpdatedDate { get; set; }
    DateTime? DeletedDate { get; set; }
}
