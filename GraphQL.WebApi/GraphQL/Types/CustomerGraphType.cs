using GraphQL.Types;
using GraphQL.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.GraphQL.Types
{
    class CustomerGraphType : ObjectGraphType<Customer>
    {
        public CustomerGraphType()
        {
            Name = "Customer";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Customer Id");
            Field(x => x.FirstName).Description("Customer's First Name");
            Field(x => x.LastName).Description("Customer's Last Name");
            Field(x => x.Contact).Description("Customer's Contact");
            Field(x => x.Email).Description("Customer's Email");
        }
    }
}
