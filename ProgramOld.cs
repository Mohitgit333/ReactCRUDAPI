//using Microsoft.EntityFrameworkCore;
//using React_CRUD_WebAPI.Data;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(p =>
//    {
//        var front_end = builder.Configuration.GetValue<string>("frontend_url");
//        p.WithOrigins(front_end).AllowAnyMethod().AllowAnyHeader();
//    });
//});
//// Add services to the container.
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddControllers();

//var app = builder.Build();


//// Configure the HTTP request pipeline.

//app.UseCors();
//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
