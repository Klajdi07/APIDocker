var builder = WebApplication.CreateBuilder(args);

//Add services to container 
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});
var app = builder.Build();

// Configure the HTPP request pipeline
app.MapCarter();


app.Run();
