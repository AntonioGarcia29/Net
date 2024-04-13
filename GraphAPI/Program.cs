using GraphAPI.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<SerieQuery>();

var app = builder.Build();


app.MapGraphQL();

app.Run();

