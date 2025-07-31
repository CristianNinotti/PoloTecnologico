using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerWithJwt();

//Servicios implementados
#region
builder.Services.AddServices();
#endregion

//Token JWT
builder.Services.AddJwtAuthentication(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS - Denegaciones
app.UseCors(
    options => options
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowAnyOrigin()
    );

app.UseHttpsRedirection();


//Para el token
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
