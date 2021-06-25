using System.Threading.Tasks;

namespace Core
{

    public class QPark
    {
        public static async Task QparkTest()
        {

            //    // Click text=Select your arrival date and time Start date is required hh:mm12:3013:0013:3014: >> input[type="text"]
            //    await page.ClickAsync("text=Select your arrival date and time Start date is required hh:mm12:3013:0013:3014: >> input[type=\"text\"]");
            //    // Click text=28
            //    await page.ClickAsync("text=28");
            //    // Click #ui-id-3
            //    await page.ClickAsync("#ui-id-3");
            //    // Click text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> input[type="text"]
            //    await page.ClickAsync("text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> input[type=\"text\"]");
            //    // Click td:has-text("30")
            //    await page.ClickAsync("td:has-text(\"30\")");
            //    // Click #ui-id-51
            //    await page.ClickAsync("#ui-id-51");
            //    // Click text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder="hh:mm"]
            //    await page.ClickAsync("text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder=\"hh:mm\"]");
            //    // Fill text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder="hh:mm"]
            //    await page.FillAsync("text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder=\"hh:mm\"]", "0");
            //    // Click text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder="hh:mm"]
            //    await page.ClickAsync("text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder=\"hh:mm\"]");
            //    // Fill text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder="hh:mm"]
            //    await page.FillAsync("text=Select your departure date and time End date is required hh:mm00:0000:3001:0001: >> [placeholder=\"hh:mm\"]", "02:00");
            //    // Go to https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/product/?pId=7&placeid=7&startdate=28/06/2021&starttime=00:00&enddate=30/06/2021&endtime=02:00&prodid=14829&recurrence=3&sid=71646d40-efad-492a-b08c-4b5123df798a
            //    await page.GotoAsync("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/product/?pId=7&placeid=7&startdate=28/06/2021&starttime=00:00&enddate=30/06/2021&endtime=02:00&prodid=14829&recurrence=3&sid=71646d40-efad-492a-b08c-4b5123df798a");
            //    // Click text=Sauchie Fixed addon £ 12.00 >> span
            //    await page.ClickAsync("text=Sauchie Fixed addon £ 12.00 >> span");
            //    // Click text=Next
            //    await page.RunAndWaitForNavigationAsync(async () =>
            //    {
            //        await page.ClickAsync("text=Next");
            //    }/*, new PageWaitForNavigationOptions
            //{
            //    UrlString = "https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/product/?pId=7&placeid=7&startdate=28/06/2021&starttime=00:00&enddate=30/06/2021&endtime=02:00&prodid=14829&recurrence=3&sid=71646d40-efad-492a-b08c-4b5123df798a"
            //}*/);
            //    // Assert.Equal("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/product/?pId=7&placeid=7&startdate=28/06/2021&starttime=00:00&enddate=30/06/2021&endtime=02:00&prodid=14829&recurrence=3&sid=71646d40-efad-492a-b08c-4b5123df798a", page.Url);
            //    // Go to https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/product/?pId=7&placeid=7&startdate=28/06/2021&starttime=00:00&enddate=30/06/2021&endtime=02:00&prodid=14829&recurrence=3&sid=71646d40-efad-492a-b08c-4b5123df798a
            //    await page.GotoAsync("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/product/?pId=7&placeid=7&startdate=28/06/2021&starttime=00:00&enddate=30/06/2021&endtime=02:00&prodid=14829&recurrence=3&sid=71646d40-efad-492a-b08c-4b5123df798a");
            //    // Click h4:has-text("Sauchiehall Hour 1po")
            //    await page.ClickAsync("h4:has-text(\"Sauchiehall Hour 1po\")");
            //    // Click text=Sauchie Fixed addon £ 12.00 >> span
            //    await page.ClickAsync("text=Sauchie Fixed addon £ 12.00 >> span");
            //    // Click text=Next
            //    await page.ClickAsync("text=Next");
            //    // Assert.Equal("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/authentication/?sid=71646d40-efad-492a-b08c-4b5123df798a", page.Url);
            //    // Click text=Your personal details Already have an account? Login >> a
            //    await page.ClickAsync("text=Your personal details Already have an account? Login >> a");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Fill text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.FillAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "junereg-b-st@mailinator.com");
            //    // Click [placeholder="Password"]
            //    await page.ClickAsync("[placeholder=\"Password\"]");
            //    // Fill [placeholder="Password"]
            //    await page.FillAsync("[placeholder=\"Password\"]", "Test2021");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowLeft
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowLeft");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Fill text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.FillAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "junereg-b-st-nlacc@mailinator.com");
            //    // Click button:has-text("Login")
            //    await page.ClickAsync("button:has-text(\"Login\")");
            //    // Assert.Equal("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/authentication/?sid=71646d40-efad-492a-b08c-4b5123df798a", page.Url);
            //    // Click html
            //    await page.ClickAsync("html");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Click text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.ClickAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]");
            //    // Fill text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.FillAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "junereg-b-st-nlacc@mailiator.com");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press ArrowRight
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "ArrowRight");
            //    // Press a with modifiers
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "Control+a");
            //    // Fill text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.FillAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "");
            //    // Press z with modifiers
            //    await page.PressAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "Control+z");
            //    // Fill text=E-mail address Enter your e-mail address >> [placeholder="E-mail address"]
            //    await page.FillAsync("text=E-mail address Enter your e-mail address >> [placeholder=\"E-mail address\"]", "jonny-bravo-a@mailinator.com");
            //    // Click [placeholder="Password"]
            //    await page.ClickAsync("[placeholder=\"Password\"]");
            //    // Fill [placeholder="Password"]
            //    await page.FillAsync("[placeholder=\"Password\"]", "Test2021");
            //    // Go to https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/authentication/?sid=71646d40-efad-492a-b08c-4b5123df798a
            //    await page.GotoAsync("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/authentication/?sid=71646d40-efad-492a-b08c-4b5123df798a");
            //    // Click span[role="combobox"] span
            //    await page.ClickAsync("span[role=\"combobox\"] span");
            //    // Click a:has-text("GB")
            //    await page.ClickAsync("a:has-text(\"GB\")");
            //    // Click input[name="lp-0"]
            //    await page.ClickAsync("input[name=\"lp-0\"]");
            //    // Fill input[name="lp-0"]
            //    await page.FillAsync("input[name=\"lp-0\"]", "Playtest1");
            //    // Click .your-information section:nth-child(3) .section-body div
            //    await page.ClickAsync(".your-information section:nth-child(3) .section-body div");
            //    // Go to https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/orderoverview/?sid=71646d40-efad-492a-b08c-4b5123df798a
            //    await page.GotoAsync("https://uk-acc-website-azure.q-park.com/en-gb/shop/prebooking/orderoverview/?sid=71646d40-efad-492a-b08c-4b5123df798a");
            //    // Click text=PLAYTEST1
            //    await page.ClickAsync("text=PLAYTEST1");
            //    // Click text=GB
            //    await page.ClickAsync("text=GB");
            //    // Click text=Sauchiehall Hour 1po
            //    await page.ClickAsync("text=Sauchiehall Hour 1po");
            //    // Click text=Sauchie Fixed addon
            //    await page.ClickAsync("text=Sauchie Fixed addon");

            //await page.ScreenshotAsync(new PageScreenshotOptions { Path = @"C:\Users\roxanadn\source\repos\PlaywrightExperiment\PlaywrightTests\Screenshots\screenshot.png" });
        }
    }

}