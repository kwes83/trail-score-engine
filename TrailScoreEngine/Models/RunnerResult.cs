using System;

namespace TrailScoringEngine.Models
{
    public class RunnerResult
    {
        public int Position { get; set; }
        public string RunnerName { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan Pace { get; set; }
        public TimeSpan FAP { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{Position} : {RunnerName} - {Score}";
        }
    }
}
