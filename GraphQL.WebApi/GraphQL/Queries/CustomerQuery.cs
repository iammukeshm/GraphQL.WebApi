using GraphQL.Types;
using GraphQL.WebApi.Data;
using GraphQL.WebApi.GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.GraphQL.Queries
{
    public class CustomerQuery : ObjectGraphType
    {
        private readonly ApplicationDbContext _appContext;
        public CustomerQuery(ApplicationDbContext appContext)
        {
            this._appContext = appContext;
            Name = "Query";
            Field<ListGraphType<CustomerGraphType>>("customers", "Returns a list of Customer", resolve: context => _appContext.Customers.ToList());
            Field<CustomerGraphType>("customer", "Returns a Single Customer",
                new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Customer Id" }),
                    context => _appContext.Customers.Single(x => x.Id == context.Arguments["id"].GetPropertyValue<int>()));
        }
    }
}
