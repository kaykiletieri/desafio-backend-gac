using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
    s.SwaggerDoc("v1", new()
    {
        Title = "Desafio Backend GAC",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "Kayki Letieri",
            Email = "kaykiletieri37@gmail.com"
        }
    }));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
