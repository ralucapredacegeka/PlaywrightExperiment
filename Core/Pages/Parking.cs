using Microsoft.Playwright;

namespace Core.Pages
{
    public class Parking : Page
    {
        public Parking() : base(page)
        {
        }

        public Parking(IPage p) : base(p)
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

        public Parking SetStartDate(string date)
        {
            Fill($"{panelSelector} >> xpath=//input[contains(@class,'startDatePicker')]", date); 
            return this;
        }

        public Parking SetStartTime(string time)
        {
            Fill($"{panelSelector} >> xpath=//input[contains(@class,'startTimePickerDesktop')]", time);
            return this;
        }

        public Parking SetEndDate(string date)
        {
            Fill($"{panelSelector} >> xpath=//input[contains(@class,'endDatePicker') and @type='text']", date);
            return this;
        }

        public Parking SetEndTime(string time)
        {
            Fill($"{panelSelector} >> xpath=//input[contains(@class,'endTimePickerDesktop')]", time);            
            return this;
        }

        public Parking ClickSearch()
        {
            Click($"{panelSelector} >> button[type='submit']");
            return this; 
        }

    }
}
