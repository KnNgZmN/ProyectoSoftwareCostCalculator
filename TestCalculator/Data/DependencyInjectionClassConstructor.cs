using TUnit.Core.Interfaces;

namespace TestCalculator;

public class DependencyInjectionClassConstructor : IClassConstructor
{
    public Task<object> Create(Type type, ClassConstructorMetadata classConstructorMetadata)
    {       

        throw new NotImplementedException();
    }
}
