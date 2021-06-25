using Microsoft.Playwright;
using System.Threading.Tasks;

namespace Core
{
    public class Page
    {
        static string screenshotPath = "screenshot.png";
        public static IPage page;

        //public IPage GetPage()
        //{
        //    return _page;
        //}

        public Page(IPage page)
        {
            Page.page = page;
        }

        public Page ClickText(string text)
        {
            var task = page.ClickAsync("text=" + text);
            task.GetAwaiter().GetResult();
            return this;
        }

        public Page Click(string selector)
        {
            var task = page.ClickAsync(selector);
            task.GetAwaiter().GetResult();
            return this;
        }

        public Page Fill(string selector, string value)
        {
            var task = page.FillAsync(selector, value);
            task.GetAwaiter().GetResult();
            return this;
        }

        public void TakeScreenshot()
        {
            var task = page.ScreenshotAsync(new PageScreenshotOptions { Path = screenshotPath });
            task.GetAwaiter().GetResult();
        }

    }
}
