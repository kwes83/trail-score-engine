using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System.Collections.Generic;
using System.Linq;
using TrailScoringEngine.Models;

namespace TrailScoringEngine.Services
{
    public class RmtService
    {
        public List<RunnerResult> GetResults(string url)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            var data = doc.DocumentNode.Descendants("div").Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("container-fluid px-2")).First();
            
            List<RunnerResult> results = new List<RunnerResult>();

            for (int i = 1; i < data.QuerySelectorAll(".row.py-2.zebra").Count; i++)
            {
                var row = data.QuerySelectorAll(".row.py-2.zebra")[i];

                var position = row.Descendants("abbr").Where(d => d.Attributes.Contains("info") && d.Attributes["info"].Value.StartsWith("Pozycja")).First().Attributes["info"].Value.Replace("Pozycja #",string.Empty);
                //var score = row.Descendants("span").QuerySelectorAll(".me-2").First().InnerText;

                results.Add(new RunnerResult()
                {
                    Position = int.Parse(position),
                    //Score = int.Parse(score)
                }) ;
            }
            return results;
        }
    }
}
