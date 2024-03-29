using GTR_OKR.Context;
using GTR_OKR.Interfaces;
using GTR_OKR.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//DbContext Config
builder.Services.AddDbContext<OkrDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//cors configuration
var mycors = "cors";
builder.Services.AddCors(options =>
{
    options.AddPolicy(mycors,
        policy =>
        {
            policy.WithOrigins("https://localhost:7142/").AllowAnyHeader().AllowAnyMethod();
        });
});
// Add services to the container.
builder.Services.AddTransient<IUserInfo, UserRepo>();
builder.Services.AddTransient<ITemplate, TemplateRepo>();
builder.Services.AddTransient<IProject, ProjectRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(mycors);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
