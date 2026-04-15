using ConsoleApp.Classes.SourceGenerated;
using ConsoleApp.Specification.Utils;
using System.Linq.Expressions;

namespace ConsoleApp.Specification;

internal class GuidSpecification(Guid guid) : LinqSpecification<Entity1>
{
    public override Expression<Func<Entity1, bool>> AsExpression() => x => x.Guid == guid;
}
