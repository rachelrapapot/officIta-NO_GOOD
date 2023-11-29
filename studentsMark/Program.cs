using studentsMark;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICompaniesServies, CompaniesServies>();
builder.Services.AddScoped<ICompaniesRepositories, HiTechCompaniesRepositories_>();
builder.Services.AddScoped<IStudentServies, IStudentServies>();
builder.Services.AddScoped<IStudntRepositories, StudentRepositories>();
builder.Services.AddScoped<ITeacherServies, TeacherServies>();
builder.Services.AddScoped<ITeacherRepositories, TeacherRepositories>();
builder.Services.AddSingleton<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();