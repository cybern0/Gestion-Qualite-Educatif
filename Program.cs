
using System.Data.SqlClient;
using QUALITE;
var builder = WebApplication.CreateBuilder(args);

// Ajoutez ceci AVANT builder.Build()
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy => policy
            .WithOrigins("http://localhost:44448")
            .AllowAnyHeader()
            .AllowAnyMethod());
});


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Ajoutez ceci AVANT app.UseAuthorization() ou app.MapControllers()
app.UseCors("AllowReactApp");


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");;

SqlConnection sql = Connection.GetConnection();
try
{
    sql.Open();
    Console.WriteLine("Connection Opened");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    sql.Close();
    Console.WriteLine("Connection Closed");
}



app.Run();
