using System.Collections.Generic;

using TestAvalonia.Models;

namespace TestAvalonia.Services;
public class SiteIdService
{
    public IEnumerable<SiteIdModel> GetSiteIds() => new[]
    {
        new SiteIdModel { SiteNumber = "1" },
        new SiteIdModel { SiteNumber = "2" },
        new SiteIdModel { SiteNumber = "3" },
        new SiteIdModel { SiteNumber = "4" },
        new SiteIdModel { SiteNumber = "5" },
        new SiteIdModel { SiteNumber = "6" },
        new SiteIdModel { SiteNumber = "7" },
        new SiteIdModel { SiteNumber = "8" },
        new SiteIdModel { SiteNumber = "9" },
    };
}
