using System;
using System.Text;
using TrailScoringEngine.Controllers;

namespace TrailScoreEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in new HtmlController().GetResults())
            {
                sb.AppendLine(item.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
