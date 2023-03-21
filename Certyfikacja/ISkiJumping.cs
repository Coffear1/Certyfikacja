

namespace Certyfikacja
{
    public interface ISkiJumping
    {
        string Name { get; }
        string Surname { get; }
        string Nationality { get; }
        void AddScore(float score);
        void AddScore(string score);
        void AddScore(char score);
        Statistics GetStatistics();
    }
}
