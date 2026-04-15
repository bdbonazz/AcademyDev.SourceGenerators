using ConsoleApp.Classes.SourceGenerated;
using ConsoleApp.Specification.Utils;
using AttributeGenerator;

namespace ConsoleApp.Specification;

[EnhancedRepository]
internal partial class Entity1Repository : IGenericRepository<Entity1, LinqSpecification<Entity1>>
{
    private readonly IQueryable<Entity1> Entities = new List<Entity1>().AsQueryable();

    private IQueryable<Entity1> GetQueryable(LinqSpecification<Entity1> specification)
    {
        return Entities.Where(specification.AsExpression());
    }
}
