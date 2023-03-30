using Graphql_project.Model;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HotChocolate;
using Graphql_project;

namespace Graphqlproject.QueryType
{
    public class Query
    {
        PlanItDBContext context;
        Query(PlanItDBContext context) {
            this.context = context;
        }
        public Task<List<Cake>> AllCakes( )
        {
            return context.Cake.ToListAsync();
        }

        /*public Cake AllCake() => new Cake { Id = 1 ,name = "manvitha"};*/
    }
}
