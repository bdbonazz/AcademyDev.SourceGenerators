using ConsoleApp.Classes.SourceGenerated;
using ConsoleApp.Specification.Utils;
using System.Linq.Expressions;

namespace ConsoleApp.Specification;

internal class IdSpecification(long id) : LinqSpecification<Entity1>
{
    public override Expression<Func<Entity1, bool>> AsExpression() => x => x.Id == id;
}
