using Polyclinic_Schedule.DB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*
builder.Services.AddControllers().AddJsonOptions(
    s => s.JsonSerializerOptions.ReferenceHandler =
     System.Text.Json.Serialization.
     ReferenceHandler.Preserve
    );*/
builder.Services.AddControllers();
builder.Services.AddDbContext<User30Context>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
