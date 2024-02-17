using EncryptionAndDecryption.Application.Ciphers;
using EncryptionAndDecryption.Application.RemoteControl;
using EncryptionAndDecryption.Controllers;
using EncryptionAndDecryption.Models.Services.AlphabetServices;
using Microsoft.Extensions.DependencyInjection;

namespace EncryptionAndDecryption
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSingleton<ICipher, CaesarCipher>().AddSingleton<CaesarCipher>();
            builder.Services.AddSingleton<ICipher, PolybiusCipher>().AddSingleton<PolybiusCipher>();
            builder.Services.AddSingleton<ICipher, HomophonicCipher>().AddSingleton<HomophonicCipher>();

            builder.Services.AddSingleton<IAlphabetService, AlphabetService>();

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
        }
    }
}