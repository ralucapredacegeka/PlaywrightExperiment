using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Core;
using Core.Pages;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class Tests : PageTest
    {
        [Test]
        public async Task ShouldAdd()
        {
            await Core.Demo.TestPlay();
            int result = await Page.EvaluateAsync<int>("() => 7 + 3");
            Assert.AreEqual(10, result);
        }

        //[Test]
        //public async Task Emag()
        //{
        //    //await Core.Demo.TestEmag();
        //    var page = Demo.GoTo("https://www.emag.ro/").Result;

        //    // Click text=PC, Periferice & Software
        //    page = await Demo.ClickText(page, "PC, Periferice & Software");

        //    // Click text=TV, Audio-Video & Foto
        //    page = await Demo.ClickText(page, "TV, Audio-Video & Foto");

        //    // Click text=4K Ultra HD
        //    page = await Demo.ClickText(page, "4K Ultra HD");
        //    Assert.AreEqual("https://www.emag.ro/televizoare/filter/claritate-imagine-f9180,4k-v-8182405/c?ref=hp_menu_quick-nav_190_3&type=filter", page.Url);

        //}

        [Test]
        public void ShouldQPark()
        {
            // Go to https://uk-acc-website-azure.q-park.com/en-gb/
            var page = Demo.GoTo("https://uk-acc-website-azure.q-park.com/en-gb/");
            Parking parkingPage = new Parking(page);

            parkingPage
                .ClickPreBooking()
                .FillLocation("Glasgow")
                .SelectLocation("Glasgow, UK");

            // Click a[role="tab"]:has-text("Pre-booking")
            //page.Click("a[role=\"tab\"]:has-text(\"Pre-booking\")");

            //// Fill text=Where do you want to go? (Enter landmark, postcode, street, shop, etc.) Select y >> [placeholder="Search a city or address"]
            //page.Fill("[id='pre-booking'] >> input[placeholder=\"Search a city or address\"]", "Glasgow");

            //// Click div[role="tabpanel"] >> text=Glasgow, UK Glasgow Fort, M8, Glasgow, UK Glasgow Royal Infirmary, Castle Street >> div
            //page.Click("[id='pre-booking'] >> text=Glasgow, UK");

            parkingPage.TakeScreenshot();

        }
    }
}