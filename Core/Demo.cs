using Microsoft.Playwright;
using System.Threading.Tasks;

namespace Core
{
    public class Demo
    {
        public static async Task TestPlay()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser
                //= await playwright.Chromium.LaunchAsync();
                = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    SlowMo = 300,
                });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/dotnet");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }
    }
}
