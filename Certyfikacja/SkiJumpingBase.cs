
namespace Certyfikacja
{
    public abstract class SkiJumpingBase : ISkiJumping
    {
        public SkiJumpingBase(string name,string surname, string nationality)
        {
            this.Name = name;   
            this.Surname = surname;
            this.Nationality = nationality;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Nationality { get; private set; }



        public abstract void AddScore(float score);
        public abstract void AddScore(string score);
        public abstract void AddScore(char score);
        public abstract Statistics GetStatistics();                  
    }
}
