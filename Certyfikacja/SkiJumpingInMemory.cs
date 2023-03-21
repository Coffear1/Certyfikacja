

namespace Certyfikacja
{
    public class SkiJumpingInMemory : SkiJumpingBase
    {
        private List<float>scores = new List<float>();
        public SkiJumpingInMemory(string name, string surname, string nationality)
            : base(name, surname, nationality)
        {
        }
        public override void AddScore(float score)
        {
           if(score >= 0 && score <=260)
           {
                this.scores.Add(score);
           }
            else
            {
                throw new Exception("Takiego Skoku jeszcze nie widzieliśmy");
            }
        }

        public override void AddScore(string score)
        {
           
        }

        public override void AddScore(char score)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
