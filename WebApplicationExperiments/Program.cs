using Microsoft.Extensions.Primitives;
using WebApplicationExperiments.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<GlobalSampleActionFilter>();
});

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();
app.UseDeveloperExceptionPage();
// Configure the HTTP request pipeline.

app.UseHsts();

// Here the application is hosted as follows
// For HTTP it is hosted in http://localhost:5278
// For HTTPS it is hosted in https://localhost:7144
// if the app.UseHttpsRedirection(); is enabled and you made request to http://localhost:5278 it will redirect to https://localhost:7144
// if the app.UseHttpsRedirection(); is disabled and you made request to http://localhost:5278 it will not redirect to https://localhost:7144 and serve the request in http://localhost:5278
app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthorization();

app.MapControllers();

app.Use(async (context, next) =>
{
    Console.WriteLine("Hello from the middleware 1");
    context.Response.Headers.Add("Testing", "test 1");

    // Call the next middleware in the pipeline
    // The await next(context); line is where the next middleware in the pipeline is invoked, and this is typically where the response starts.
    // Any middleware that writes to the response body or starts the response should be the last middleware in the pipeline.
    await next();

    // After calling next, the response has likely started and you can't modify headers or status code
    // So, this line should be removed or placed before calling next
    // context.Response.Headers.Add("Testing2", "test 2");
    Console.WriteLine("Bye from the middleware 1");
});

app.Use(async (context, next) =>
{
    StringValues temp;
    context.Response.Headers.TryGetValue("Testing", out temp);
    Console.WriteLine($"Hello from the middleware 2 {temp}");
    context.Response.Headers.Add("Testing2", "test 2");

    await next();

    Console.WriteLine("Bye from the middleware 2");
});

app.Run();

// Order of Middleware in most project templates is as follows
// 1. app.UseDeveloperExceptionPage(); [Local development] or app.UseExceptionHandler("/Home/Error"); [Production]
// 2. app.UseHsts();
// 3. app.UseHttpsRedirection();
// 4. app.UseStaticFiles();
// 5. app.UseRouting();
// 6. app.UseCors();
// 7. app.UseAuthentication();
// 8. app.UseAuthorization();
// 9. custom miidlewares 1 to n
// 10. app.UseEndpoints()
