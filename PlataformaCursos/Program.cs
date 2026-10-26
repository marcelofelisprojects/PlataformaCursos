using Microsoft.EntityFrameworkCore;
using PlataformaCursos.Infrastructure.Data;
using PlataformaCursos.Modules.Categories.Repositories;
using PlataformaCursos.Modules.Categories.Services;
using PlataformaCursos.Modules.Courses.Repositories;
using PlataformaCursos.Modules.Courses.Services;
using PlataformaCursos.Modules.Modalities.Repositories;
using PlataformaCursos.Modules.Modalities.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("FrontendLocal", policy =>
    {
        // CORRIGIDO: Adicionado o IP exato da origem (.45) e sem barra no final
        policy.WithOrigins("http://3.137.210.45", "http://3.137.210.45:80")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


builder.Services.AddScoped<IModalityRepository, ModalityRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<CreateModalityService>();
builder.Services.AddScoped<UpdateModalityService>();
builder.Services.AddScoped<GetAllModalitiesService>();
builder.Services.AddScoped<GetModalityService>();
builder.Services.AddScoped<DeleteModalityService>();

builder.Services.AddScoped<CreateCategoryService>();
builder.Services.AddScoped<UpdateCategoryService>();
builder.Services.AddScoped<GetAllCategoriesService>();
builder.Services.AddScoped<GetCategoryService>();
builder.Services.AddScoped<DeleteCategoryService>();


builder.Services.AddScoped<CreateCourseService>();
builder.Services.AddScoped<UpdateCourseService>();
builder.Services.AddScoped<GetCourseService>();
builder.Services.AddScoped<GetAllCoursesService>();
builder.Services.AddScoped<DeleteCourseService>();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Postgres"));
});

var app = builder.Build();

app.UseCors("FrontendLocal");



//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();
app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();


app.Run();