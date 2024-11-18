namespace Asp.NetCoreEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // MVC servislerinin eklenmesi
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // HTTP isteklerinin iþlenmesi için pipeline yapýlandýrmasý
            if (!app.Environment.IsDevelopment()) // Geliþtirme ortamýnda deðilse
            {
                app.UseExceptionHandler("/Home/Error");  // Hata durumlarýnda özel bir hata sayfasýna yönlendirme
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); // HTTP Strict Transport Security (HSTS) protokolünü etkinleþtirir
            }

            app.UseHttpsRedirection(); // HTTP isteklerini otomatik olarak HTTPS'e yönlendirir
            app.UseStaticFiles(); // wwwroot klasöründeki statik dosyalarýn kullanýlmasýný saðlar

            app.UseRouting(); // Routing yapýlandýrmasýný etkinleþtirir

            app.UseAuthorization(); // Yetkilendirme iþlemleri için middleware eklenir

            app.MapControllerRoute( // Varsayýlan routing yapýlandýrmasý
                name: "default", // Routing'in adý
                pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsayýlan olarak HomeController'ýn Index action'ý çaðrýlýr.

            app.Run(); // Uygulamayý çalýþtýrýr

            /*
            - builder: Uygulama oluþturulurken yapýlandýrmalarýn yapýldýðý nesne
            - builder.Services.AddControllersWithViews(): MVC mimarisinde controller ve view kullanýmýný aktif eder
            - app.Environment.IsDevelopment(): Geliþtirme ortamýnda olup olmadýðýný kontrol eder
            - app.UseHttpsRedirection(): Tüm HTTP isteklerini HTTPS'ye yönlendirir
            - app.UseStaticFiles(): wwwroot klasöründeki statik dosyalarý servis eder
            - app.UseRouting(): Gelen isteklerin doðru controller ve action'a yönlendirilmesini saðlar
            - app.MapControllerRoute(): Varsayýlan routing'i tanýmlar (ör. /Home/Index)
            - app.Run(): Uygulamayý baþlatýr ve gelen HTTP isteklerini dinler
            */
        }
    }
}
