
using ConsoleApp.Classes.SourceGenerated;
using ConsoleApp.Specification;
using System.Text.RegularExpressions;

var myEntity = new Entity1()
{
    Id = 123,
};

Entity1Repository repository = new();
repository.FirstOrDefault(new IdSpecification(myEntity.Id));