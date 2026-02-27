// Peter Do
// Student ID: 9086580

using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// TODO: Register DbContext here (MoviesDbContext)
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});


// TODO: Register Repository here (IRepository → MovieRepository)
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
