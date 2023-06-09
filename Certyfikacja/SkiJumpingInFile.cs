﻿
namespace Certyfikacja
{
    public class SkiJumpingInFile : SkiJumpingBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        private const string fileName = "odległośći skoków.txt";

        public SkiJumpingInFile(string name, string surname, string nationality)
            : base(name, surname, nationality)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 260)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                }
            }
            else
            {
                throw new Exception("Takiego Skoku jeszcze nie widzieliśmy");
            }
            if (score >= 190 && score <= 260 && ScoreAdded != null)
            {
                ScoreAdded(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
        {
            var scoreFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(scoreFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddScore(grade);
            }
            return statistics;
        }
    }
}
