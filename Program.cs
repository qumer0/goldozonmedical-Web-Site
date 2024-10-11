var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

// Add Session service
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Oturumun zaman aşımı süresi (örnek: 30 dakika)
    options.Cookie.HttpOnly = true; // Oturum çerezi tarayıcı tarafından yalnızca HTTP istekleriyle kullanılabilir
    options.Cookie.IsEssential = true; // Oturum çerezi, GDPR gibi düzenlemeler için gerekli olarak işaretlenir
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Use session middleware
app.UseSession(); // Session middleware'i buraya ekleyin

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
