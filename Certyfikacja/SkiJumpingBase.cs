
namespace Certyfikacja
{
    public abstract class SkiJumpingBase : ISkiJumping
    {
        public delegate void ScoreAddedDelegate(object sender, EventArgs args);

        public abstract event ScoreAddedDelegate ScoreAdded;
        public SkiJumpingBase(string name, string surname, string nationality)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nationality = nationality;
        }

        public string Name { get; }
        public string Surname { get; }
        public string Nationality { get; }
        public abstract void AddScore(float score);

        public void AddScore(double score)
        {
            float DoubleAsFloat = (float)score;
            this.AddScore(DoubleAsFloat);
        }

        public void AddScore(long score)
        {
            float LongAsFloat = (float)score;
            this.AddScore(LongAsFloat);
        }

        public void AddScore(string score)
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

        public void AddScore(char score)
        {
            float CharAsFloat = (float)score;
            this.AddScore(CharAsFloat);
        }
        public abstract Statistics GetStatistics();
    }
}

