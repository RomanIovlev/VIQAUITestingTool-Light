﻿using VIQA.HAttributes;
using VIQA.SiteClasses;
using Settings.VITestsProject.Site.Sections;

namespace Settings.VITestsProject.Site.Pages
{
    [Page(Title = "Яндекс.Маркет", Url = "http://market.yandex.ru/")]
    public class HomePage : VIPage
    {
        [Name("Search section")]
        [Locate(ByClassName = "b-head-search")]
        public SearchSection SearchSection;

    }
}
