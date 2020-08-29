using GraphQL.Types;
using GraphQL.WebApi.GraphQL.Queries;

namespace GraphQL.WebApi.GraphQL
{
    public class DemoSchema : Schema
{
    public DemoSchema(IDependencyResolver resolver) : base(resolver)
    {
        Query = resolver.Resolve<CustomerQuery>();
    }
}
}
