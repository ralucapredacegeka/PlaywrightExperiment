using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Pages
{
    public class Parking : Page
    {
        public Parking() : base(page)
        {
        }

        public Parking(IPage p) : base (p)
        {
        }

        private string panelSelector;
        private string PreBookingPanelSelector = "[id='pre-booking']";
        private string SearchParkingPanelSelector = "[id='search-parking']";


        public Parking ClickPreBooking()
        {
            Click("a[role=\"tab\"]:has-text(\"Pre-booking\")");
            panelSelector = PreBookingPanelSelector;
            return this;
        }

        public Parking FillLocation(string location)
        {
            Fill($"{panelSelector} >> input[placeholder=\"Search a city or address\"]", location);
            return this;
        }

        public Parking SelectLocation(string location)
        {
            Click($"{panelSelector} >> text={location}");
            return this;
        }

        public Parking SetDate() 
        { return this; }

        public Parking ClickSubmit() 
        { return this; }

    }
}
