using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    // when an object is intantiated if that objec instantiates the IBreakfast Service in the constructor then use BreakfastService object as the implementation of this interface.
    // AddSingleton ; AddScoped ; AddTransient
    builder.Services.AddScoped<IBreakfastService, breakfastService>(); 
}


var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}