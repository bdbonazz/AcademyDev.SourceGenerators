using System.Linq.Expressions;

namespace ConsoleApp.Specification.Utils;

public interface ISpecification<T>
{
    bool IsSatisfiedBy(T candidate);
    ISpecification<T> And(ISpecification<T> other);
    ISpecification<T> AndNot(ISpecification<T> other);
    ISpecification<T> Or(ISpecification<T> other);
    ISpecification<T> OrNot(ISpecification<T> other);
    ISpecification<T> Not();
}

public abstract class LinqSpecification<T> : CompositeSpecification<T>
{
    public abstract Expression<Func<T, bool>> AsExpression();
    public override bool IsSatisfiedBy(T candidate) => AsExpression().Compile()(candidate);
}

public abstract class CompositeSpecification<T> : ISpecification<T>
{
    public abstract bool IsSatisfiedBy(T candidate);
    public ISpecification<T> And(ISpecification<T> other) => new AndSpecification<T>(this, other);
    public ISpecification<T> AndNot(ISpecification<T> other) => new AndNotSpecification<T>(this, other);
    public ISpecification<T> Or(ISpecification<T> other) => new OrSpecification<T>(this, other);
    public ISpecification<T> OrNot(ISpecification<T> other) => new OrNotSpecification<T>(this, other);
    public ISpecification<T> Not() => new NotSpecification<T>(this);
}

public class AndSpecification<T>(ISpecification<T> left, ISpecification<T> right) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => left.IsSatisfiedBy(candidate) && right.IsSatisfiedBy(candidate);
}

public class AndNotSpecification<T>(ISpecification<T> left, ISpecification<T> right) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => left.IsSatisfiedBy(candidate) && !right.IsSatisfiedBy(candidate);
}

public class OrSpecification<T>(ISpecification<T> left, ISpecification<T> right) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => left.IsSatisfiedBy(candidate) || right.IsSatisfiedBy(candidate);
}
public class OrNotSpecification<T>(ISpecification<T> left, ISpecification<T> right) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => left.IsSatisfiedBy(candidate) || !right.IsSatisfiedBy(candidate);
}

public class NotSpecification<T>(ISpecification<T> other) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => !other.IsSatisfiedBy(candidate);
}
