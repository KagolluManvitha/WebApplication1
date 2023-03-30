using Graphql_project;

//using Graphql_project.QueryType.Query;
using Microsoft.Azure.Management.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PlanItDBContext>();

builder.Services
           .AddGraphQLServer()
    //.AddQueryType<Query> ();
    .AddQueryType<Query>();
/* public void ConfigureService(IServiceCollection services)
{

}*/

var context = new PlanItDBContext(builder.Configuration);
context.Database.EnsureCreated();
context.SaveChanges();

/*builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();*/

var app = builder.Build();

/*builder.Services.AddDbContext<PlanItDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

});*/


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseRouting();
/*app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});*/
app.MapControllers();
app.MapGraphQL();

app.Run();
