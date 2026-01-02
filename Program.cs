using Laboratoires.EF;
using Microsoft.EntityFrameworkCore;
using publications.Repositories;
using publications.Services.Remote;
using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDiscoveryClient(builder.Configuration);

//recuperer la chaine de connection
var sconn = builder.Configuration.GetConnectionString("myconn");


//ajouter service dbcontext
builder.Services.AddDbContext<ApplicationContext>(opt => opt.UseSqlServer(sconn));

// Add services to the container.

builder.Services.AddTransient(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
builder.Services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));

builder.Services.AddHttpClient<IChercheur, ChercheurService>();
builder.Services.AddTransient<IChercheur, ChercheurService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
