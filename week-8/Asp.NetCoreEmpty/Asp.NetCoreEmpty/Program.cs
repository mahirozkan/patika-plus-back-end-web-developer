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

            // HTTP isteklerinin i�lenmesi i�in pipeline yap�land�rmas�
            if (!app.Environment.IsDevelopment()) // Geli�tirme ortam�nda de�ilse
            {
                app.UseExceptionHandler("/Home/Error");  // Hata durumlar�nda �zel bir hata sayfas�na y�nlendirme
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); // HTTP Strict Transport Security (HSTS) protokol�n� etkinle�tirir
            }

            app.UseHttpsRedirection(); // HTTP isteklerini otomatik olarak HTTPS'e y�nlendirir
            app.UseStaticFiles(); // wwwroot klas�r�ndeki statik dosyalar�n kullan�lmas�n� sa�lar

            app.UseRouting(); // Routing yap�land�rmas�n� etkinle�tirir

            app.UseAuthorization(); // Yetkilendirme i�lemleri i�in middleware eklenir

            app.MapControllerRoute( // Varsay�lan routing yap�land�rmas�
                name: "default", // Routing'in ad�
                pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsay�lan olarak HomeController'�n Index action'� �a�r�l�r.

            app.Run(); // Uygulamay� �al��t�r�r

            /*
            - builder: Uygulama olu�turulurken yap�land�rmalar�n yap�ld��� nesne
            - builder.Services.AddControllersWithViews(): MVC mimarisinde controller ve view kullan�m�n� aktif eder
            - app.Environment.IsDevelopment(): Geli�tirme ortam�nda olup olmad���n� kontrol eder
            - app.UseHttpsRedirection(): T�m HTTP isteklerini HTTPS'ye y�nlendirir
            - app.UseStaticFiles(): wwwroot klas�r�ndeki statik dosyalar� servis eder
            - app.UseRouting(): Gelen isteklerin do�ru controller ve action'a y�nlendirilmesini sa�lar
            - app.MapControllerRoute(): Varsay�lan routing'i tan�mlar (�r. /Home/Index)
            - app.Run(): Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinler
            */
        }
    }
}
