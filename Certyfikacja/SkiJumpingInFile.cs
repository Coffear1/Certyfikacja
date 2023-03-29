

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
                    writer.WriteLine(score) ;
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

        public override void AddScore(double score)
        {
            float DoubleAsFloat = (float)score;
            this.AddScore(DoubleAsFloat);
        }

        public override void AddScore(long score)
        {
            float LongAsFloat = (float)score;
            this.AddScore(LongAsFloat);
        }

        public override void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore((float)result);
            }
            else
            {
                throw new Exception("String nie jest floatem");
            }

        }

        public override void AddScore(char score)
        {
            float CharAsFloat = (float)score;
            this.AddScore(CharAsFloat);
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
#pragma warning disable CA1305 // Określ interfejs IFormatProvider
                        var number = float.Parse(line);
#pragma warning restore CA1305 // Określ interfejs IFormatProvider
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
