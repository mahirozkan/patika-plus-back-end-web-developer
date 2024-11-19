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

            // HTTP isteklerinin işlenmesi için pipeline yapılandırması
            if (!app.Environment.IsDevelopment()) // Geliştirme ortamında değilse
            {
                app.UseExceptionHandler("/Home/Error");  // Hata durumlarında özel bir hata sayfasına yönlendirme
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); // HTTP Strict Transport Security (HSTS) protokolünü etkinleştirir
            }

            app.UseHttpsRedirection(); // HTTP isteklerini otomatik olarak HTTPS'e yönlendirir
            app.UseStaticFiles(); // wwwroot klasöründeki statik dosyaların kullanılmasını sağlar

            app.UseRouting(); // Routing yapılandırmasını etkinleştirir

            app.UseAuthorization(); // Yetkilendirme işlemleri için middleware eklenir

            app.MapControllerRoute( // Varsayılan routing yapılandırması
                name: "default", // Routing'in adı
                pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsayılan olarak HomeController'ın Index action'ı çağrılır.

            app.Run(); // Uygulamayı çalıştırır

/*
    - Controller: Kullanıcıdan gelen HTTP isteklerini işleyen sınıflardır. İsteklere yanıt olarak 
      bir view (görünüm) veya veri döndürürler. Örneğin, bir "HomeController" sınıfı, 
      anasayfa isteklerini yönetir.
    - Action: Controller içinde tanımlanan ve belirli bir isteği işleyen metotlardır. 
      Örneğin, "Index" bir action metotudur ve genellikle varsayılan olarak çağrılır.
    - Model: Veriyi temsil eder ve iş mantığını içerir. Veri tabanı işlemleri gibi uygulamanın 
      veriyle olan tüm etkileşimlerini düzenler.
    - View: Kullanıcıya gösterilecek olan görünümleri (UI) temsil eder. Razor ile yazılır ve 
      HTML ile C# kodlarını birleştirir.
    - Razor: ASP.NET Core için kullanılan bir şablon motorudur. C# kodlarını HTML ile 
      birleştirmemizi sağlar. Örneğin, bir döngüyü veya koşulu direkt HTML içinde 
      yazabilirsiniz.
    - RazorView: Razor şablonları ile oluşturulan .cshtml dosyalarıdır. Örneğin, 
      "Index.cshtml" dosyası bir RazorView'dir.
    - wwwroot: Uygulamanın dış dünyaya sunulan statik dosyalarını barındıran klasördür. 
      Örneğin, CSS, JavaScript ve resim dosyaları burada bulunur.
    - builder.Build(): Uygulamanın yapılandırmasını tamamlar ve çalıştırılabilir bir 
      hale getirir. Middleware'ler, servisler ve pipeline bu aşamada hazırlanır.
    - app.Run(): Uygulamayı başlatır ve gelen HTTP isteklerini dinlemeye başlar. 
      Uygulamanın ana döngüsü bu metot ile çalışır.
*/
        }
    }
}
