using System.Collections.Generic;
using TrailScoringEngine.Models;
using TrailScoringEngine.Services;

namespace TrailScoringEngine.Controllers
{
    public class HtmlController
    {
        public List<RunnerResult> GetResults()
        {
            var rmt = new RmtService();
            return rmt.GetResults("https://ratemytrail.com/results/lemkowyna-ultra-trail-2021-lut-150-jesien");
    }
    }
}
