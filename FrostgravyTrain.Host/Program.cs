var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

List<int> storedUserIds = new List<int>(){1, 2, 3};

/*
 * Retrieves a list of all warbands assigned to the corresponding user_id
 */
app.MapGet("/api/{userId:int}/warbands", (int userId) =>
    {
        if (storedUserIds.Contains(userId))
        {
            return Results.Ok();
        }
        return Results.NotFound();
    });

app.Run();