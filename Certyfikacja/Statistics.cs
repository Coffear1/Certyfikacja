namespace Certyfikacja
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }

        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 180:
                        return 'A';
                    case var average when average >= 150:
                        return 'B';
                    case var average when average >= 120:
                        return 'C';
                    case var average when average >= 90:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddScore(float score)
        {
            this.Count++;
            this.Sum += score;
            this.Min = Math.Min(this.Min, score);
            this.Max = Math.Max(this.Max, score);
        }
    }
}
