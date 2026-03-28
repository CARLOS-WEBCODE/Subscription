using Scalar.AspNetCore;
using Serilog;
using Subscription.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddRouting(map => map.LowercaseUrls = true);

builder.Services.AddEndpointsApiExplorer();  //Swagger
builder.Services.AddSwaggerGen();  //Swagger

//Injeção de dependências
builder.Services.AddInfrastructure(builder.Configuration);

//Configurar o Serilog
Log.Logger = new LoggerConfiguration().MinimumLevel
    .Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.Seq(builder.Configuration["Seq:Url"] ?? string.Empty)
    .CreateLogger();

//Habilitando o Serilog
builder.Host.UseSerilog();

var app = builder.Build();

app.UseSwagger();  //Swagger
app.UseSwaggerUI();  //Swagger

///Scalar
app.MapScalarApiReference(options =>
{
    options.WithTheme(ScalarTheme.BluePlanet);
});

app.MapOpenApi();
app.UseAuthorization();
app.MapControllers();
app.Run();