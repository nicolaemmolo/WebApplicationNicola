//crea app per vendere cellulari
//crea login
//3 coppie user e password
//con authentication filter vedere se è autenticato o meno
//visualizzare elenco (lato client o MVC) e mostrare elenco in pagina web
//pulsante COMPRA 
//compra modello e in automatico dopo che compri fa il log out
//sistema il css in modo che sia fruibile

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
