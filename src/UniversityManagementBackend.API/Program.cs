using UniversityManagementBackend.API.Dependency;
using UniversityManagementBackend.BLL.MappingProfile;
using UniversityManagementBackend.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ServiceInjectDependency();
builder.Services.RegisterObjectInjectDependency();
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddAutoMapper(typeof(MappingProfiles));

var app = builder.Build();
app.PerformDbMigration();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();




app.UseAuthorization();

app.MapControllers();

app.Run();