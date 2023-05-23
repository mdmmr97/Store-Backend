using Microsoft.EntityFrameworkCore;
using Store_Backend.Application.Mappings;
using Store_Backend.Application.Services;
using Store_Backend.Domain.Persistence;
using Store_Backend.Infraestructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddAutoMapper(typeof(CategoryMapperProfile));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (builder.Environment.IsDevelopment()) {
    builder.Services.AddDbContext<StoreContext>(options =>
        options.UseInMemoryDatabase(connectionString)
        );
}

var app = builder.Build();

if (builder.Environment.IsDevelopment()) {
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<StoreContext>();
    DevelopmentDataLoader dataLoader = new(context);
    dataLoader.LoadData();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
