using Certyfikacja;

namespace SkiJumpingTest
{
    public class SkiJumpingTest
    {
        [Test]
        public void TestStatisticsForMinResult()
        {
            var skiJumper = new SkiJumpingInFile("Adam", "Ma造sz", "Polska");
            skiJumper.AddScore(190);
            skiJumper.AddScore(200);
            skiJumper.AddScore(195.5);

            var statistics = skiJumper.GetStatistics();

            Assert.AreEqual(statistics.Min, 190);
        }

        [Test]
        public void TestStatisticsForMaxResult()
        {
            var skiJumper = new SkiJumpingInMemory("Adam", "Ma造sz", "Polska");
            skiJumper.AddScore(190);
            skiJumper.AddScore(200);
            skiJumper.AddScore(195.5);

            var statistics = skiJumper.GetStatistics();

            Assert.AreEqual(statistics.Max, 200);
        }

        [Test]
        public void TestStatisticsForAverageResult()
        {
            var skiJumper = new SkiJumpingInMemory("Adam", "Ma造sz", "Polska");
            skiJumper.AddScore(190);
            skiJumper.AddScore(200);
            skiJumper.AddScore(195);

            var statistics = skiJumper.GetStatistics();

            Assert.AreEqual(statistics.Average, 195);
        }

        [Test]
        public void TestStatistiscForAverageLetterResult()
        {
            var skiJumper = new SkiJumpingInMemory("Adam", "Ma造sz", "Polska");
            skiJumper.AddScore(150);
            skiJumper.AddScore(165);
            skiJumper.AddScore(160);

            var statistics = skiJumper.GetStatistics();

            Assert.AreEqual(statistics.AverageLetter, 'B');
        }

        [Test]
        public void TestForTwoDifferentSkiJumpers()
        {
            var skiJumper1 = new SkiJumpingInMemory("Adam", "Ma造sz", "Polska");
            var skiJumper2 = new SkiJumpingInMemory("Dawid", "Kubacki", "Polska");

            Assert.AreNotSame(skiJumper1, skiJumper2 );
        }

        [Test]
        public void TestForTwoTheSameSkiJumpers()
        {
            var skiJumper1 = new SkiJumpingInMemory("Adam", "Ma造sz", "Polska");
            var skiJumper2 = skiJumper1;

            Assert.True(skiJumper1  == skiJumper2); 


        }

        

    }   
} 