
namespace Certyfikacja
{
    public abstract class SkiJumpingBase : ISkiJumping
    {
        public delegate void ScoreAddedDelegate(object sender, EventArgs args);

        public abstract event ScoreAddedDelegate ScoreAdded;
        public SkiJumpingBase(string name,string surname, string nationality)
        {
            this.Name = name;   
            this.Surname = surname;
            this.Nationality = nationality;
        }
        public string Name { get; }
        public string Surname { get; }
        public string Nationality { get; }



        public abstract void AddScore(float score);
        public abstract void AddScore(double score);
        public abstract void AddScore(long score);
        public abstract void AddScore(string score);
        public abstract void AddScore(char score);
        public abstract Statistics GetStatistics();                  
    }
}

