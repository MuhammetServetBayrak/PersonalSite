using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PersonalSiteContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PersonalSiteDb")));

// DAL
builder.Services.AddScoped<IBlogPostDal, BlogPostRepository>();
builder.Services.AddScoped<IBlogCategoryDal, BlogCategoryRepository>();
builder.Services.AddScoped<IProjectDal, ProjectRepository>();
builder.Services.AddScoped<IExperienceDal, ExperienceRepository>();
builder.Services.AddScoped<IEducationDal, EducationRepository>();
builder.Services.AddScoped<ISkillDal, SkillRepository>();

// BL
builder.Services.AddScoped<IBlogPostService, BlogPostManager>();
builder.Services.AddScoped<IBlogCategoryService, BlogCategoryManager>();
builder.Services.AddScoped<IProjectService, ProjectManager>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();
builder.Services.AddScoped<IEducationService, EducationManager>();
builder.Services.AddScoped<ISkillService, SkillManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
