using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Ocelot yap�land�rma dosyas�n� belirtiyoruz
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Ocelot servisini ekliyoruz
builder.Services.AddOcelot(builder.Configuration);

// Di�er servisler
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

await app.UseOcelot();

app.MapControllers();

app.Run();
