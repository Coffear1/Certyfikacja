namespace Certyfikacja
{
    public class SkiJumpingInMemory : SkiJumpingBase
    {

        public override event ScoreAddedDelegate ScoreAdded;

        private List<float> scores = new List<float>();

        public SkiJumpingInMemory(string name, string surname, string nationality)
            : base(name, surname, nationality)
        {
        }
        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 260)
            {
                this.scores.Add(score);
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
            var statistics = new Statistics();
            foreach (var score in this.scores)
            {
                statistics.AddScore(score);
            }
            return statistics;
        }
    }
}
