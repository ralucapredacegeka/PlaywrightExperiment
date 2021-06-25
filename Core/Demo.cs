using Microsoft.Playwright;
using System.Threading.Tasks;

namespace Core
{
    public class Demo
    {
        static string screenshotPath = "screenshot.png";
        
        public static async Task TestPlay()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser
                //= await playwright.Chromium.LaunchAsync();
                = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    SlowMo = 500,
                });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/dotnet");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = screenshotPath });
        }

        /// <summary>
        /// Creates broqser context and goes to page
        /// </summary>
        private static async Task<IPage> GoToAsync(string url)
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500,
            });

            var context = await browser.NewContextAsync();

            // Open new page
            var page = await context.NewPageAsync();

            // Go to https://www.emag.ro/
            await page.GotoAsync(url);

            return page;
        }

        public static Page GoTo(string url)
        {
            var page = GoToAsync(url).Result;
            return new Page(page);
        }

        //public static async Task<IPage> ClickText(IPage page, string text)
        //{
        //    await page.ClickAsync("text=" + text);
        //    return page;
        //}

        //public static async Task<IPage> Click(IPage page, string selector)
        //{
        //    await page.ClickAsync(selector);
        //    return page;
        //}

        //public static async Task<IPage> Fill(IPage page, string selector, string value)
        //{
        //    await page.FillAsync(selector, value);
        //    return page;
        //}

        //public void TakeScreenshot(IPage page)
        //{
        //    var task = page.ScreenshotAsync(new PageScreenshotOptions { Path = screenshotPath });
        //    task.GetAwaiter().GetResult();
        //}

        //public static async Task TestEmag()
        //{
        //    var page = GoTo("https://www.emag.ro/").Result;

        //    // Click text=PC, Periferice & Software
        //    page =  await ClickText(page, "PC, Periferice & Software");

        //    // Click text=TV, Audio-Video & Foto
        //    page = await ClickText(page, "TV, Audio-Video & Foto");

        //    // Click text=4K Ultra HD
        //    page = await ClickText(page, "4K Ultra HD");
        //    // Assert.Equal("https://www.emag.ro/televizoare/filter/claritate-imagine-f9180,4k-v-8182405/c?ref=hp_menu_quick-nav_190_3&type=filter", page.Url);

        //    // Click img[alt="Televizor Sony 43XH8077, 108 cm, Smart Android, 4K Ultra HD, LED, Clasa G"]
        //    await page.ClickAsync("img[alt=\"Televizor Sony 43XH8077, 108 cm, Smart Android, 4K Ultra HD, LED, Clasa G\"]");
        //    // Assert.Equal("https://www.emag.ro/televizor-sony-43xh8077-108-cm-smart-android-4k-ultra-hd-led-clasa-g-kd43xh8077saep/pd/D8H4KMMBM/", page.Url);

        //    // Click div[role="main"] >> text=2.49999 Lei
        //    await page.ClickAsync("div[role=\"main\"] >> text=2.49999 Lei");

        //    // Click text=Review-uri (115)
        //    await page.ClickAsync("text=Review-uri (115)");

        //    // Click p:has-text("4.42")
        //    await page.ClickAsync("p:has-text(\"4.42\")");

        //    // Click text=Adauga in Cos
        //    await page.ClickAsync("text=Adauga in Cos");

        //    // Click text=Vezi detalii cos
        //    await page.ClickAsync("text=Vezi detalii cos");
        //    // Assert.Equal("https://www.emag.ro/cart/products?ref=add-to-cart-module_go-to-cart_button", page.Url);

        //    // Click text=Continua
        //    await page.ClickAsync("text=Continua");

        //}
    }
}
