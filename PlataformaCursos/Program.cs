using Microsoft.EntityFrameworkCore;
using PlataformaCursos.Infrastructure.Data;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Modules.Modalities.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IModalityRepository, ModalityRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<CreateModalityService>();
builder.Services.AddScoped<UpdateModalityService>();
builder.Services.AddScoped<DeleteModalityService>();
builder.Services.AddScoped<GetAllModalitiesService>();
builder.Services.AddScoped<GetModalityService>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Postgres"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();