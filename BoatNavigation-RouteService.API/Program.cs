var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(options =>
{
    var basePath = AppContext.BaseDirectory;
    var xmlPath = Path.Combine(basePath, "RouteApi.xml");
    options.IncludeXmlComments(xmlPath);

    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "API маршрутов лодки",
        Description = "API для упарвления маршрутами лодки",

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger()
    .UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });

app.UseAuthorization();

app.MapControllers();

app.Run();
